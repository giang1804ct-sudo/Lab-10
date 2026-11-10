/*****************/
// Mã sinh viên: 202418889
// Họ tên: Đặng Thị Hương Giang
/*****************/

using System;

namespace SmartHomeMini;

// Lớp cửa thông minh, cài đặt IDevice và ILockable
public class SmartDoor : IDevice, ILockable
{
    private readonly string name;

    public SmartDoor(string name)
    {
        this.name = name;
    }

    public void TurnOn()
    {
        Console.WriteLine($"{name}: ĐÃ MỞ");
    }

    public void TurnOff()
    {
        Console.WriteLine($"{name}: ĐÃ ĐÓNG");
    }

    public void Lock()
    {
        Console.WriteLine($"{name}: ĐÃ KHÓA");
    }

    public void Unlock()
    {
        Console.WriteLine($"{name}: ĐÃ MỞ KHÓA");
    }
}
