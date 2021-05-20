using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeController;
using Excel = Microsoft.Office.Interop.Excel;

namespace WinFormsApp1
{

    public partial class Form1 : Form

    {
        static Excel.Application excelApp = null;
        static Excel.Workbook workbook = null;
        static Excel.Worksheet worksheet = null;

        private static string userNumber;
        private string Id;
        private string _url;
        private string stitle;
        YouTubeService youtube;
        private string channelUrl;
        // try catch문 추가 , 로그인, 회원가입 회원별로 링크 내역보여주기
        public Form1()
        {
            InitializeComponent();
            youtube = new YouTubeService(new BaseClientService.Initializer//유튜브 연결 알트 + 엔터 
            //도구상자 컨트롤 + 알트 + X 
            {
                ApiKey = "AIzaSyBl4Q7dDv1Y0tDnbsn4oBYnFRbvxNMhbV4",//절대 아무도 보여주시면 안됩니다.
            });//유튜브 연결
            string a =textBox3.Text;

        }





        /// <summary>
        /// URL주소이미지를 이미지로 변환하기
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private Image GetUrlImage(string url)
        {
            using (WebClient client = new WebClient())
            {
                byte[] imgArray;
                imgArray = client.DownloadData(url);

                using (MemoryStream memstr = new MemoryStream(imgArray))
                {
                    Image img = Image.FromStream(memstr);
           
                    return img;
                }
            }
          }

        static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string path = Path.Combine(desktopPath, "User.xlsx");

        private void ExcelLoad()
        {


            try
            {


                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Open(path);
                worksheet = workbook.Worksheets.get_Item(1) as Excel.Worksheet;

                int t = Convert.ToInt32(label7.Text);

                string userUrl= Convert.ToString( (worksheet.Cells[t, 3] as Excel.Range).Value2).Replace(",", "\r\n"); ;
                textBox3.Text = userUrl;


                worksheet.Columns.AutoFit(); // 열 너비 자동 맞춤
                
                workbook.Close(true);
                excelApp.Quit();
            }
            finally { CreateUser.ReleaseObject(worksheet); CreateUser.ReleaseObject(workbook); CreateUser.ReleaseObject(excelApp); }

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            WebBrowser webBrowser = new WebBrowser();
            string[] eid = textBox1.Text.Substring(32).Split('&');
            this.Id =eid[0];
            this._url = $"https://img.youtube.com/vi/{this.Id}/maxresdefault.jpg";
            this.pictureBox1.Image = GetUrlImage(_url);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.webView21.Source = new System.Uri($"https://www.youtube.com/embed/{this.Id}") ;
            YoutubeAPi();
            
        }
        private  int TimeSeconds(string timeStamp)
        {
            string[] b = { };

            string t = timeStamp.Replace("PT", String.Empty);
            int c = timeStamp.IndexOf("M");
            string test = "";
            int second = 0;
            if (c != -1)
            {
                b = t.Split("M");
                second = Convert.ToInt32(b[0]) * 60;
                test = b[1].Replace("S", String.Empty);
                second += Convert.ToInt32(test);
            }
            else
            {
                b = t.Split("S");
                second = Convert.ToInt32(b[0]);
            }
            return second;
        }
        private static string TimeString(string timeStamp)
        {
            string result = timeStamp.Replace("PT", String.Empty).Replace("M", "분").Replace("S", "초");

            return result;
        }
       
