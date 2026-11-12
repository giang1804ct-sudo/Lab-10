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

        Console.WriteLine("=== BƯỚC 4: KIỂM TRA LẠI DEVICE FACTORY VÀ SINGLETON ĐÃ SỬA ===");

        // [T1] Tạo thiết bị không phân biệt chữ hoa/thường
        Console.WriteLine("\n[T1] Kiểm tra tạo light, fan, door (có cả chữ hoa):");
        IDevice light = DeviceFactory.Create("LiGhT", "Đèn phòng khách");
        IDevice fan = DeviceFactory.Create("fan ", "Quạt phòng khách");
        IDevice door = DeviceFactory.Create("DOOR", "Cửa chính");
        Console.WriteLine($"-> Tạo thành công: {light.GetType().Name}, {fan.GetType().Name}, {door.GetType().Name}");

        // [T2] Kiểm tra ngoại lệ ArgumentException khi tạo thiết bị không hỗ trợ
        Console.WriteLine("\n[T2] Kiểm tra tạo thiết bị 'camera' không hỗ trợ:");
        try
        {
            DeviceFactory.Create("camera", "Camera giám sát");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"-> THÀNH CÔNG: Đã bắt đúng ngoại lệ: \"{ex.Message}\"");
        }

        // [T3] Kiểm tra Singleton
        Console.WriteLine("\n[T3] Kiểm tra Singleton HomeConfiguration:");
        var c1 = HomeConfiguration.Instance;
        var c2 = HomeConfiguration.Instance;
        Console.WriteLine($"-> c1 và c2 cùng tham chiếu: {ReferenceEquals(c1, c2)}");
        Console.WriteLine("-> Lúc này nếu gõ 'new HomeConfiguration()' sẽ bị trình biên dịch chặn ngay!");
    }
}
