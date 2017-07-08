## THÔNG TIN VỀ TỔ CHỨC MÃ NGUỒN

**Mã nguồn được tổ chức rõ ràng, theo mô hình 3 lớp.**

## MÔ HÌNH 3 LỚP

![images](https://user-images.githubusercontent.com/27652065/27962171-4188988c-635b-11e7-9aac-0dfb3889b262.jpg)
 
Mô hình 3 lớp được cấu thành từ: 
Presentation Layers, Business Logic Layers, và Data Access Layers.

**Graphical User Interface**

Lớp này làm nhiệm vụ giao tiếp với người dùng cuối để thu thập dữ liệu và 
hiển thị kết quả/dữ liệu thông qua các thành phần trong giao diện người sử dụng. 
Trong .NET thì bạn có thể dùng Windows Forms, ASP.NET hay Mobile Forms 
để hiện thực lớp này

**Business Logic Layer**

Đây là layer xử lý chính các dữ liệu trước khi được đưa lên hiển thị trên 
màn hình hoặc xử lý các dữ liệu trước khi chuyển xuống Data Access Layer để 
lưu dữ liệu xuống cơ sở dữ liệu. Đây là nơi đê kiểm tra ràng buộc, các yêu cầu
nghiệp vụ, tính toán, xử lý các yêu cầu và lựa chọn kết quả trả về cho 
Presentation Layers.

**Data Access Layer**

Lớp này thực hiện các nghiệp vụ liên quan đến lưu trữ và truy xuất dữ liệu 
của ứng dụng như đọc, lưu, cập nhật cơ sở dữ liệu. Cách vận hành của mô hình.
Đối với 3-Layer, yêu cầu được xử lý tuần tự qua các layer. Đầu tiên User 
giao tiếp với Presentation Layers (GUI) để gửi đi thông tin và yêu cầu. 
Tại layer này, các thông tin sẽ được kiểm tra, nếu OK chúng sẽ được chuyển xuống
Business Logic Layer (BLL). Tại BLL, các thông tin sẽ được nhào nặn, tính toán 
theo đúng yêu cầu đã gửi, nếu không cần đến Database thì BLL sẽ gửi trả kết 
quả về GUI, ngược lại nó sẽ đẩy dữ liệu (thông tin đã xử lý) xuống Data Access 
Layer (DAL). DAL sẽ thao tác với Database và trả kết quả về cho BLL, 
BLL kiểm tra và gửi nó lên GUI để hiển thị cho người dùng. Một khi gặp lỗi 
(các trường hợp không đúng dữ liệu) thì đang ở layer nào thì quăng lên trên 
layer cao hơn nó 1 bậc cho tới GUI thì sẽ quăng ra cho người dùng biết. 
Các dữ liệu được trung chuyển giữa các Layer thông qua một đối tượng gọi 
là Data Transfer Object (DTO), đơn giản đây chỉ là các Class đại diện cho các 
đối tượng được lưu trữ trong Database. Tổ chức mô hình 3 –Layer.

Có rất nhiều cách đặt tên cho các thành phần của 3 lớp như:
<ul>
	<li>Cách 1: GUI, BUS, DAL</li>
	<li>Cách 2: GUI, BLL, DAO, DTO</li>
	<li>Cách 3: Presentation, BLL, DAL</li>

Mã nguồn được tổ chức theo 3 lớp chính DAL,BLL,View(GUI) Còn thêm 1 tầng trung gian 
luân chuyển giữa các tầng là DTO.

## MÔ HÌNH 3 TẦNG

![3-tier](https://user-images.githubusercontent.com/27652065/27961707-d4191ad4-6359-11e7-8187-bac471746a32.jpg)
 


