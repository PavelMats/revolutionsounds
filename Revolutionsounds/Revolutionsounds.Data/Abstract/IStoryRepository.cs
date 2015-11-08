using Revolutionsounds.Entities.Data;

namespace Revolutionsounds.Data.Abstract
{
    public interface IStoryRepository
    {
        Story GetById(long id);
    }
}
