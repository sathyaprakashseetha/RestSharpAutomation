using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiAutomationBL.Requests.Posts
{
    public class CreatePostsValidRequest
    {
        public string id { get; set; }
        public string title { get; set; }
        public int views { get; set; }
    }
}
