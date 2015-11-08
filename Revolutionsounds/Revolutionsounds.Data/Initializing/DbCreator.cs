using System.Collections.Generic;
using System.Data.Entity;
using Revolutionsounds.Data.Concrete;
using Revolutionsounds.Entities.Data;

namespace Revolutionsounds.Data.Initializing
{
    public class DbCreator : DropCreateDatabaseAlways<RevolutionSoundsContext>
    {
        protected override void Seed(RevolutionSoundsContext context)
        {
            base.Seed(context);

            var stories = new List<Story>
            {
                new Story {Id = 1, Name = "Story 1", Content = "Description"},
                new Story {Id = 2, Name = "Story 2", Content = "Description"}
            };
            stories.ForEach(r => context.Stories.Add(r));

            context.SaveChanges();
        }
    }
}
