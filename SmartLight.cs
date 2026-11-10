/*****************/
// Mã sinh viên: 202418889
// Họ tên: Đặng Thị Hương Giang
/*****************/

using System;

namespace SmartHomeMini;

// Lớp đèn thông minh, cài đặt IDevice
public class SmartLight : IDevice
{
    private readonly string name;

    public SmartLight(string name)
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
