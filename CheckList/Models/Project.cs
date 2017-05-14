using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CheckList.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        public virtual List<Template> Templates { get; set; }
        public virtual List<ChkList> ChkLists { get; set; }
    }
}
