using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleSite
{
    public partial class test : System.Web.UI.Page
    {
        private static System.Net.CookieContainer cookieContainer= new System.Net.CookieContainer();
        SampleWebservices.Add add = new SampleWebservices.Add();
        SampleWebservices1.Login login = new SampleWebservices1.Login();

        protected void Page_Load(object sender, EventArgs e)
        {
            add.CookieContainer = cookieContainer;
            login.CookieContainer = cookieContainer;
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //login
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                login.LoginCheck(this.TextBox3.Text, this.TextBox4.Text);
                
            }
            catch (Exception ex)
            {
                this.Label1.Text = ex.ToString();
            }
        }

        //add
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = add.add(int.Parse(this.TextBox1.Text), int.Parse(this.TextBox1.Text));
                this.Label1.Text = a.ToString();
            }
            catch(Exception ex)
            {
                this.Label1.Text = ex.ToString();
            }
        }
    }
}