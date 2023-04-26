using Amazon.Runtime.Internal;
using Malzeme.Models;
using MongoDB.Bson;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;
using ThirdParty.Json.LitJson;
using System.Text.Json;
using System.Text.Json.Serialization;
using SendGrid.Helpers.Errors.Model;
using ServiceStack;


namespace Malzeme.Helpers
{
    internal class RestHelper
    {
        public static string ClientID = "RNET";
        public static string clientSecret = "KRrADkKA23Vb8d4NGNQuw5DSqVQeUM9dd7LsJgL0HMA=";
        public string accessToken = "";
        public int updateItem(string url, string userName, string password, string firmNr, string accessToken, LogoMalzemeKarti genericItem)
        {
            try
            {
                var client = new RestClient($"{url}/api/v1/items/{genericItem.LOGOREF}");
                client.Timeout = -1;

                var request = new RestRequest(Method.PUT);
                request.AddHeader("Authorization", $"Bearer {accessToken}");
                request.AddHeader("Content-Type", "application/json");

                var json = JsonConvert.SerializeObject(genericItem);
                request.AddParameter("application/json", json, ParameterType.RequestBody);
                request.Timeout = -1;

                var response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    dynamic data = JObject.Parse(response.Content);
                    var logicalref = data.INTERNAL_REFERENCE;
                    MessageBox.Show("güncellendi");
                    return logicalref;
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {

                    string veriler = response.Content.EncodeJson();
                    List<string> VeriListe = new List<string>(veriler.Split(','));
                        foreach(string veri in VeriListe)
                        {
                        veriler = veri.Trim();
                        MessageBox.Show(veriler);
                        }
                    

                }

                if (!string.IsNullOrEmpty(response.Content))
                {
                    dynamic data = JObject.Parse(response.Content);
                    var logicalref = data.LOGICALREF;

                    return logicalref;
                }
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int createItem(string url, string userName, string password, string firmNr, string accessToken, LogoMalzemeKarti genericItem)
        {
            try
            {
                var client = new RestClient($"{url}/api/v1/items");
                client.Timeout = -1;

                var request = new RestRequest(Method.POST);

                var json = JsonConvert.SerializeObject(genericItem);

                request.AddHeader("Authorization", $"Bearer {accessToken}");
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);
                request.Timeout = -1;

                var response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var content = response.Content.Replace(":1.0", ":1");

                    dynamic data = JObject.Parse(response.Content);
                    var logicalref = data.INTERNAL_REFERENCE;

                    return logicalref;
                }
                else
                {
                    if (response == null)
                    {
                        return 0;
                    }

                    if (!string.IsNullOrEmpty(response.Content))
                    {
                        dynamic data = JObject.Parse(response.Content);
                        var logicalref = data.LOGICALREF;

                        return logicalref;
                    }
                }

                return 0;
            }
            catch (Exception ex)
            {
                ;
                return 0;
            }
        }

        public string getAccessToken(string url, string userName, string password, string firmNr)
        {
            try
            {
                var client = new RestClient($"{url}");
                var request = new RestRequest("api/v1/token", Method.POST);
                //request.AddHeader("Authorization", "Basic WWF6aWxpbTpSRVNU=");
                request.AddHeader("Authorization", "Basic TG9nb1lhemlsaW1PY2VhbjppamJLVlhEb3BpZlBBdFcxL1VmN3VOTHE3RXFlQi94aVhWbmdJODZ4cDhsUWFFUVFsbkNvckpWeHI4OGJKaUorVEI2WXNkay8zaksvalhxV1YxWUp2UT09");
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", $"grant_type=password&username={userName}&firmno={firmNr}&password={password}", ParameterType.RequestBody);
                var response = client.Execute(request);

                if (response.StatusCode == 0)
                {
                    return "";
                }

                dynamic data = JObject.Parse(response.Content);
                var token = data.access_token;

                return token;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
