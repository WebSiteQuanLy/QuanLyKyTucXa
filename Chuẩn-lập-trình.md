## CHUẨN LẬP TRÌNH

       Có rât nhiều cách để lập trình, nhưng xong mỗi cách lập trình đều có các chuẩn
lập trình riêng, được xây dựng phù hợp với quy mô hay tính chất của dự án. Và 
dự án này cũng vậy, từ thiết kế đến mã nguồn đều có chuẩn riêng.

## MÃ NGUỒN

Mã nguồn được tổ chức theo 3 lớp: Cách tổ chức là :GUI,BLL,DAL,DTO

Dựa theo CSDL mỗi bảng dự liệu được tạo 1 folder, nhằm lưu trữ những thành phần có
liên quan đến cơ sở dữ liệu của bảng đó, giúp chương trình rõ ràng hơn.

Mỗi lớp sẽ có tên tương ứng với nhiệm vụ là GUI,BLL,DAL hay là DTO.

VD: Folder của bảng SV chứa các class có tên như: SVDAL,SVBLL,....

Sẽ thấy rõ hơn khi nhìn vào code. 


## THIẾT KẾ

Các nút button sẽ mang id bắt đầu là: btn
Các lable sẽ mang id bắt đầu là :lbl
Các textbox sẽ mang id bắt đầu là :txt
Các DataGridView sẽ mang id bắt đầu là: dgv
