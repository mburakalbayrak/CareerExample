using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class CareerSetting : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public string ApplicationName { get; set; }

        public DateTime InsertedDate { get; set; }

        public CareerSetting()
        {
            InsertedDate = DateTime.Now;
            IsDeleted = false;
            IsActive = true;
        }
    }
}
