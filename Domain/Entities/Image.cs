using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace CourseWork.Domain.Entities
{
    public class Image
    {
        [Key]
        public Guid Id { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string ImageName { get; set; }
        
        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}