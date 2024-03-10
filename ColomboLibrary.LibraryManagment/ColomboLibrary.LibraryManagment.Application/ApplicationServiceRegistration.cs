using ColomboLibrary.LibraryManagment.Application.Features.Books.Queries.GetBooksList;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ColomboLibrary.LibraryManagment.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(GetBooksListQueryHandler).Assembly);
            });

            return services;
        }
    }
}
