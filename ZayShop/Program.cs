using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Добавляем поддержку контроллеров и представлений
builder.Services.AddControllersWithViews();

// Настраиваем контекст базы данных и подключаем PostgreSQL
builder.Services.AddDbContext<OrderContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Включаем перенаправление на HTTPS
app.UseHttpsRedirection();

// Подключаем статические файлы
app.UseStaticFiles();

// Настраиваем маршрутизацию
app.UseRouting();

// Подключаем авторизацию (если есть)
app.UseAuthorization();

// Настраиваем маршрут по умолчанию
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();