using Microsoft.Owin.Extensions;
using Owin;
using SquishIt.Framework;

namespace MyNancyApp
{
    public partial class Startup
    {
        private static void ConfigureSquishIt(IAppBuilder app)
        {
            app.UseStageMarker(PipelineStage.MapHandler);

            Bundle.JavaScript()
                    .AddDirectory("~/Scripts")
                    .AsNamed("js", "");

            Bundle.Css()
                .AddDirectory("~/Content")
                .AsNamed("css", "");
        }
    }
}