﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSArticle.ModelsLayer
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Title { get; set; }
        public string ImageName { get; set; }


    }
}
