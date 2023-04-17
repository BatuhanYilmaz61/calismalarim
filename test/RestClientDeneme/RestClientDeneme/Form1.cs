using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;
using Microsoft.CSharp;
using Newtonsoft.Json;
using RestSharp;
using Microsoft.AspNetCore.Mvc;

namespace RestClientDeneme
{
   
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string ClientID = "RNET";
        public static string clientSecret = "KRrADkKA23Vb8d4NGNQuw5DSqVQeUM9dd7LsJgL0HMA=";
        public string get_AccsesToken(string url, string UserName, string Password, string FirmaNo)
        {
            //HttpWebRequest req = WebRequest.Create(new Uri(url)) as HttpWebRequest;
            //req.Method = "POST";
            //req.ContentType = "application/json";
            //req.Accept = "application/json";
            //req.Headers.Add("Authorization", "Basic" + Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ClientID+":"+clientSecret)));
            //byte[] formData = UTF8Encoding.UTF8.GetBytes("grant_type=password" +
            //    "&UserName" + UserName
            //    + "&FirmaNo" + FirmaNo
            //    + "&Password" + Password);
            //req.ContentLength = formData.Length;



            //using (Stream post = req.GetRequestStream())
            //{
            //    post.Write(formData, 0, formData.Length);
            //}
            //string res = null;
            //using (HttpWebResponse resp=req.GetResponse() as HttpWebResponse)
            //{
            //    StreamReader reader = new StreamReader(resp.GetResponseStream());


            //    res = reader.ReadToEnd();
            //}
            var options = new RestClientOptions(url) { MaxTimeout = -1, };
            var client = new RestClient(options);
            var request = new RestRequest("/api/v1/token", Method.Post);
            request.AddHeader("Authorization", "Basic" + Convert.ToBase64String(Encoding.UTF8.GetBytes(ClientID + ":" + clientSecret)));
            request.AddHeader("Content-Type", "application/json");
            var body = $@"grant_type=password&username={UserName}&password={Password}&firmno={FirmaNo}";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);

            dynamic j = JsonConvert.DeserializeObject(response.Content);
            string accsessToken = j.access_token;
            return accsessToken;
        }
        [HttpPost]
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

        [HttpPut]
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
        [HttpPatch]

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
        [HttpGet("{id}")]
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
        private void getaccsesToken_Click(object sender, EventArgs e)
        {
            textBox1.Text = get_AccsesToken("http://localhost:32001", "REST", "REST", "120");



        }
    }
}

    

