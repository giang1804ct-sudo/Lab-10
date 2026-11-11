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

        Console.WriteLine("=== BƯỚC 2: THỬ NGHIỆM DEVICE FACTORY (BẢN NHÁP) ===");

        // Thử tạo các thiết bị hợp lệ
        Console.WriteLine("\n[Thử nghiệm 1] Tạo thiết bị hợp lệ qua Factory:");
        IDevice? light = DeviceFactory.Create("light", "Đèn phòng khách");
        IDevice? fan = DeviceFactory.Create("fan", "Quạt phòng khách");
        IDevice? door = DeviceFactory.Create("door", "Cửa chính");

        Console.WriteLine($"-> Đèn tạo ra kiểu: {light?.GetType().Name}");
        Console.WriteLine($"-> Quạt tạo ra kiểu: {fan?.GetType().Name}");
        Console.WriteLine($"-> Cửa tạo ra kiểu: {door?.GetType().Name}");

        // Thử nghiệm lỗi 1: truyền chữ hoa
        Console.WriteLine("\n[Thử nghiệm 2] Truyền chữ hoa 'Light' (kỳ vọng tạo được):");
        IDevice? uppercaseLight = DeviceFactory.Create("Light", "Đèn ngủ");
        if (uppercaseLight == null)
        {
            Console.WriteLine("-> THẤT BẠI: Factory trả về null do chưa xử lý chữ hoa/thường!");
        }

        // Thử nghiệm lỗi 2: truyền loại chưa hỗ trợ (kỳ vọng ném ArgumentException)
        Console.WriteLine("\n[Thử nghiệm 3] Tạo thiết bị 'camera' (kỳ vọng ném ArgumentException):");
        IDevice? cam = DeviceFactory.Create("camera", "Camera giám sát");
        if (cam == null)
        {
            Console.WriteLine("-> THẤT BẠI: Factory trả về null thay vì ném ngoại lệ ArgumentException!");
        }
    }
}
