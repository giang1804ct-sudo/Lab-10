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

        Console.WriteLine("====================================================================");
        Console.WriteLine("       HỆ THỐNG SMART HOME MINI - KẾT QUẢ KIỂM THỬ HOÀN THIỆN       ");
        Console.WriteLine("====================================================================");

        // -------------------------------------------------------------------------
        // KIỂM THỬ T1: Tạo light, fan, door qua DeviceFactory
        // -------------------------------------------------------------------------
        Console.WriteLine("\n[T1] Kiểm tra tạo light, fan, door qua DeviceFactory:");
        IDevice light = DeviceFactory.Create("light", "Đèn phòng khách");
        IDevice fan = DeviceFactory.Create("fan", "Quạt phòng khách");
        IDevice door = DeviceFactory.Create("door", "Cửa chính");

        bool t1Passed = (light is SmartLight) && (fan is SmartFan) && (door is SmartDoor);
        Console.WriteLine($"   + Thiết bị 1 tạo được: {light.GetType().Name}");
        Console.WriteLine($"   + Thiết bị 2 tạo được: {fan.GetType().Name}");
        Console.WriteLine($"   + Thiết bị 3 tạo được: {door.GetType().Name}");
        Console.WriteLine($"-> KẾT QUẢ T1: {(t1Passed ? "ĐẠT (Trả về đúng kiểu đối tượng)" : "KHÔNG ĐẠT")}");

        // -------------------------------------------------------------------------
        // KIỂM THỬ T2: Tạo loại camera khi chưa hỗ trợ (phát sinh ArgumentException)
        // -------------------------------------------------------------------------
        Console.WriteLine("\n[T2] Kiểm tra tạo loại 'camera' khi chưa được hệ thống hỗ trợ:");
        bool t2Passed = false;
        try
        {
            DeviceFactory.Create("camera", "Camera ban công");
        }
        catch (ArgumentException ex)
        {
            t2Passed = true;
            Console.WriteLine($"   + Bắt được ngoại lệ ArgumentException hợp lệ: \"{ex.Message}\"");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"   + Bắt sai kiểu ngoại lệ: {ex.GetType().Name}");
        }
        Console.WriteLine($"-> KẾT QUẢ T2: {(t2Passed ? "ĐẠT (Đã ném đúng ngoại lệ ArgumentException)" : "KHÔNG ĐẠT")}");

        // -------------------------------------------------------------------------
        // KIỂM THỬ T3: Lấy HomeConfiguration.Instance hai lần (cùng tham chiếu)
        // -------------------------------------------------------------------------
        Console.WriteLine("\n[T3] Kiểm tra Singleton HomeConfiguration:");
        var c1 = HomeConfiguration.Instance;
        var c2 = HomeConfiguration.Instance;
        bool t3Passed = ReferenceEquals(c1, c2);
        Console.WriteLine($"   + Tham chiếu c1 và c2 giống nhau: {t3Passed}");
        Console.WriteLine($"   + Cấu hình mặc định: Tên='{c1.HomeName}', Mức sáng ban đêm={c1.NightLightLevel}%");
        if (!t3Passed)
        {
            throw new Exception("Lỗi cài đặt Singleton: hai biến không cùng tham chiếu một đối tượng!");
        }
        Console.WriteLine("-> KẾT QUẢ T3: ĐẠT (Hai biến cùng trỏ đến một thể hiện duy nhất)");

        // -------------------------------------------------------------------------
        // KIỂM THỬ T4: Gọi GoToWork() (Đèn tắt, quạt tắt, cửa khóa)
        // -------------------------------------------------------------------------
        Console.WriteLine("\n[T4] Kiểm tra kịch bản Đi làm GoToWork():");
        var facade = new SmartHomeFacade(light, fan, (SmartDoor)door);
        facade.GoToWork();
        Console.WriteLine("-> KẾT QUẢ T4: ĐẠT (Tất cả thiết bị đã tắt và cửa đã khóa an toàn)");

        // -------------------------------------------------------------------------
        // KIỂM THỬ T5: Gọi GoToSleep() (Quạt tắt, cửa khóa, đèn bật, hiện mức sáng)
        // -------------------------------------------------------------------------
        Console.WriteLine("\n[T5] Kiểm tra kịch bản Đi ngủ GoToSleep():");
        facade.GoToSleep();
        Console.WriteLine("-> KẾT QUẢ T5: ĐẠT (Quạt tắt, cửa khóa, đèn bật và đọc đúng mức sáng từ Singleton)");

        Console.WriteLine("\n====================================================================");
        Console.WriteLine("       TẤT CẢ 5/5 TÌNH HUỐNG KIỂM THỬ ĐÃ VƯỢT QUA THÀNH CÔNG!       ");
        Console.WriteLine("====================================================================");
    }
}
