﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiAutomationBL.Response.Posts
{
    public class CreatePostsValidResponse
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
    }
}
