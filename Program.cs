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

        Console.WriteLine("=== BƯỚC 5: THỬ NGHIỆM SMARTHOMEFACADE (BẢN NHÁP) ===");

        IDevice light = DeviceFactory.Create("light", "Đèn phòng ngủ");
        IDevice fan = DeviceFactory.Create("fan", "Quạt trần phòng ngủ");
        IDevice door = DeviceFactory.Create("door", "Cửa chính");

        var facade = new SmartHomeFacade(light, fan, (SmartDoor)door);

        Console.WriteLine("\n--- Thử nghiệm kịch bản Đi làm (GoToWork) ---");
        facade.GoToWork();

        Console.WriteLine("\n--- Thử nghiệm kịch bản Đi ngủ (GoToSleep) ---");
        facade.GoToSleep();
        Console.WriteLine("-> Nhận xét: Quạt chưa được tắt khi đi ngủ, mức sáng đang cố định 50% chưa khớp với cấu hình!");
    }
}
