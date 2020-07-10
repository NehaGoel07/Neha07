using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TriviaGameAPI
{
    public class DBInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TriviaGameContext>(options =>
               options.UseSqlServer(
                   configuration["ConnectionString:conn"]));
           services.AddScoped<IRoleMaster, RoleMasterService>();
            services.AddScoped<IQuestionTypeMaster, QuestionTypeMasterService>();
            services.AddScoped<IPlatformMaster, PlatformMasterService>();
            services.AddScoped<IDifficultyLevelMaster, DifficultyLevelMasterService>();
            services.AddScoped<ILogin, Login>();
        }
    }
}
