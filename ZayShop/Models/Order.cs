using ZayShop.Models;

public class Order {
    public int Id { get; set; }  // Уникальный идентификатор заказа
    public DateTime OrderDate { get; set; }  // Дата оформления заказа
    public string Status { get; set; }  // Статус заказа (например, "В процессе", "Доставлено")

    // Внешний ключ к пользователю, который оформил заказ
    public int UserId { get; set; }
    public User User { get; set; }

    // Список продуктов в заказе
    public ICollection<Product> Products { get; set; }

    // Общая сумма заказа
    public decimal TotalAmount { get; set; }
}