using RestSharp;

namespace YapıKredi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HelloWorld helloWorld = new HelloWorld();
            helloWorld.ToString();
            
            
        }
        class HelloWorld
        {
            static async Task Main(string[] args)
            {
                var options = new RestClientOptions("https://api.yapikredi.com.tr")
                {
                    MaxTimeout = -1,
                    FollowRedirects = false,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/investmentrates/v1/currencyRates", Method.Get);
                request.AddHeader("Authorization", "Bearer 1cd9f826-4e77-416a-9237-1b65b905f4d2");
                RestResponse response = await client.ExecuteAsync(request);
                
            }
        }
    }
}