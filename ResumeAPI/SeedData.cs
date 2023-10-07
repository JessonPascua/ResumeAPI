using ResumeAPI.Data;

namespace ResumeAPI
{
    public class SeedData
    {
        public async static Task MySeedData(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ResumeAPIContext>();
                await SeedResume(dbContext);
            }
        }

        private static Task SeedResume(ResumeAPIContext dbContext)
        {
            throw new NotImplementedException();
        }
    }
}
