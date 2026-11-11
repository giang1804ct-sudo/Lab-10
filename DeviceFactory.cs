/*****************/
// Mã sinh viên: 202418889
// Họ tên: Đặng Thị Hương Giang
/*****************/

using System;

namespace SmartHomeMini;

// Lớp Factory tạo thiết bị (Bản nháp ban đầu)
public static class DeviceFactory
{
    public static IDevice? Create(string type, string name)
    {
        if (type == "light")
        {
            return new SmartLight(name);
        }
        else if (type == "fan")
        {
            return new SmartFan(name);
        }
        else if (type == "door")
        {
            return new SmartDoor(name);
        }

        // TODO: Cần xử lý ném ngoại lệ ArgumentException thay vì trả về null
        return null;
    }
}
