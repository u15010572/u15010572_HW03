using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace u15010572_HW03.Models
{
    public class FileModel
    {
        [Display(Name= "File Name")]
        public string FileName { get; set; }

        public HttpPostedFileBase[] Files { get; set; }
    }
}