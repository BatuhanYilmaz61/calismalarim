using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.CSharp;
using System.Web;  // Örneğe 04.05.2020 tarihinde eklendi


namespace RestClientSmple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // clientID ve clientSecret değişkenleri Logo Çözüm Ortaklarına, uyarlama araçları destek ekibi tarafından sağlanmaktadır.
        // Çözüm ortağı iseniz bu bilgileri WDev.Support@logo.com.tr mail adresinden talep edebilirsiniz.  

        // Aşağıdaki clientID ve clientSecret bilgileri bu örneği hazırlamak için kullanılmış ve akabinde geçerliliğini yitirmiştir.
        public static string clientId = "RNET";
        public static string clientSecret = "KRrADkKA23Vb8d4NGNQuw5DSqVQeUM9dd7LsJgL0HMA=";
        public string accessToken = "";
        public string getAccessToken(string url, string userName, string password, string firmNr)
        {
            try
            {
                HttpWebRequest req = WebRequest.Create(new Uri(url)) as HttpWebRequest;
                req.Method = "POST";
                req.ContentType = "application/json";
                req.Accept = "application/json";
                req.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(clientId + ":" + clientSecret)));
                byte[] formData = UTF8Encoding.UTF8.GetBytes("grant_type=password"
                    + "&username=" + HttpUtility.UrlEncode(userName)   // bu satır 04.05.2020 tarihinde değiştirildi
                    + "&firmno=" + firmNr
                    + "&password=" + HttpUtility.UrlEncode(password)); // bu satır 04.05.2020 tarihinde değiştirildi
                req.ContentLength = formData.Length;
                using (Stream post = req.GetRequestStream())
                {
                    post.Write(formData, 0, formData.Length);
                }
                string result = null;
                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }
                dynamic j = JsonConvert.DeserializeObject(result);
                accessToken = j.access_token;
            }
            catch (Exception) { }

            return accessToken;
        }

        public static string HttpPost(string url, string param, string accessToken)
        {
            string result = null;

            try
            {
                HttpWebRequest req = WebRequest.Create(new Uri(url)) as HttpWebRequest;
                req.Method = "POST";
                req.ContentType = "application/json";
                req.Accept = "application/json";
                req.Headers.Add("Authorization", "Bearer  " + accessToken);

                byte[] formData = UTF8Encoding.UTF8.GetBytes(param.ToString());
                req.ContentLength = formData.Length;

                using (Stream post = req.GetRequestStream())
                {
                    post.Write(formData, 0, formData.Length);
                }

                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }
            }
            catch (WebException webEx)
            {
                var response = ((HttpWebResponse)webEx.Response);
                StreamReader content = new StreamReader(response.GetResponseStream());
                result = content.ReadToEnd();
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }
            return result;
        }

        public static string HttpPut(string url, string param, string accessToken)
        {
            string result = null;

            try
            {
                HttpWebRequest req = WebRequest.Create(new Uri(url)) as HttpWebRequest;
                req.Method = "PUT";
                req.ContentType = "application/json";
                req.Accept = "application/json";
                req.Headers.Add("Authorization", "Bearer  " + accessToken);

                byte[] formData = UTF8Encoding.UTF8.GetBytes(param.ToString());
                req.ContentLength = formData.Length;

                using (Stream post = req.GetRequestStream())
                {
                    post.Write(formData, 0, formData.Length);
                }

                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }


            }
            catch (WebException webEx)
            {
                var response = ((HttpWebResponse)webEx.Response);
                StreamReader content = new StreamReader(response.GetResponseStream());
                result = content.ReadToEnd();
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }
            return result;
        }

        public static string HttpPatch(string url, string param, string accessToken)
        {
            string result = null;

            try
            {
                HttpWebRequest req = WebRequest.Create(new Uri(url)) as HttpWebRequest;
                req.Method = "PATCH";
                req.ContentType = "application/json";
                req.Accept = "application/json";
                req.Headers.Add("Authorization", "Bearer  " + accessToken);

                byte[] formData = UTF8Encoding.UTF8.GetBytes(param.ToString());
                req.ContentLength = formData.Length;

                using (Stream post = req.GetRequestStream())
                {
                    post.Write(formData, 0, formData.Length);
                }

                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }


            }
            catch (WebException webEx)
            {
                var response = ((HttpWebResponse)webEx.Response);
                StreamReader content = new StreamReader(response.GetResponseStream());
                result = content.ReadToEnd();
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }
            return result;
        }

        public static string HttpGet(string url, string accessToken)
        {
            string result = null;
            try
            {
                HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
                req.Method = "GET";
                req.Accept = "application/json, application/octet-stream";
                req.Headers.Add("Authorization", "Bearer  " + accessToken);

                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }
            }
            catch (WebException webEx)
            {
                var response = ((HttpWebResponse)webEx.Response);
                StreamReader content = new StreamReader(response.GetResponseStream());
                result = content.ReadToEnd();
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetAccsesToken_Click(object sender, EventArgs e)
        {
            accessToken = getAccessToken("http://localhost:8080/api/v1/token", "LOGO", "", "1");
            MessageBox.Show(accessToken);
        }
    }


}