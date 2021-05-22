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
        // 폼이 실행되면서 진행되는 코드들
        static Excel.Application excelApp = null;
        static Excel.Workbook workbook = null;
        static Excel.Worksheet worksheet = null;

        // 비디오 ID, 유저 번호, URL, 제목, 채널 URL 등의 정보 생성 (한개 이상의 메소드에서 사용)
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

        // Excel 파일이 들어갈 경로
        static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string path = Path.Combine(desktopPath, "User.xlsx");// 경로와 함께 데이터를 담고 있을 엑셀 자료명 적용

        private void ExcelLoad()
        {

            // Excel 불러오기
            try
            {


                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Open(path);
                worksheet = workbook.Worksheets.get_Item(1) as Excel.Worksheet;

                // 유저가 있는 줄 파악
                int userLine = Convert.ToInt32(label7.Text);

                string userUrl= Convert.ToString( (worksheet.Cells[userLine, 3] as Excel.Range).Value2).Replace(",", "\r\n"); ; // 해당 줄에 있는  Url 정보들 Load
                textBox3.Text = userUrl; // 유저가 추가했었던 URL들을 출력 


                worksheet.Columns.AutoFit(); // 열 너비 자동 맞춤
                
                workbook.Close(true); // 워크북 닫기
                excelApp.Quit(); // 엑셀 닫기
            }
            finally { CreateUser.ReleaseObject(worksheet); CreateUser.ReleaseObject(workbook); CreateUser.ReleaseObject(excelApp); } // 메모리 할당 종료

            
        }


        // URL Serching Button 클릭시 진행되는 메소드
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            WebBrowser webBrowser = new WebBrowser();
            string[] eid = textBox1.Text.Substring(32).Split('&');
            // 유튜브의 동영상 URL은 기존의 유튜브 기본 URL 에서 각 비디오들 만의 고유번호인 Video Id를 통하여 URL이 생성된다.
            // URL에서 기본 URL과 Video Id를 구분해주는 법은 https://www.youtube.com/watch?v= 뒤로 오는 문자들이 비디오 ID라고 볼수 있는데
            // 해당 문자열에서 = 까지의 길이가 32이며 뒤에 &가 있는경우가 있으니 스플릿을 통하여 한번 더 필터링 해준다
            this.Id =eid[0];
            this._url = $"https://img.youtube.com/vi/{this.Id}/maxresdefault.jpg"; 
            // 해당 유튜브 URL에서 vi/와 /maxresdefault.jpg 사이에 비디오 ID를 넣어주면 유튜브 영상 썸네일 사진을 얻을 수 있다.
            this.pictureBox1.Image = GetUrlImage(_url);
            // 해당 url에 있는 썸네일 사진을 pictureBox에 삽입
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.webView21.Source = new System.Uri($"https://www.youtube.com/embed/{this.Id}") ;
            //  컨트롤러에 나오는 유튜브 영상은 HTML과 URL 통해 보여주기 때문에 webView에다가 해당 Video Id가 적힌 URL을 적용
            YoutubeAPi();
            
        }

        // YouTube에서 제공하는 API에서 비디오의 영상 시간을 PT분M초S 형식으로 제공하기 때문에 이를 초 단위로 환산하여 int 값으로 넘겨주는 메소드
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

        // PT분M초S 형식을 00 분 00 초 형식으로 바꿔주는 메소드
        private static string TimeString(string timeStamp)
        {
            string result = timeStamp.Replace("PT", String.Empty).Replace("M", "분").Replace("S", "초");

            return result;
        }
       
        // Youtube 에서 제공하는 API, 영상 제목, 영상 정보, 영상 길이, 영상 조회수, 영상 설명, 영상 좋아요,싫어요 수, 댓글 수 게시자 채널명, 해당 채널 구독자 수, 
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


        // 가져온 썸네일 URL을 통해 컴퓨터에 저장 해주는 메소드

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


        // 썸네일 이미지 다운로드
        private void button2_Click(object sender, EventArgs e)
        {
            
            string save_route = @"C:\Users\emibg\Desktop\YoutubeController";

        
            if (!System.IO.Directory.Exists(save_route)){
                System.IO.Directory.CreateDirectory(save_route);
                
            }
            DownloadRemoteImageFile(this._url, $@"C:\Users\emibg\Desktop\YoutubeController\{this.stitle}.jpg");

        }

        // 폼이 Load 되면서 회원 정보를 통하여 Excel안에서 Use URL 추출
        private void Form1_Load(object sender, EventArgs e)
        {

            ExcelLoad();
             
        }

        // 기본 비디오 URL에 &t=0m0s를 통하여 URL 로드시 해당 분 초로 바로 갈수 있는 시간 공유 URL있는데
        // 해당 영상 길이와 Track Bar 를 통하여 사용자가 트랙바를 통하여 시간 공유 URL을 제작 및 조절 할 수 있게 제공
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int time = trackBar1.Value;
            int seconds =time % 3600 % 60 ;
            int minutes = time % 3600 / 60;
            timeLableSeconds.Text = Convert.ToString(seconds)+"초 :";
            timeLableMinute.Text = Convert.ToString(minutes)+"분";
            timeUrlSource.Text = $"https://www.youtube.com/watch?v={this.Id}&t={minutes}m{seconds}s";

        }

        // 해당 영상 게시 채널의 홈페이지로 바로 갈 수 있게 Link Lable에 URL 설정
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            channelTitle.LinkVisited = true;        
            System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", channelUrl);
        }

        // 기본 Video URL에서 youtube 앞에 ss 를 붙이면 해당 비디오를 다운 받을 수 있는 특정 사이트로 이동 가능
        private void videoDownloadUrl_Click(object sender, EventArgs e)
        {
            string te = $"https://www.ssyoutube.com/watch?v={this.Id}";
            System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", te);
        }

        // 해당 유저가 URL을 추가하여 다음에 로그인 시에 내가 이전에 추가 했던 URL를 다시 볼 수 있도록 유저 정보가 닮겨 있는 User.xslx 에 URL 추가
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

        // 해당 폼에서 종료시 해당 프로세스 강제 종료
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
            Close();
        }
    }
    }

    
