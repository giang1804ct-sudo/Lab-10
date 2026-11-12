/*****************/
// Mã sinh viên: 202418889
// Họ tên: Đặng Thị Hương Giang
/*****************/

using System;

namespace SmartHomeMini;

// Lớp Factory tạo thiết bị (Đã sửa lỗi hoa/thường và ném ArgumentException)
public static class DeviceFactory
{
    public static IDevice Create(string type, string name)
    {
        // Sử dụng Trim() và ToLowerInvariant() để không phân biệt chữ hoa/thường và khoảng trắng thừa
        // Sử dụng switch expression và ném ngoại lệ ArgumentException nếu không hỗ trợ
        return type.Trim().ToLowerInvariant() switch
        {
            "light" => new SmartLight(name),
            "fan" => new SmartFan(name),
            "door" => new SmartDoor(name),
            _ => throw new ArgumentException($"Loại thiết bị không được hỗ trợ: {type}")
        };
    }
}
