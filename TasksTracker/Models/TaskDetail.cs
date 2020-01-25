using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TasksTracker.Models
{
    public enum TaskType
    {
        Created,
        InPrograss,
        Complete,
        Forward
    }

    public class TaskDetail
    {
        [Key]
        public int TDId { get; set; }
        [Required]
        [StringLength(50)]
        public string TaskName { get; set; }
        [Required]
        public DateTime TaskTime { get; set; }
        [Required]
        public TaskType TaskType { get; set; }
    }
}
