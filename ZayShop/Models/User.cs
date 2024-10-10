namespace ZayShop.Models; 
public class User {
    public int Id { get; set; }  // Уникальный идентификатор пользователя
    public string FirstName { get; set; }  // Имя пользователя
    public string LastName { get; set; }  // Фамилия пользователя
    public string Email { get; set; }  // Электронная почта пользователя
    public string PasswordHash { get; set; }  // Хеш пароля для безопасного хранения

    // Список заказов пользователя
    public ICollection<Order> Orders { get; set; }
}
