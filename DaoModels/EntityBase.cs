using System;
using System.ComponentModel.DataAnnotations;

namespace YSC_Server.DaoModels
{
    public class EntityBase
    {
        [Key]
        public int id { get; set; }
        public int Creator { get; set; }
        public DateTime CrationTIme { get; set; }
        public DateTime LastUpdatedTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}