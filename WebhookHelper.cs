using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace IntelligentKioskSample
{
    class WebhookHelper
    {
        private static HttpClient httpClient = new HttpClient();

        public async static void CallWebhookEndpoint(Object payload)
        {
            Uri endpoint = new Uri(SettingsHelper.Instance.WebhookEndpointURI);
            StringContent content = new StringContent("{\"results\":" + JsonConvert.SerializeObject(payload) + "}", System.Text.Encoding.UTF8, "application/json");
            String request = await content.ReadAsStringAsync();
            var response = await httpClient.PostAsync(endpoint, content);

            string responseData = await response.Content.ReadAsStringAsync();
            if (((int)response.StatusCode) == 200)
            {
                System.Diagnostics.Debug.WriteLine("[SUCCESS] HTTP 200 OK");
                System.Diagnostics.Debug.WriteLine("[VERBOST] RESPONSE:" + responseData);
            } else
            {
                System.Diagnostics.Debug.WriteLine(string.Format("[ERROR] HTTP {0}", response.StatusCode));
            }
            System.Diagnostics.Debug.WriteLine(request);

        }
    }
}
