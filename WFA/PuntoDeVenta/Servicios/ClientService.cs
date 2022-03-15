using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ClientService
    {
        public static ClientService _instance = null;

        // In the class
        public HttpClient client;
        private ClientService()
        {
            client = new HttpClient();
            // Put the following code where you want to initialize the class
            // It can be the static constructor or a one-time initializer
            client.BaseAddress = new Uri("http://localhost:8000/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", "Bearer 1|hV92UU1m5GycjXBmgrnl7WMxnkTnqeFzb5h7QydJ");
        }

        public static ClientService Instance
        {
            get
            {
                // The first call will create the one and only instance.
                if (_instance == null)
                {
                    _instance = new ClientService();
                }

                // Every call afterwards will return the single instance created above.
                return _instance;
            }
        }

    }
}
