using RestApiAutomationBL.Requests.Posts;
using RestApiAutomationBL.Response.Posts;
using Newtonsoft.Json;
using RestSharp;
using Training_RestSharpAutomationFramework.RestClientUtils;
using System.Net;

namespace RestApiAutomationBL.Clients.Posts
{
    public class PostUtils
    {
        //Create a new post
        public CreatePostsValidResponse CreatePost(string id, string title, int views)
        {
            CreatePostsValidRequest requestBody = new CreatePostsValidRequest();
            requestBody.id = id;
            requestBody.title = title;
            requestBody.views = views;
           
            var requestString = JsonConvert.SerializeObject(requestBody);

            return RestClientUtilities.Post<CreatePostsValidResponse>("posts", requestString, DataFormat.Json);

        }

        //Delete a post
        public bool DeletePost(string id, HttpStatusCode expectedStatusCode)
        {
            return RestClientUtilities.Delete("posts/" + id, DataFormat.Json, HttpStatusCode.OK);
        }

        //Get a post

        public CreatePostsValidResponse[] GetPost(string id)
        {
            return RestClientUtilities.Get<CreatePostsValidResponse[]>("posts?id=" + id, DataFormat.Json);

        }
    } 
}
