using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace TriviaGameAPI
{
    public interface IInstaller
    {
        void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}
