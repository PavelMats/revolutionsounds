using Ninject.Modules;
using Ninject.Web.Common;
using Revolutionsounds.Data.Abstract;
using Revolutionsounds.Data.Concrete;
using Revolutionsounds.Data.Repositories;

namespace Revolutionsounds.Data.Infrastructure
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<RevolutionSoundsContext>().ToSelf().InRequestScope();
            Bind<IStoryRepository>().To<StoryRepository>().InRequestScope();
        }
    }
}
