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
        // Cấu hình in tiếng Việt có dấu chuẩn UTF-8 trên Console
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("=== BƯỚC 1: KHỞI TẠO CÁC THIẾT BỊ CƠ BẢN ===");

        // Khởi tạo trực tiếp bằng constructor để kiểm tra hành vi từng lớp
        var light = new SmartLight("Đèn phòng khách");
        var fan = new SmartFan("Quạt phòng ngủ");
        var door = new SmartDoor("Cửa chính");

        Console.WriteLine("\nKiểm tra thiết bị đèn:");
        light.TurnOn();
        light.TurnOff();

        Console.WriteLine("\nKiểm tra thiết bị quạt:");
        fan.TurnOn();
        fan.TurnOff();

        Console.WriteLine("\nKiểm tra thiết bị cửa:");
        door.TurnOn();
        door.Lock();
        door.Unlock();
        door.TurnOff();
    }
}
