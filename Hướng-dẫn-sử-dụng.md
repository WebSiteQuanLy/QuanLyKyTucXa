## HƯỚNG DẪN SỬ DỤNG PHẦN MỀM

Phiên bản 1 phần mềm "Quản lý ký túc xá sinh viên Khánh Hòa"
được xuất bản bởi Ngô Mậu Bảo & Nguyễn Thị Mỹ Linh.

<ul>
Để sử dụng được chương trình trên máy tính phải có:
  <li>SQL Server 2012, hoặc bản khác cao hơn</li>
  <li>Visual Studio 2013, hoặc bản khác cao hơn</li>
  <li>Attach CSDL QLKTX vào SQL Server 2012 </li>
  <li>Mở chương trình lên và thay đổi chuỗi kết nối đến CSDL trong file Datahelper.cs</li>
</ul>

## CẤU TRÚC CỦA PHẦN MỀM 

**PHẦN MỀM GỒM CÓ**

<ul>
  <li>Form giới thiệu</li>

Qua form giới thiệu sẽ giới thiệu sơ lược về sinh viên thực hiện và tên đề tài.

  <li>Form đăng nhập </li>
	Form đăng nhập chính là sự phân quyền khi đăng nhập hệ thống, sẽ đảm 
bảo được tính bảo mật, tính an toàn của hệ thống. Bên cạnh đó còn hỗ trợ sự 
kiểm soát và hỗ trợ đầy đủ các chức năng như đã phân quyền.
 Muốn sử dụng được phần mềm phải có tên đăng nhập và mật khẩu.

<li>Quản lý phòng</li>

	+Tổng thông tin phòng.
	   Cho ta biết được thông tin phòng một cách chính xác và tổng quát nhất.
	Quản lý phòng nhằm mục đích kiểm soát tất cả các phòng có sinh viên ở 
	hay số sinh viên ở đã vượt quá.

	+Thêm, xóa, sửa, hiển thị phòng.
	Ban quản lý sẽ cập nhật thường xuyên các thông tin về mỗi phòng ở mỗi nhà ký 
	túc xá, bao gồm: số phòng, khu nhà, tình trạng phòng, số lượng sinh viên, 
	mô tả khác…

  <li>Quản lý sinh viên</li>

	+Tổng, thông tin sinh viên.

	quản lý sinh viên một phần chức năng không thể thiếu của bất kỳ phần mềm quản 
	lý KTX nào. Qua mục quản lý sinh viên ta có thể kiểm soát sinh viên vào ra KTX,
	lý lịch sinh viên đang ở. Kiếm soát được số năm hiệu lực của hợp đồng.

	+Thêm, xóa, sửa, hiển thị thông tin sinh viên.
	Trong thời gian sinh viên tạm trú ở ký túc xá, bộ phận quản lý sinh viên sẽ,
	tiếp nhận và lưu trữ toàn bộ thông tin về sinh viên, bao gồm: mã sinh viên, họ tên,
	ngày sinh, giới tính, số điện thoại, số CMND, mô tả khác…

  <li>Hóa đơn điện nước</li>

	+Thêm, xóa, sửa, hiển thị thông tin điện nước của các phòng.
	Điện nước, quản lý điện nước cho từng phòng theo từng tháng, lưu trữ 
	tất cả các thông tin điện nước theo từng tháng, chúng ta cũng có thể xem lại
	chỉ số điện nước của phòng trong tháng trước.

 <li>Tìm kiếm</li>

	+Tìm kiếm thông tin sinh viên dựa vào mã sinh viên
	Tìm kiếm giúp ban quản lý có lý lịch sinh viên, hiện trạng của phòng ở một cách nhanh nhất.
	Không tốn nhiều thời gian phải đi tìm mò 1 sinh viên hay 1 phòng trong rất nhiều sinh viên 
	và nhiều phòng, hỗ trợ năng lục làm việc của ban quản lý KTX.

	+Tìm kiếm thông tin sinh viên dựa vào mã sinh viên

<li>In danh sách</li>

	+ Sau khi hoàn thành việc thêm sinh viên mới vô KTX, ban quản lý cũng có
	thể in được danh sách vừa nhập. Việc in danh sách cũng được cập nhật và áp 
	dụng với in chỉ số điện nước.