using System;
using System.Net;
using RestSharp;
using Newtonsoft.Json;

namespace VIT
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://vitacademics-rel.herokuapp.com/api/v2/vellore");

            var loginRequest = new RestRequest("/login",Method.POST);
            loginRequest.AddParameter("regno", "14BIT0137");
            loginRequest.AddParameter("dob", "17021997");
            loginRequest.AddParameter("mobile", args[0] );
            var loginResult = client.Execute(loginRequest).StatusCode;

            if (HttpStatusCode.OK == loginResult)
            {
                var dataRequest = new RestRequest("/refresh",Method.POST);
                dataRequest.AddParameter("regno", "14BIT0137");
                dataRequest.AddParameter("dob", "17021997");
                dataRequest.AddParameter("mobile", "9999500285");

                var dataResult = client.Execute(dataRequest).Content;

                dynamic data = JsonConvert.DeserializeObject(dataResult);
                Console.WriteLine(data.courses[0]);
            }
            else
            {
                Console.WriteLine("Couldn't Log in");
            }
        }
    }
}

