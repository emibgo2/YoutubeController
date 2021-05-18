
namespace WinFormsApp1
{
    partial class Controller
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.ImageDownload = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.viewCount = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.videoLength = new System.Windows.Forms.Label();
            this.likeCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dislikeCount = new System.Windows.Forms.Label();
            this.commentCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timeLableMinute = new System.Windows.Forms.Label();
            this.timeLableSeconds = new System.Windows.Forms.Label();
            this.timeUrlSource = new System.Windows.Forms.TextBox();
            this.channelTitle = new System.Windows.Forms.LinkLabel();
            this.videoDownloadUrl = new System.Windows.Forms.Button();
            this.godog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(148, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(823, 436);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 510);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "URL Serching";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 475);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 27);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 479);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(139, 128);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(8, 11);
            this.vScrollBar1.TabIndex = 5;
            // 
            // webView21
            // 
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(148, 596);
            this.webView21.Margin = new System.Windows.Forms.Padding(4);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(823, 383);
            this.webView21.Source = new System.Uri("https://www.youtube.com/embed/dBR7Q-thmd8", System.UriKind.Absolute);
            this.webView21.TabIndex = 6;
            this.webView21.ZoomFactor = 1D;
            // 
            // ImageDownload
            // 
            this.ImageDownload.Location = new System.Drawing.Point(475, 510);
            this.ImageDownload.Margin = new System.Windows.Forms.Padding(4);
            this.ImageDownload.Name = "ImageDownload";
            this.ImageDownload.Size = new System.Drawing.Size(145, 34);
            this.ImageDownload.TabIndex = 7;
            this.ImageDownload.Text = "섬네임 다운로드";
            this.ImageDownload.UseVisualStyleBackColor = true;
            this.ImageDownload.Click += new System.EventHandler(this.button2_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.descriptionBox.Location = new System.Drawing.Point(1194, 326);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionBox.MaxLength = 32766;
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionBox.Size = new System.Drawing.Size(513, 159);
            this.descriptionBox.TabIndex = 8;
            this.descriptionBox.Text = "\r\n";
            // 
            // viewCount
            // 
            this.viewCount.AllowDrop = true;
            this.viewCount.AutoSize = true;
            this.viewCount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewCount.Location = new System.Drawing.Point(1194, 140);
            this.viewCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewCount.Name = "viewCount";
            this.viewCount.Size = new System.Drawing.Size(0, 21);
            this.viewCount.TabIndex = 9;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(1194, 49);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(0, 21);
            this.title.TabIndex = 10;
            // 
            // videoLength
            // 
            this.videoLength.AutoSize = true;
            this.videoLength.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.videoLength.Location = new System.Drawing.Point(1607, 537);
            this.videoLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.videoLength.Name = "videoLength";
            this.videoLength.Size = new System.Drawing.Size(110, 21);
            this.videoLength.TabIndex = 12;
            this.videoLength.Text = "Video Length";
            // 
            // likeCount
            // 
            this.likeCount.AutoSize = true;
            this.likeCount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.likeCount.Location = new System.Drawing.Point(1194, 184);
            this.likeCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.likeCount.Name = "likeCount";
            this.likeCount.Size = new System.Drawing.Size(0, 21);
            this.likeCount.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1062, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "영상 제목:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1062, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "채널명:";
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1062, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "조회수:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1062, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "좋아요 수:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1062, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "싫어요 수:";
            // 
            // dislikeCount
            // 
            this.dislikeCount.AutoSize = true;
            this.dislikeCount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dislikeCount.Location = new System.Drawing.Point(1194, 227);
            this.dislikeCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dislikeCount.Name = "dislikeCount";
            this.dislikeCount.Size = new System.Drawing.Size(0, 21);
            this.dislikeCount.TabIndex = 19;
            // 
            // commentCount
            // 
            this.commentCount.AutoSize = true;
            this.commentCount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commentCount.Location = new System.Drawing.Point(1194, 271);
            this.commentCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commentCount.Name = "commentCount";
            this.commentCount.Size = new System.Drawing.Size(0, 21);
            this.commentCount.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1062, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "댓글 수:";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Cursor = System.Windows.Forms.Cursors.Default;
            this.description.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.Location = new System.Drawing.Point(1204, 312);
            this.description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(143, 21);
            this.description.TabIndex = 22;
            this.description.Text = "Video Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1062, 315);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "동영상 설명 :";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(1194, 562);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(525, 45);
            this.trackBar1.TabIndex = 25;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timeLableMinute
            // 
            this.timeLableMinute.AutoSize = true;
            this.timeLableMinute.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLableMinute.Location = new System.Drawing.Point(1530, 539);
            this.timeLableMinute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLableMinute.Name = "timeLableMinute";
            this.timeLableMinute.Size = new System.Drawing.Size(24, 20);
            this.timeLableMinute.TabIndex = 26;
            this.timeLableMinute.Text = "분";
            // 
            // timeLableSeconds
            // 
            this.timeLableSeconds.AutoSize = true;
            this.timeLableSeconds.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLableSeconds.Location = new System.Drawing.Point(1562, 539);
            this.timeLableSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLableSeconds.Name = "timeLableSeconds";
            this.timeLableSeconds.Size = new System.Drawing.Size(24, 20);
            this.timeLableSeconds.TabIndex = 27;
            this.timeLableSeconds.Text = "초";
            // 
            // timeUrlSource
            // 
            this.timeUrlSource.Location = new System.Drawing.Point(1204, 596);
            this.timeUrlSource.Name = "timeUrlSource";
            this.timeUrlSource.ReadOnly = true;
            this.timeUrlSource.Size = new System.Drawing.Size(513, 27);
            this.timeUrlSource.TabIndex = 28;
            // 
            // channelTitle
            // 
            this.channelTitle.AutoSize = true;
            this.channelTitle.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.channelTitle.LinkColor = System.Drawing.Color.MediumBlue;
            this.channelTitle.Location = new System.Drawing.Point(1194, 93);
            this.channelTitle.Name = "channelTitle";
            this.channelTitle.Size = new System.Drawing.Size(0, 20);
            this.channelTitle.TabIndex = 29;
            this.channelTitle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // videoDownloadUrl
            // 
            this.videoDownloadUrl.Location = new System.Drawing.Point(634, 510);
            this.videoDownloadUrl.Name = "videoDownloadUrl";
            this.videoDownloadUrl.Size = new System.Drawing.Size(140, 34);
            this.videoDownloadUrl.TabIndex = 30;
            this.videoDownloadUrl.Text = "비디오 다운로드";
            this.videoDownloadUrl.UseVisualStyleBackColor = true;
            this.videoDownloadUrl.Click += new System.EventHandler(this.videoDownloadUrl_Click);
            // 
            // godog
            // 
            this.godog.AutoSize = true;
            this.godog.Location = new System.Drawing.Point(1073, 738);
            this.godog.Name = "godog";
            this.godog.Size = new System.Drawing.Size(50, 20);
            this.godog.TabIndex = 31;
            this.godog.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1849, 1061);
            this.Controls.Add(this.godog);
            this.Controls.Add(this.videoDownloadUrl);
            this.Controls.Add(this.channelTitle);
            this.Controls.Add(this.timeUrlSource);
            this.Controls.Add(this.timeLableSeconds);
            this.Controls.Add(this.timeLableMinute);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.commentCount);
            this.Controls.Add(this.dislikeCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.likeCount);
            this.Controls.Add(this.videoLength);
            this.Controls.Add(this.title);
            this.Controls.Add(this.viewCount);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.ImageDownload);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1000, 1038);
            this.Name = "Form1";
            this.Text = "Youtube Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button ImageDownload;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label viewCount;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label videoLength;
        private System.Windows.Forms.Label likeCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dislikeCount;
        private System.Windows.Forms.Label commentCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label timeLableMinute;
        private System.Windows.Forms.Label timeLableSeconds;
        private System.Windows.Forms.TextBox timeUrlSource;
        private System.Windows.Forms.LinkLabel channelTitle;
        private System.Windows.Forms.Button videoDownloadUrl;
        private System.Windows.Forms.Label godog;
    }
}

