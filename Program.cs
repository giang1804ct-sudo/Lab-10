/*****************/
// Mã sinh viên: 202418889
// Họ tên: Đặng Thị Hương Giang
/*****************/

using System;
using System.Text;

namespace SmartHomeMini;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("=== BƯỚC 3: THỬ NGHIỆM CẤU HÌNH HOMECONFIGURATION (BẢN NHÁP) ===");

        // Lấy cấu hình qua Instance
        var config1 = HomeConfiguration.Instance;
        var config2 = HomeConfiguration.Instance;

        Console.WriteLine($"Tên ngôi nhà: {config1.HomeName}");
        Console.WriteLine($"Mức sáng ban đêm mặc định: {config1.NightLightLevel}%");
        Console.WriteLine($"Kiểm tra hai biến cùng trỏ về một đối tượng: {ReferenceEquals(config1, config2)}");

        // Phát hiện lỗi thiết kế: Do constructor public nên bên ngoài vẫn new được!
        var config3 = new HomeConfiguration();
        Console.WriteLine($"Cảnh báo: Bên ngoài vẫn 'new HomeConfiguration()' được tự do: {config3 != null}");
        Console.WriteLine($"config1 và config3 là 2 đối tượng khác nhau: {!ReferenceEquals(config1, config3)} (Vi phạm Singleton!)");
    }
}
