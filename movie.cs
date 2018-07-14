using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;

namespace Prime_Movie_Project
{
    public enum httpverb
    {
        GET,
        POST,
        DELETE,

    }
    class movie
    {
        public string endPoint { get; set; }
        public httpverb httpMethod { get; set; }


        public movie()
        {
            endPoint = string.Empty;
            httpMethod = httpverb.GET;
        }
        public string MakeRequest()
        {
            string strresponsevalue = string.Empty;
             HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

                request.Method = httpMethod.ToString();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new ApplicationException("Error" + response.StatusCode.ToString());
                    }

                    //Respone json or XML
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strresponsevalue = reader.ReadToEnd();
                            }
                        }
                    }
                }

                return strresponsevalue;
            }

        }
    }



