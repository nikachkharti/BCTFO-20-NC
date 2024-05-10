namespace Todo.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.AddDatabaseContext();
            builder.ConfigureJwtOptions();
            builder.AddIdentity();
            builder.AddAuthentication();
            builder.AddHttpContextAccessor();
            builder.AddScopedServices();
            builder.AddControllers();
            builder.AddEndpointsApiExplorer();
            builder.AddSwagger();
            builder.AddCors();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors(builder.Configuration.GetValue<string>("Cors:AllowOrigin"));
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
