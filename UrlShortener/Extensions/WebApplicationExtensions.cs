using Microsoft.EntityFrameworkCore;

namespace UrlShortener.Extensions
{
    public static class WebApplicationExtensions
    {
        public static void ApplyDatabaseMigrations(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            dbContext.Database.Migrate();
        }
    }
}
