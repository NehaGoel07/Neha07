using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicMenu.Models
{
    public class MyTasks
    {
        [Key]
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDesc { get; set; }
        public DateTime TaskDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Priority { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsDeleted { get; set; }
        public string UserId { get; set; }
    }
}
