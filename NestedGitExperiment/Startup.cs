using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NestedGitExperiment.Startup))]
namespace NestedGitExperiment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
