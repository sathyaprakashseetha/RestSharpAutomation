using RestApiAutomationBL.Requests.Posts;
using RestApiAutomationBL.Response.Posts;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Training_RestSharpAutomationFramework.RestClientUtils;
using System.Net;

namespace RestApiAutomationBL.Clients.Posts
{
    public class PostUtils
    {
        //Create a new post
        public CreatePostsValidResponse CreatePost(int id, string title, string author)
        {
            CreatePostsValidRequest requestBody = new CreatePostsValidRequest();
            requestBody.id = id;
            requestBody.title = title;
            requestBody.author = author;
           
            var requestString = JsonConvert.SerializeObject(requestBody);

            return RestClientUtilities.Post<CreatePostsValidResponse>("posts", requestString, DataFormat.Json);

        }

        //Delete a post
        public bool DeletePost(int id, HttpStatusCode expectedStatusCode)
        {
            return RestClientUtilities.Delete("posts/" + id.ToString(), DataFormat.Json, HttpStatusCode.OK );
        }

        //Get a post

        public CreatePostsValidResponse[] GetPost(int id)
        {
            return RestClientUtilities.Get<CreatePostsValidResponse[]>("posts?id=" + id.ToString(), DataFormat.Json);

        }
    } 
}
