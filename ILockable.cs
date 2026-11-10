/*****************/
// Mã sinh viên: 202418889
// Họ tên: Đặng Thị Hương Giang
/*****************/

namespace SmartHomeMini;

// Interface riêng cho các thiết bị có tính năng khóa và mở khóa (như cửa)
public interface ILockable
{
    void Lock();
    void Unlock();
}
