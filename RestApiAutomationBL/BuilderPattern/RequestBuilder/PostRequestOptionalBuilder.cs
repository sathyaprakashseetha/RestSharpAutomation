using RestApiAutomationBL.Requests.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiAutomationBL.BuilderPattern.RequestBuilder
{
    public class PostRequestOptionalBuilder 
    {
        CreatePostsValidRequest postRequestModel;
        public PostRequestOptionalBuilder()
        {
            postRequestModel = new CreatePostsValidRequest();
        }

        public PostRequestOptionalBuilder WithIdAndTitle(string id, String title)
        {
            postRequestModel.id = id;
            postRequestModel.title = title;
            //postRequestModel.views = 19;
            return this;
        }

        public PostRequestOptionalBuilder WithIdAndViews(string id, int views)
        {
            postRequestModel.id = id;
            //postRequestModel.title = title;
            postRequestModel.views = views;
            return this;
        }

        public CreatePostsValidRequest Build()
        {
            return postRequestModel;
        }

    }
}
