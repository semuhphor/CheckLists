using System.Collections.Generic;

namespace CheckList.Models
{
    public interface ITemplateRepository
    {
        IEnumerable<Template> Templates { get; }
    }
}
