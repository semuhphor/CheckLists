using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckList.Models
{
    public class ChkList
    {
        public int ChkListId { get; set; }
        public int ProjectId { get; set; }
        public string ChkListName { get; set; }
        public string FromTemplate { get; set; }
        public string Json { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Project Project { get; set; }
    }
}
