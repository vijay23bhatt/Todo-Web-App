using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace To_DoApp.Models
{
    public class Task
    {
        public int id { get; set; }
        public String taskTitle { get; set; }
        public DateTime TaskEndTime { get; set; }
        public bool isDone { get; set; }
        public virtual ApplicationUser user { get; set; }
    }
}