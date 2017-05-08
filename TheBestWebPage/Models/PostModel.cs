﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheBestWebPage.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? TimePosted { get; set; } = DateTime.Now;
        public string ImggeUrl { get; set; }
        public string Body { get; set; }


        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}