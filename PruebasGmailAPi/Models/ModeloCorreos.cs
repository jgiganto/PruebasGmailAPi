using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;


namespace PruebasGmailAPi.Models
{
    public class ModeloCorreos
    {

        public List<Thread> ListThreads(GmailService service, String userId)
        {
            List<Thread> result = new List<Thread>();
            UsersResource.ThreadsResource.ListRequest request = service.Users.Threads.List(userId);

            do
            {
                try
                {
                    ListThreadsResponse response = request.Execute();
                    result.AddRange(response.Threads);
                    request.PageToken = response.NextPageToken;
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
            } while (!String.IsNullOrEmpty(request.PageToken));

            return result;
        }
    }
}