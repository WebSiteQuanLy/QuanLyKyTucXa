## PHÂN TÍCH THIẾT KẾ HỆ THỐNG

## KHẢO SÁT THỰC TRẠNG

Hiện nay, quản lý điểm là một công việc hết sức quan trọng đối với các trường học. 
Công việc đó hiện đang còn làm rất thủ công tại một số trường và chính vì thế nó
mang lại hiệu quả không cao. Thực tế, hiện nay trường Tiểu học số 1 Bình Châu 
vẫn đang dùng hệ thống quản lý điểm trên Microsoft Excel. 
Công việc hằng ngày bao gồm:
<ul>
  <li>Nhập điểm cho học sinh, sửa chữa thông tin về điểm</li>
  <li>In bảng điểm, in danh sách học sinh, học sinh có thành tích xuất sắc,…</li>
  <li>Lưu trữ thông tin các bảng điểm của học sinh…</li>

</ul>

## ĐỐI TƯỢNG VÀ PHẠM VI CỦA ỨNG DỤNG

**Đối tượng**
Hệ thống quản lý điểm được xây dựng hướng đến các đối tượng:
<ul>
  <li>Người quản trị hệ thống</li>
  <li>Cán bộ quản lý</li>
  <li>Người dùng </li>

</ul>
**Phạm vi**
**Tên dự án: Website Quản lí điểm Trường tiểu học số 1 Bình Châu**

Phát biểu vấn đề: 

Với số lượng học sinh hàng năm tăng lên không ngừng, Trường tiểu học số 
1 Bình Châu có nhu cầu cải tiến việc tự động lưu trữ, tìm kiếm và in ấn các báo 
cáo nhằm đáp ứng được một khối lượng lớn về xử lí thông tin và tính chính xác 
của thông tin. Sự can thiệp của hệ thống quản lí điểm học sinh sẽ mang đến hiệu 
quả hoạt động cao hơn trong công tác quản lí của trường Trường tiểu học số 1 Bình Châu.

**Mục tiêu**

Cho phép cán bộ quản lí và theo dõi thông tin lí lịch, 
điểm của từng học sinh, môn học một cách chính xác.Tra cứu, thống kê kết quả,...
Đảm bảo cơ sở dữ liệu bảo mật và có độ tin cậy cao.  

**Mô tả**

Hệ thống mới sẽ thu thập tất cả các thông tin về học sinh, 
giáo viên, môn học, điểm…
Lập danh sách, báo biểu…nhằm giúp cho cán bộ quản lí 
nắm rõ thông tin cần thiết.

**Lợi ích mang lại**

<ul>
  <li>Tạo sự tiện dụng, nhanh chóng và thoải mái cho các giáo viên có trách nhiệm quản lí.</li>
  <li>Tự động hóa cho công tác quản lí của trường tạo nên tính chuyên nghiệp cho việc quản lí thông tin</li>
  <li>Tiết kiệm được thời gian và chi phí</li>

</ul>

**Rằng buộc tổng quan hệ thống**

<ul>
  <li>Không ảnh hưởng đến cơ cấu tổ chức và các hệ thống khác của nhà trường</li>
  <li>Website sau khi triển khai phải đáp ứng được nhu cầu tự động 50% số lượng công việc liên quan</li>
  <li>Dữ liệu phải đúng thực tế và phải cập nhật thường xuyên</li>

</ul>

## XÁC ĐỊNH YÊU CẦU

**Yêu cầu chức năng**
<ul>
  <li>Hệ thống phải cập nhập, lưu trữ được tất cả các thông tin chi tiết về học sinh, điểm, danh mục,…</li>
  <li>Cập nhật theo danh mục: giáo viên, học sinh, lớp, môn học,…</li>
  <li>Nhập điểm: Từ giáo viên, điểm thi các môn học</li>
  <li>Tự động xử lý điểm. (Điểm được xử lý theo quy chế của bộ Giáo Dục)</li>
  <li>Cung cấp, tra cứu điểm </li>
</ul>

**Yêu cầu hệ thống**
<ul>
  <li>Hệ thống sử dụng hệ quản trị cơ sở dữ liệu đủ lớn để đáp ứng số lượng học sinh ngày càng tăng</li>
  <li>Máy chủ có khả năng tính toán nhanh, chính xác, lưu trữ lâu dài, bảo mật</li>
  <li>Hệ thống mạng đáp ứng khả năng truy cập lớn</li>
  <li>Đưa ra tổng kết, xếp loại học sinh qua hệ thống, tự động</li>
  <li>Thông tin có tính đồng bộ, phân quyền quản lý chặt chẽ </li>
  <li>Bảo mật tốt cho người quản trị hệ thống </li>
</ul>

## MÔ HÌNH HÓA

**Biểu đồ phân rã chức năng (BFD)**

![y-nghia-hoa-lan-ho-diep-7](https://user-images.githubusercontent.com/27652065/27534843-7c5794bc-5a92-11e7-9680-53c3a7c7800e.jpg)

**Biểu đồ dòng dữ liệu (DFD)**

![9](https://user-images.githubusercontent.com/27652065/27535201-06edeb20-5a94-11e7-933b-0e636c5a0a1b.png)

**Biểu đồ mức 0**

![9 - copy 6](https://user-images.githubusercontent.com/27652065/27535246-3fb4e6d4-5a94-11e7-8673-7007b9276730.png)

	1.   Yêu cầu sử dụng hệ thống	         15. Yêu cầu thống kê, tra cứu
	2.   Truy vấn thông tin hệ thống	 16. Truy vấn TT danh mục
	3.   Trả về thông tin hệ thống	         17. Trả về thông tin danh mục
	4.   Xác nhận sử dụng hệ thống	         18. Truy vấn điểm
	5.   Yêu cầu cập nhâp danh mục	         19. Trả về thông tin điểm
	6.   Truy vấn thông tin danh mục         20. Kết quả thống kê, tra cứu
	7.   Trả về thông tin danh mục	         21. Yêu cầu sử dụng hệ thống
	8.   Danh mục được cập nhập	         22. Xác nhận sử dụng hệ thống
	9.   Yêu cầu xử lý điểm	                 23. Yêu cầu tra cứu
	10. Truy vấn thông tin danh mục          24. Kết quả tra cứu
	11. Trả về thông tin danh mục	         25. Yêu cầu sử dụng hệ thống
	12. Truy vấn thông tin điểm	         26. Xác nhận sử dụng hệ thống
	13. Trả về thông tin điểm	         27. Yêu cầu xử lí điểm
	14. Kết quả xử lý điểm	                 28. Kết quả xử lí điểm





