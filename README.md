1. Factory đang che giấu quyết định thiết kế nào đối với client?

Trả lời: Factory che giấu logic khởi tạo cụ thể và lớp đối tượng thực tế (Concrete Class) được tạo ra. Client chỉ cần truyền vào tên loại dạng chuỗi ("light", "fan", "door") và nhận lại abstraction IDevice mà không cần biết class cụ thể được instantiate như thế nào, có constructor ra sao.

2. Singleton bảo đảm điều gì, nhưng tạo ra rủi ro nào?

Trả lời:

Bảo đảm: Duy nhất một thể hiện (instance) của class tồn tại trong ứng dụng và cung cấp điểm truy cập toàn cục đến thể hiện đó.

Rủi ro: Gây phụ thuộc ẩn giữa các module; khó cô lập để viết Unit Test; vi phạm Single Responsibility Principle (Nguyên lý Đơn trách nhiệm).

3. Facade khác Factory ở mục đích chính như thế nào?

Trả lời:

Factory (Creational Pattern): Tập trung vào việc tạo đối tượng (Object Creation), che giấu cách khởi tạo và loại đối tượng cụ thể.

Facade (Structural Pattern): Tập trung vào giao diện sử dụng (Interface Simplification), nhóm nhiều thao tác phức tạp của nhiều đối tượng lại thành một giao diện đơn giản hơn ở mức cao.

4. Nếu bỏ SmartHomeFacade, client sẽ phải biết thêm những chi tiết nào?

Trả lời:
Client sẽ phải tự nắm giữ tham chiếu trực tiếp đến từng thiết bị, tự ép kiểu door sang ILockable để gọi Lock(), tự nhớ thứ tự thực hiện kịch bản và tự truy cập HomeConfiguration để lấy thông số.
