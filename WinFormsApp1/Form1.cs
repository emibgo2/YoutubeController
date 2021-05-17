using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace WinFormsApp1
{

    public partial class Form1 : Form

    {
        private string Id;
        private string _url;
        private string stitle;
        YouTubeService youtube;


        public Form1()
        {
            InitializeComponent();
            youtube = new YouTubeService(new BaseClientService.Initializer//유튜브 연결 알트 + 엔터 
            //도구상자 컨트롤 + 알트 + X 
            {
                ApiKey = "AIzaSyCqGvTKo2S5K7LWcRT0apfi14dQtGxME6s",//절대 아무도 보여주시면 안됩니다.
            });//유튜브 연결



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
        async void YoutubeAPi()
        {
            SearchResource.ListRequest adress = youtube.Search.List("snippet");//Search snippet 연결
            adress.Q = textBox1.Text;//해당 단어 주소 검색
            adress.MaxResults = 1;//몇개까지 검색 
            SearchListResponse adress_res = await adress.ExecuteAsync();


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
            descriptionBox.Text ="\n\n"+ Convert.ToString(snippet_res.Items[0].Snippet.Description);
            channelTitle.Text = Convert.ToString(snippet_res.Items[0].Snippet.ChannelTitle);


            // title, description, channelId, chnnelTitle, publichedAt
            VideosResource.ListRequest contentDetials = youtube.Videos.List("contentDetails");//Videos statistics 연결
            contentDetials.Id = $"{this.Id}";
            VideoListResponse fileDetails_res = await contentDetials.ExecuteAsync();
            videoLength.Text = Convert.ToString(fileDetails_res.Items[0].ContentDetails.Duration);

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

             
        }


    }
    }
