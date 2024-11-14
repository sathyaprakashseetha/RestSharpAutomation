using NUnit.Framework;
using RestApiAutomationBL.Clients.Posts;
using RestApiAutomationBL.Response.Posts;
using System.Net;
using System.Net.Http;
using TechTalk.SpecFlow;

namespace RestApiAutomationTest.StepDefinitions
{
    [Binding]
    public class PostsStepDefinitions
    {
        private CreatePostsValidResponse response;
        private CreatePostsValidResponse[] responseGET;
        private HttpResponseMessage responsePOST;
        PostUtils postUtils = new PostUtils();

        [Given(@"user creates a new post using id '([^']*)' title '([^']*)' and author '([^']*)'")]
        public void GivenUserCreatesANewPostUsingIdTitleAndAuthor(string id, string title, int views)
        {  
            response = postUtils.CreatePost(id, title, views);          
        }

        [Then(@"a post is created with id '([^']*)' title '([^']*)' and author '([^']*)'")]
        public void ThenAPostIsCreatedWithIdTitleTitleAndAuthorAuthor(string id, string title, int views)
        {
            Assert.AreEqual(response.id, id);
            Assert.AreEqual(response.title, title);
            Assert.AreEqual(response.views, views);
        }

        [Given(@"user retrives a post using id '([^']*)'")]
        public void GivenUserRetrivesAPostUsingIdTitleAndAuthor(string id)
        {     
            responseGET = postUtils.GetPost(id);
        }

        [Then(@"verify the response for id '([^']*)' title '([^']*)' and author '([^']*)'")]
        public void ThenVerifyTheResponseForIdTitleAndAuthor(string id, string title, int views)
        {
            Assert.AreEqual(responseGET[0].id, id);
            Assert.AreEqual(responseGET[0].title, title);
            Assert.AreEqual(responseGET[0].views, views);
        }

        [Given(@"user creates a new post using id '([^']*)' and title '([^']*)'")]
        public void GivenUserCreatesANewPostUsingIdAndTitle(string id, string title)
        {
            responsePOST = postUtils.CreatePost(id,title);
        }
        [Then(@"verify the response")]
        public void ThenVerifyTheResponse()
        {
            Assert.AreEqual(HttpStatusCode.OK,responsePOST.StatusCode);
        }

    }
}
