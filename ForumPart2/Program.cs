using ForumPart2.DAL;
using ForumPart2.DAL.Context;
using ForumPart2.DAL.Entites;
using ForumPart2.Services.Abstractions;
using ForumPart2.Services.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextFactory<ApplicationDBContext>(o =>
{
    var connectionString = builder.Configuration.GetConnectionString("TrustConnection");
    o.UseSqlServer(connectionString, SqlServerBuilder =>
    {
        SqlServerBuilder.MigrationsAssembly(typeof(ApplicationDBContext).Assembly.GetName().Name)
            .UseQuerySplittingBehavior(QuerySplittingBehavior.SingleQuery);

    });
});
var assemlies = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.FullName.StartsWith("ForumPart2")).ToList();
builder.Services.AddAutoMapper(assemlies);
;
builder.Services.AddSingleton<IContextFactory, ContextFactory>();
builder.Services.AddTransient<IPostService, PostService>();
builder.Services.AddTransient<ICommentService, CommentService>();
using (IServiceScope serviceScope = builder.Services.BuildServiceProvider().GetRequiredService<IServiceScopeFactory>().CreateScope())
    
{
    ApplicationDBContext context = serviceScope.ServiceProvider.GetService<ApplicationDBContext>();
    context.Database.Migrate();
}

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
