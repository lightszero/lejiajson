using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class mywc : System.Net.WebClient
        {
            protected override System.Net.WebRequest GetWebRequest(Uri address)
            {
                var req = base.GetWebRequest(address);
                req.Timeout = 3000;
                return req;
            }
        }
        System.Net.WebClient wc = new mywc();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string result = wc.DownloadString(textBoxUrl.Text);
                StringBuilder sb = new StringBuilder();
                MyJson.Parse(result).ConvertToStringWithFormat(sb, 0);
                textBoxGot.Text = sb.ToString();
            }
            catch (Exception err)
            {
                textBoxGot.Text = err.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string url = textBoxUrl2.Text;
                textBoxUrlFinish.Text = "http://10.10.10.8/testphpc/convert.php?url=" + Uri.EscapeDataString(url);
                byte[] data = wc.DownloadData(textBoxUrlFinish.Text);
                var result = MyJsonBinary.Read(new System.IO.MemoryStream(data));
                StringBuilder sb = new StringBuilder();
                result.ConvertToStringWithFormat(sb, 0);
                textBoxGot.Text = sb.ToString();
            }
            catch (Exception err)
            {
                textBoxGot.Text = err.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string url = textBoxUrl3.Text;
             
                var json  =MyJson.Parse(textBoxJson.Text);
                System.IO.MemoryStream ms =new System.IO.MemoryStream();
                MyJsonBinary.Write(ms,json);
                byte[] datajson =ms.ToArray();
                textBoxUrlFinish.Text = "http://10.10.10.8/testphpc/convert.php?url=" + Uri.EscapeDataString(url);
                if(datajson.Length>1)
                {
                     textBoxUrlFinish.Text +="&json="+ Uri.EscapeDataString(Convert.ToBase64String(datajson));
                }
                this.Text = "urllen=" + textBoxUrlFinish.Text.Length;

                byte[] data = wc.DownloadData(textBoxUrlFinish.Text);
                var result = MyJsonBinary.Read(new System.IO.MemoryStream(data));
                StringBuilder sb = new StringBuilder();
                result.ConvertToStringWithFormat(sb, 0);
                textBoxGot.Text = sb.ToString();
            }
            catch (Exception err)
            {
                textBoxGot.Text = err.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string url = textBoxUrl3.Text;

                var json = MyJson.Parse(textBoxJson.Text);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                MyJsonBinary.Write(ms, json);
                byte[] datajson = ms.ToArray();
                textBoxUrlFinish.Text = "http://10.10.10.8/testphpc/convert.php?url=" + Uri.EscapeDataString(url);
                if (datajson.Length > 1)
                {
                    System.IO.MemoryStream msout =new System.IO.MemoryStream();
                    System.IO.Compression.GZipStream gs = new System.IO.Compression.GZipStream(msout, System.IO.Compression.CompressionMode.Compress);
                    gs.Write(datajson, 0, datajson.Length);
                    gs.Close();
                    byte[] datacomp = msout.ToArray();

                    textBoxUrlFinish.Text += "&json=" + Uri.EscapeDataString(Convert.ToBase64String(datacomp));
                }
                this.Text = "urllen="+textBoxUrlFinish.Text.Length;

                byte[] data = wc.DownloadData(textBoxUrlFinish.Text);
                var result = MyJsonBinary.Read(new System.IO.MemoryStream(data));
                StringBuilder sb = new StringBuilder();
                result.ConvertToStringWithFormat(sb, 0);
                textBoxGot.Text = sb.ToString();
            }
            catch (Exception err)
            {
                textBoxGot.Text = err.ToString();
            }
        }
    }
}
