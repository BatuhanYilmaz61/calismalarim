using System.Net;
using System.Net.Http;
using System.Text;
using Microsoft.CSharp;
using System.IO;

namespace RestClient

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string clientID = "apiUserKey";
        public static string clientSecret = "KRrADkKA23Vb8d4NGNQuw5DSqVQeUM9dd7LsJgL0HMA=";
        public string get_AccesToken(string url,string userName ,string password , string firmanr)
        {
            HttpWebRequest req = WebRequest.Create(new Uri(url)) as HttpWebRequest;
            req.Method = "POST";
            req.ContentType = "application/json";
            req.Accept = "application/json";
            req.Headers.Add("Authorization", "Basic" + Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(clientID+":"+clientSecret)));
            byte[] FormData = UTF8Encoding.UTF8.GetBytes("grant_type=password" + "&username" + userName + "&firmano" + firmanr + "&password" + password);
            req.ContentLength = FormData.Length;
            using(Stream post = req.GetRequestStream())
            {
                post.Write(FormData, 0, FormData.Length);

            }
            string res = null;
            using (HttpWebRequest resp = req.GetResponse() as HttpWebRequest)
            {
                StreamReader reader = new StreamReader(resp.GetRequestStream());
                res = reader.ReadToEnd();
            }


                return "";
        }
        private void GetAccsesToken_Click(object sender, EventArgs e)
        {

        }
    }
}