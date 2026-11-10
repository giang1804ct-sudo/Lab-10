/*****************/
// Mã sinh viên: 202418889
// Họ tên: Đặng Thị Hương Giang
/*****************/

using System;

namespace SmartHomeMini;

// Lớp quạt thông minh, cài đặt IDevice
public class SmartFan : IDevice
{
    private readonly string name;

    public SmartFan(string name)
    {
        this.name = name;
    }

    public void TurnOn()
    {
        Console.WriteLine($"{name}: ĐÃ BẬT");
    }

    public void TurnOff()
    {
        Console.WriteLine($"{name}: ĐÃ TẮT");
    }
}
