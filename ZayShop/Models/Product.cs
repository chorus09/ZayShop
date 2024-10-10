namespace ZayShop.Models; 
public class Product {
    public int Id { get; set; }  // Уникальный идентификатор продукта
    public string Name { get; set; }  // Название продукта
    public string Description { get; set; }  // Описание продукта
    public decimal Price { get; set; }  // Цена продукта
    public string Category { get; set; }  // Категория продукта (например, "Одежда", "Обувь")
    public string ImageUrl { get; set; }  // Ссылка на изображение продукта

    // Можно добавить дополнительные свойства, если нужно
}
