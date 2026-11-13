/*****************/
// Mã sinh viên: 202418889
// Họ tên: Đặng Thị Hương Giang
/*****************/

using System;

namespace SmartHomeMini;

// Facade cung cấp giao diện cấp cao điều khiển các thiết bị (Đã hoàn thiện)
public sealed class SmartHomeFacade
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
        // Đã sửa: Tắt quạt, khóa cửa an toàn, bật đèn ngủ
        fan.TurnOff();
        door.Lock();
        light.TurnOn();

        // Đã sửa: Đọc trực tiếp mức sáng ban đêm từ Singleton HomeConfiguration
        int level = HomeConfiguration.Instance.NightLightLevel;
        Console.WriteLine($"Mức sáng ban đêm: {level}%");
    }
}
