using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckList.Models
{
    public class Template
    {
        public int TemplateId { get; set; }
        public int ProjectId { get; set; }
        public string TemplateName { get; set; }
        public string Json { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Project Project { get; set; }
    }
}
