/*****************/
// Mã sinh viên: 202418889
// Họ tên: Đặng Thị Hương Giang
/*****************/

namespace SmartHomeMini;

// Lớp cấu hình chung cho ngôi nhà (Bản nháp ban đầu)
// Lỗi 1: Chưa có từ khóa sealed để ngăn kế thừa
public class HomeConfiguration
{
    // Lỗi 2: Khởi tạo singleton thô sơ, chưa thread-safe bằng Lazy<T>
    private static HomeConfiguration? instance;

    public static HomeConfiguration Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new HomeConfiguration();
            }
            return instance;
        }
    }

    public string HomeName { get; set; } = "Ngôi nhà thông minh của tôi";
    public int NightLightLevel { get; set; } = 30;

    // Lỗi 3: Để constructor public khiến bên ngoài vẫn new tự do được!
    public HomeConfiguration()
    {
    }
}
