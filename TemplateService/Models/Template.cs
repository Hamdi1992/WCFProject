using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TemplateService.Models
{
    [Serializable]
    [Table("Template")]
    public class Template
    {
        public Template(){}

        public Template(string Name, string TextSample) {
            this.Name = Name;
            this.TextSample = TextSample;
        }

        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string TextSample { get; set; }

    }
}