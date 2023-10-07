using FreelancerProject.Services.FileSystem;

namespace FreelancerProject.Web.Configuarations
{
    public static class ServicesConfiguration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IFileSystemService, FileSystemService>()//.
                ;
            //TODO: Add More when needed.
        }
    }
}
