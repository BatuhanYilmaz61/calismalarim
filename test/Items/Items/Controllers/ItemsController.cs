using DocumentFormat.OpenXml.Office.CustomUI;
using Items.Items;
using Items.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json.Serialization;
using Item = Items.Items.Item;

namespace Items.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        public readonly IConfiguration _configuration;
        public ItemsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        [Route("GetAllItem")]
       
        public string GetItems()
        {

            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("ItemsAppCon").ToString());
            SqlDataAdapter da = new SqlDataAdapter("select * from Items", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Item> ıtemsList = new List<Item>();
            Response response = new Response();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Item item = new Item();
                    item.ID = Convert.ToInt16(dt.Rows[i]["ID"]);
                    item.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    item.Category = Convert.ToString(dt.Rows[i]["Category"]);
                    item.Price = Convert.ToInt16(dt.Rows[i]["Price"]);
                    ıtemsList.Add(item);
                }
            }
            if (ıtemsList.Count > 0)
            {
                return JsonConvert.SerializeObject(ıtemsList);

            }
            else
            {
                response.StatusCode = 100;
                response.ErrorMesage = "No data found";
                return JsonConvert.SerializeObject(response);

            }



        }

    }

}
