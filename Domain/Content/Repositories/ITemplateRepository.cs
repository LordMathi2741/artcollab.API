using Domain.Content.Model.Aggregates;
using Domain.Shared.Repositories;

namespace Domain.Content.Repositories;

public interface ITemplateRepository : IBaseRepository<Template>
{
   bool TemplateByTitleExists(string title);
   Task<IEnumerable<Template?>> GetTemplatesByGenre(string genre);
   Task<Template?> GetTemplateByCoverImage(string imgUrl);
   Task<Template?> GetTemplateByDescription(string description);
}