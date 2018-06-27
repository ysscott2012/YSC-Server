using System;
using System.ComponentModel.DataAnnotations;

namespace YSC_Server.DaoModels
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public int Creator { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdatedTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}