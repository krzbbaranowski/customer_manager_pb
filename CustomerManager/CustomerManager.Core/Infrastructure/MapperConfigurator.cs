using AutoMapper;
using CustomerManager.Core.Infrastructure.MapperProfiles;

namespace CustomerManager.Core.Infrastructure
{
    public class MapperConfigurator
    {
        public static MapperConfiguration InitializeProfiles()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new CustomerProfile());
            });
        }
    }
}
