using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWebServices
{
    public partial class Form1 : Form
    {
        private static string host = "localhost:4312/";
        static string host2 = "192.168.140.133/SampleBll";


        private string adduri = "http://"+ host2 + "/add.asmx/add";
        private string loginuri = "http://" + host2 + "/login.asmx/LoginCheck";
        private string testuri = "http://" + host2 + "/add.asmx/test";


        public Form1()
        {
            InitializeComponent();
        }


        private void Login_Click(object sender, EventArgs e)
        {
            string number1 = this.textBox1.Text;
            string number2 = this.textBox2.Text;
            string data = "uid=" + number1 + "&password=" + number2;

            string res = post(loginuri, data);
            this.tb_sessionid.Text = res;
        }


        private void add_Click(object sender, EventArgs e)
        {
            string number1 = this.textBox3.Text;
            string number2 = this.textBox4.Text;
            string data = "number1=" + number1 + "&number2=" + number2;

            string res = post(adduri, data);
            tb_addmessage.Text = res;
        }

        //发送消息到服务器
        public string post(string ServerPage, string postData)
        {
            WebRequest request7 = WebRequest.Create(ServerPage);
            request7.Method = "POST";

            //设置sessionid
            if (tb_idname.Text != "" && tb_idvalue.Text != "")
            {
                string value = "ASP.NET_SessionId=" + tb_idvalue.Text;
                request7.Headers.Set("Cookie",value );
            }

            //post传参数  
            byte[] bytes = Encoding.ASCII.GetBytes(postData);
            request7.ContentType = "application/x-www-form-urlencoded";
            request7.ContentLength = postData.Length;
            Stream sendStream = request7.GetRequestStream();
           sendStream.Write(bytes, 0, bytes.Length);
           sendStream.Close();



            //得到返回值  
            try
            {
                WebResponse response7 = request7.GetResponse();
                string OrderQuantity = new StreamReader(response7.GetResponseStream(), Encoding.GetEncoding("utf-8")).ReadToEnd();
                return OrderQuantity;
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}