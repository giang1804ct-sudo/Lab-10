/*****************/
// Mã sinh viên: 202418889
// Họ tên: Đặng Thị Hương Giang
/*****************/

using System;

namespace SmartHomeMini;

// Facade cung cấp giao diện cấp cao điều khiển các thiết bị (Bản nháp ban đầu)
public class SmartHomeFacade
{
    private readonly IDevice light;
    private readonly IDevice fan;
    private readonly ILockable door;

    public SmartHomeFacade(IDevice light, IDevice fan, ILockable door)
    {
        this.light = light;
        this.fan = fan;
        this.door = door;
    }

    public void GoToWork()
    {
        light.TurnOff();
        fan.TurnOff();
        door.Lock();
    }

    public void GoToSleep()
    {
        // Lỗi 1: Quên tắt quạt khi đi ngủ
        // fan.TurnOff(); // TODO: Cần bổ sung tắt quạt trước khi ngủ
        door.Lock();
        light.TurnOn();

        // Lỗi 2: Hardcode mức sáng 50% thay vì đọc từ cấu hình HomeConfiguration
        Console.WriteLine("Mức sáng ban đêm: 50%");
    }
}
