// filepath: c:\Users\AnhNguyen\Documents\web chieu 3\MyWebApp\Models\Product.cs
namespace MyWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } // Đường dẫn đến hình ảnh sản phẩm
        public string Description { get; set; } // Mô tả ngắn (tùy chọn)
    }
}