/*****************/
// Mã sinh viên: 202418889
// Họ tên: Đặng Thị Hương Giang
/*****************/

using System;

namespace SmartHomeMini;

// Lớp cấu hình chung ngôi nhà (Đã hoàn thiện Singleton an toàn luồng)
public sealed class HomeConfiguration
{
    // Sử dụng Lazy<T> để an toàn đa luồng và khởi tạo trễ (lazy initialization)
    private static readonly Lazy<HomeConfiguration> lazy =
        new(() => new HomeConfiguration());

    public static HomeConfiguration Instance => lazy.Value;

    public string HomeName { get; set; } = "Ngôi nhà thông minh của tôi";
    public int NightLightLevel { get; set; } = 30;

    // Constructor private ngăn cản việc khởi tạo từ bên ngoài
    private HomeConfiguration()
    {
    }
}
