namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxGot = new System.Windows.Forms.TextBox();
            this.textBoxUrl2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxUrl3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxJson = new System.Windows.Forms.TextBox();
            this.textBoxUrlFinish = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(76, 15);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(559, 21);
            this.textBoxUrl.TabIndex = 0;
            this.textBoxUrl.Text = "http://10.10.10.8/testphpc/testjson.php?a=a&b=b&c=[1,2,3]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "直接请求";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxGot
            // 
            this.textBoxGot.Location = new System.Drawing.Point(76, 328);
            this.textBoxGot.Multiline = true;
            this.textBoxGot.Name = "textBoxGot";
            this.textBoxGot.Size = new System.Drawing.Size(640, 169);
            this.textBoxGot.TabIndex = 2;
            // 
            // textBoxUrl2
            // 
            this.textBoxUrl2.Location = new System.Drawing.Point(76, 60);
            this.textBoxUrl2.Name = "textBoxUrl2";
            this.textBoxUrl2.Size = new System.Drawing.Size(559, 21);
            this.textBoxUrl2.TabIndex = 3;
            this.textBoxUrl2.Text = "http://10.10.10.8/testphpc/testjson.php?a=a&b=b&c=[1,2,3]";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(641, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "压缩请求";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(641, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "压缩请求，最后一个参数从json拼成";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxUrl3
            // 
            this.textBoxUrl3.Location = new System.Drawing.Point(76, 111);
            this.textBoxUrl3.Name = "textBoxUrl3";
            this.textBoxUrl3.Size = new System.Drawing.Size(559, 21);
            this.textBoxUrl3.TabIndex = 6;
            this.textBoxUrl3.Text = "http://10.10.10.8/testphpc/testjson.php?a=a&b=b&c=";
            this.textBoxUrl3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(641, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(270, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "压缩请求，最后一个参数从json拼成并且做GZIP";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxJson
            // 
            this.textBoxJson.Location = new System.Drawing.Point(76, 142);
            this.textBoxJson.Multiline = true;
            this.textBoxJson.Name = "textBoxJson";
            this.textBoxJson.Size = new System.Drawing.Size(559, 73);
            this.textBoxJson.TabIndex = 8;
            this.textBoxJson.Text = "{\"a\":444,\"b\",[2,3,4]}";
            // 
            // textBoxUrlFinish
            // 
            this.textBoxUrlFinish.Location = new System.Drawing.Point(76, 230);
            this.textBoxUrlFinish.Multiline = true;
            this.textBoxUrlFinish.Name = "textBoxUrlFinish";
            this.textBoxUrlFinish.ReadOnly = true;
            this.textBoxUrlFinish.Size = new System.Drawing.Size(559, 73);
            this.textBoxUrlFinish.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 509);
            this.Controls.Add(this.textBoxUrlFinish);
            this.Controls.Add(this.textBoxJson);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxUrl3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxUrl2);
            this.Controls.Add(this.textBoxGot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxGot;
        private System.Windows.Forms.TextBox textBoxUrl2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxUrl3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxJson;
        private System.Windows.Forms.TextBox textBoxUrlFinish;
    }
}

