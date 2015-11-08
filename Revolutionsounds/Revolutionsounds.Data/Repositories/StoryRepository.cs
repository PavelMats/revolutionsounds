using System.Linq;
using Revolutionsounds.Data.Abstract;
using Revolutionsounds.Data.Concrete;
using Revolutionsounds.Entities.Data;

namespace Revolutionsounds.Data.Repositories
{
    public class StoryRepository : GenericRepository<Story>, IStoryRepository
    {
        public StoryRepository(RevolutionSoundsContext context) : base(context)
        {
        }

        public Story GetById(long id)
        {
            return Dbset.FirstOrDefault(x => x.Id == id);
        }
    }
}
