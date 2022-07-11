﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager cm = new CommentManager(new EFCommentRepository());

        public IViewComponentResult Invoke()
        {
            var values = cm.GetListAll(4);
            return View(values);
        }
    }
}
