using NUnit.Framework;
using RestApiAutomationBL.Clients.Posts;
using RestApiAutomationBL.Response.Posts;
using System;
using TechTalk.SpecFlow;

namespace RestApiAutomationTest.StepDefinitions
{
    [Binding]
    public class PostsStepDefinitions
    {
        private CreatePostsValidResponse response;

        [Given(@"user creates a new post using id '([^']*)' title '([^']*)' and author '([^']*)'")]
        public void GivenUserCreatesANewPostUsingIdTitleAndAuthor(int id, string title, string author)
        {
            PostUtils postUtils = new PostUtils();
            response = postUtils.CreatePost(id, title, author);       
            
        }

        [Then(@"a post is created with id '([^']*)' title title(.*) and author author(.*)")]
        public void ThenAPostIsCreatedWithIdTitleTitleAndAuthorAuthor(int id, string title, string author)
        {
            Assert.AreEqual(response.id, id);
            Assert.AreEqual(response.title, title);
            Assert.AreEqual(response.author, author);
        }

    }
}
