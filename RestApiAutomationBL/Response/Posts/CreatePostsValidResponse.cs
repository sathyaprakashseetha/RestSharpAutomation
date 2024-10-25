using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiAutomationBL.Response.Posts
{
    public class CreatePostsValidResponse
    {
        public string id { get; set; }
        public string title { get; set; }
        public int views { get; set; }
    }
}
