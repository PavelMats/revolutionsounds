using System.Data.Entity;
using Revolutionsounds.Data.Concrete;

namespace Revolutionsounds.Data.Initializing
{
    public static class DbInitializer
    {
        public static void Set()
        {
            Database.SetInitializer(new DbCreator());
            new RevolutionSoundsContext().Database.Initialize(true);
        }
    }
}
