
namespace WinFormsApp1
{
    partial class Form1
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
            this.channelTitle = new System.Windows.Forms.Label();
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(115, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 327);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "URL Serching";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(108, 96);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.vScrollBar1.TabIndex = 5;
            // 
            // webView21
            // 
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(115, 467);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(640, 315);
            this.webView21.Source = new System.Uri("https://www.youtube.com/embed/dBR7Q-thmd8", System.UriKind.Absolute);
            this.webView21.TabIndex = 6;
            this.webView21.ZoomFactor = 1D;
            // 
            // ImageDownload
            // 
            this.ImageDownload.Location = new System.Drawing.Point(881, 494);
            this.ImageDownload.Name = "ImageDownload";
            this.ImageDownload.Size = new System.Drawing.Size(115, 23);
            this.ImageDownload.TabIndex = 7;
            this.ImageDownload.Text = "섬네임 다운로드";
            this.ImageDownload.UseVisualStyleBackColor = true;
            this.ImageDownload.Click += new System.EventHandler(this.button2_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.descriptionBox.Location = new System.Drawing.Point(949, 254);
            this.descriptionBox.MaxLength = 32766;
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionBox.Size = new System.Drawing.Size(385, 120);
            this.descriptionBox.TabIndex = 8;
            this.descriptionBox.Text = "\r\n";
            // 
            // viewCount
            // 
            this.viewCount.AllowDrop = true;
            this.viewCount.AutoSize = true;
            this.viewCount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewCount.Location = new System.Drawing.Point(949, 105);
            this.viewCount.Name = "viewCount";
            this.viewCount.Size = new System.Drawing.Size(95, 21);
            this.viewCount.TabIndex = 9;
            this.viewCount.Text = "View Count";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(949, 37);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(42, 21);
            this.title.TabIndex = 10;
            this.title.Text = "Title";
            // 
            // channelTitle
            // 
            this.channelTitle.AutoSize = true;
            this.channelTitle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.channelTitle.Location = new System.Drawing.Point(949, 69);
            this.channelTitle.Name = "channelTitle";
            this.channelTitle.Size = new System.Drawing.Size(100, 21);
            this.channelTitle.TabIndex = 11;
            this.channelTitle.Text = "ChannelTitle";
            // 
            // videoLength
            // 
            this.videoLength.AutoSize = true;
            this.videoLength.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.videoLength.Location = new System.Drawing.Point(881, 392);
            this.videoLength.Name = "videoLength";
            this.videoLength.Size = new System.Drawing.Size(110, 21);
            this.videoLength.TabIndex = 12;
            this.videoLength.Text = "Video Length";
            // 
            // likeCount
            // 
            this.likeCount.AutoSize = true;
            this.likeCount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.likeCount.Location = new System.Drawing.Point(949, 138);
            this.likeCount.Name = "likeCount";
            this.likeCount.Size = new System.Drawing.Size(89, 21);
            this.likeCount.TabIndex = 13;
            this.likeCount.Text = "Like Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(826, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "영상 제목";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(826, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "채널명";
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(826, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "조회수";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(826, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "좋아요 수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(826, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "싫어요 수";
            // 
            // dislikeCount
            // 
            this.dislikeCount.AutoSize = true;
            this.dislikeCount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dislikeCount.Location = new System.Drawing.Point(949, 170);
            this.dislikeCount.Name = "dislikeCount";
            this.dislikeCount.Size = new System.Drawing.Size(107, 21);
            this.dislikeCount.TabIndex = 19;
            this.dislikeCount.Text = "Dislike Count";
            // 
            // commentCount
            // 
            this.commentCount.AutoSize = true;
            this.commentCount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commentCount.Location = new System.Drawing.Point(949, 203);
            this.commentCount.Name = "commentCount";
            this.commentCount.Size = new System.Drawing.Size(132, 21);
            this.commentCount.TabIndex = 20;
            this.commentCount.Text = "Comment Count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(826, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "댓글 수";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Cursor = System.Windows.Forms.Cursors.Default;
            this.description.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.Location = new System.Drawing.Point(949, 236);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(143, 21);
            this.description.TabIndex = 22;
            this.description.Text = "Video Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(826, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "동영상 설명 :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(881, 431);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(258, 27);
            this.progressBar1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1767, 816);
            this.Controls.Add(this.progressBar1);
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
            this.Controls.Add(this.channelTitle);
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
            this.Name = "Form1";
            this.Text = "url";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
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
        private System.Windows.Forms.Label channelTitle;
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
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

