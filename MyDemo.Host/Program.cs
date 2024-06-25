using Microsoft.EntityFrameworkCore;
using MyDemo.Entities;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var connection = "server=127.0.0.1;user=root;pwd=123456;database=wx_my_english";
services.AddDbContextPool<MyDemoDbContext>(options => options.UseMySql(connection, ServerVersion.Parse("8.0"), b => b.MigrationsAssembly("MyDemo.Host")));


var app = builder.Build();  // 要注意，build()后边不能再配置service了
app.Run();