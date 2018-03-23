using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Http;

namespace BannoUI
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    class ClientClass
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public ClientClass()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;

        }

        public string Request()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if(response.StatusCode != HttpStatusCode.OK )
                {
                    throw new ApplicationException("error code:" + response.StatusCode.ToString());
                }
                //Process the response stream

                using (Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                        
                    }
                }
            
            }

                return strResponseValue;


        }
    }
}