        async void YoutubeAPi()
        {

            

            //비동기, 동기 
            //비동기 : 해결 속도 동기 보다 느림, 대신 이 명령어 하고 있을 때 다른 일을 동시에 해결 할 수 있음
            //동기 : 비동기보다 빠르고 대신 이 명령어를 하는 동안 다른 명령어를 수행못함

            // viewCount,likecount, dislikecount, commentcount
            VideosResource.ListRequest count_like_dislike_view = youtube.Videos.List("statistics");//Videos statistics 연결
            count_like_dislike_view.Id = $"{this.Id}";
            VideoListResponse countview_res = await count_like_dislike_view.ExecuteAsync();
            viewCount.Text= Convert.ToString(countview_res.Items[0].Statistics.ViewCount);//
            likeCount.Text = Convert.ToString(countview_res.Items[0].Statistics.LikeCount);
            dislikeCount.Text = Convert.ToString(countview_res.Items[0].Statistics.DislikeCount);
            commentCount.Text = Convert.ToString(countview_res.Items[0].Statistics.CommentCount);
            

            // title, description, channelId, chnnelTitle, publichedAt
            VideosResource.ListRequest snippet = youtube.Videos.List("snippet");//Videos statistics 연결
            snippet.Id = $"{this.Id}";
            VideoListResponse snippet_res = await snippet.ExecuteAsync();
            this.stitle = Convert.ToString(snippet_res.Items[0].Snippet.Title);
            title.Text = this.stitle;
            descriptionBox.Text ="\n\n"+ Convert.ToString(snippet_res.Items[0].Snippet.Description.Replace("\n", "\r\n"));
            ChannelsResource.ListRequest yChannnelId = youtube.Channels.List("statistics");
            string channelId = snippet_res.Items[0].Snippet.ChannelId;
            yChannnelId.Id = channelId;
            ChannelListResponse yChnnelId_res = await yChannnelId.ExecuteAsync();
            // 구독자 수
            godog.Text = " 채널 구독자 수: "+Convert.ToString( yChnnelId_res.Items[0].Statistics.SubscriberCount)+" 명";

            channelTitle.Text = Convert.ToString(snippet_res.Items[0].Snippet.ChannelTitle);
            
            this.channelUrl = "https://www.youtube.com/channel/" + channelId;
            // title, description, channelId, chnnelTitle, publichedAt
            VideosResource.ListRequest contentDetials = youtube.Videos.List("contentDetails");//Videos statistics 연결
            contentDetials.Id = $"{this.Id}";
            VideoListResponse contentDetails_res = await contentDetials.ExecuteAsync();
            int timeSeconds = TimeSeconds(contentDetails_res.Items[0].ContentDetails.Duration);
            string timeString = TimeString(contentDetails_res.Items[0].ContentDetails.Duration);
            videoLength.Text = timeString;


            //status.embeddable	해야할것
            trackBar1.Maximum =timeSeconds;
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
         public void DownloadImageFromUrl(string imgUrl, string imgPath)
            { 
            using (WebClient client = new WebClient()) {
                client.DownloadFile(new Uri(imgUrl), imgPath);

            }
        }
        private bool DownloadRemoteImageFile(string uri, string fileName)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            bool bImage = response.ContentType.StartsWith("image",
                StringComparison.OrdinalIgnoreCase);
            if ((response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Moved ||
                response.StatusCode == HttpStatusCode.Redirect) &&
                bImage)
            {
                using (Stream inputStream = response.GetResponseStream())
                using (Stream outputStream = File.OpenWrite(fileName))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    do
                    {
                        bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                        outputStream.Write(buffer, 0, bytesRead);
                    } while (bytesRead != 0);
                }

                return true;
            }
            else
            {
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            string save_route = @"C:\Users\emibg\Desktop\YoutubeController";

        
            if (!System.IO.Directory.Exists(save_route)){
                System.IO.Directory.CreateDirectory(save_route);
                
            }
            DownloadRemoteImageFile(this._url, $@"C:\Users\emibg\Desktop\YoutubeController\{this.stitle}.jpg");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ExcelLoad();
             
        }
        public void EventMethod(string str)
        {
            textBox3.Text = str.ToString();
        }

        private void DataGet(string item1)
        {
            textBox3.Text = item1;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int time = trackBar1.Value;
            int seconds =time % 3600 % 60 ;
            int minutes = time % 3600 / 60;
            timeLableSeconds.Text = Convert.ToString(seconds)+"초 :";
            timeLableMinute.Text = Convert.ToString(minutes)+"분";
            timeUrlSource.Text = $"https://www.youtube.com/watch?v={this.Id}&t={minutes}m{seconds}s";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            channelTitle.LinkVisited = true;        
            System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", channelUrl);
        }

        private void videoDownloadUrl_Click(object sender, EventArgs e)
        {
            string te = $"https://www.ssyoutube.com/watch?v={this.Id}";
            System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", te);
        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addUrlButton_Click(object sender, EventArgs e)
        {
            try
            {
                int t = Convert.ToInt32(label7.Text);
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Open(path);
                worksheet = workbook.Worksheets.get_Item(1) as Excel.Worksheet;
                worksheet.Cells[t, 3] = textBox3.Text.Replace("없음",string.Empty) + textBox1.Text+",";
                textBox3.Text= Convert.ToString(( worksheet.Cells[t, 3] as Excel.Range).Value2).Replace(",","\r\n");
                worksheet.Columns.AutoFit(); // 열 너비 자동 맞춤
                workbook.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault); // 엑셀 파일 저장
                workbook.Close(true);
                excelApp.Quit();
            }
            finally
            {
                CreateUser.ReleaseObject(worksheet); CreateUser.ReleaseObject(workbook); CreateUser.ReleaseObject(excelApp);

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
            Close();
        }
    }
    }

    
