using Microsoft.AspNetCore.Mvc;
using System.Formats.Tar;
using System.IO.IsolatedStorage;
using System.Net;
using System.Text.Json;

namespace cloudfleet.Infraestructure.Rest.Implementation
{
    public class CouldFleetV1 : IFleetCloudV1RestService
	{
        //se indica el token del servicio
        static string token = "1mT6Lny.R38_jSB5iTHtmUKD2d6RdOXQZDD8HLzg4";

        //clase que optiene el listado de vehiculos 
        public List<String> GetVehiclesAsync(string url)
        {
            //variable que indica el status de la hoja
            String status = "";

            //variable responseList conde se guardar la lista de los vehiculos por pagina
            List<String> responseList = new List<string>();
            
            // variable i para recorrer las paginas
            int i = 1;

            //ciclo para recorer las paginas
            do
            {
                // variable client2  donde se concatena la ruta de url pagina y token
                HttpWebRequest client2 = (HttpWebRequest)WebRequest.Create(url + "/vehicles?page="+i);
                client2.Method = "GET";
                client2.ContentType = "application/json";
                client2.Accept = "application/json";
                client2.Headers.Add("Authorization", "Bearer " + token);

                try
                {
                    using (HttpWebResponse response = (HttpWebResponse)client2.GetResponse())
                    {
                        status = response.StatusCode.ToString();
                        using (Stream strReader = response.GetResponseStream())
                        {
                            if (strReader == null) return responseList;
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                /* se deserializa*/
                                //string jsonString = JsonSerializer.Deserialize(responseBody);
                                responseList.Add(responseBody);
                                Console.WriteLine(responseBody);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    break;
                }
                i++;
                //Console.WriteLine(status);
            }
            while (status != HttpStatusCode.NotFound.ToString());
            return responseList;
        }

        public List<string> GetVehiclesDocuments(string url)
        {
            String status = "";
            List<String> responseList = new List<string>(); 
            int i = 1;

            do
            {
                HttpWebRequest client2 = (HttpWebRequest)WebRequest.Create(url + "/documents?page=" + i);
                client2.Method = "GET";
                client2.ContentType = "application/json";
                client2.Accept = "application/json";
                client2.Headers.Add("Authorization", "Bearer " + token);
           
            try
            {
                using (WebResponse response = client2.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return responseList;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            responseList.Add(responseBody);
                            Console.WriteLine(responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
            i++;
            } 
            while (status != HttpStatusCode.NotFound.ToString());
            return responseList;
        }

        public List<string> GetVehiclesParts(string url)
        {
            String status = "";
            List<String> responseList = new List<string>();
            int i = 1;

            do
            {
                HttpWebRequest client2 = (HttpWebRequest)WebRequest.Create(url + "/parts?page=" + i);
                client2.Method = "GET";
                client2.ContentType = "application/json";
                client2.Accept = "application/json";
                client2.Headers.Add("Authorization", "Bearer " + token);

                try
                {
                    using (WebResponse response = client2.GetResponse())
                    {
                        using (Stream strReader = response.GetResponseStream())
                        {
                            if (strReader == null) return responseList;
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                responseList.Add(responseBody);
                                Console.WriteLine(responseBody);
                            }
                        }
                    }
                }
                catch (WebException ex)
                {
                    // Handle error
                }
                i++;
            }
            while (status != HttpStatusCode.NotFound.ToString());
            return responseList;
        }

        public List<string> GetVehiclesWorkOrders(string url)
        {
            String status = "";
            List<String> responseList = new List<string>();
            int i = 1;
            DateTime fecha = DateTime.Now;
            DateTime FechaFin = fecha.AddMonths(-3);
                       
            do
            {                
                HttpWebRequest client2 = (HttpWebRequest)WebRequest.Create(url + "/work-orders?page=" + i + "&startDateFrom="+ fecha+ "&startDateTo=" + FechaFin);
                client2.Method = "GET";
                client2.ContentType = "application/json";
                client2.Accept = "application/json";
                client2.Headers.Add("Authorization", "Bearer " + token);

            try
            {
                using (WebResponse response = client2.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return responseList;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            responseList.Add(responseBody);
                            Console.WriteLine(responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
            i++;
                
            }
            while (status != HttpStatusCode.NotFound.ToString());
            Console.WriteLine(fecha.Year + "-" + fecha.Month + "-" + fecha.Day);
            return responseList;

        }
    
    }
}

