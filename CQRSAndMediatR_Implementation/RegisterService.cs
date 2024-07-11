using System.Reflection;

namespace CQRSAndMediatR_Implementation
{
    public static class RegisterService
    {
        public static void MediatorService(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddMediatR(_b => _b.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        }
    }
}