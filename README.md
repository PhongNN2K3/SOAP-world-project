# Kết nối với database
- Sử dụng Microsoft SQL Server

# Các hàm chức năng ở server side
- Đầu tiên kết nối với SQL server qua dòng code:
`private readonly string connectionString = "Data Source=LAPTOP-59U1A9H7\\SQLEXPRESS;Initial Catalog=world;Integrated Security=True";`
- Dùng SqlCommand để truy vấn các cột của các bảng

# Kết quả đạt được ở client side
- Với chức năng lấy tất cả quốc gia, khi click sẽ hiện tất cả tên quốc gia ở listBox:
![image](https://github.com/user-attachments/assets/e94ce35f-ea00-47cd-8da7-638dd56db08d)

- Với chức năng lấy quốc gia theo mã của quốc gia, khi click sẽ hiện kết quả ở messageBox:
![image](https://github.com/user-attachments/assets/793a5bc1-1a55-48c4-90bc-747f58651bc0)

- Với chức năng lấy thành phố theo tên, khi click sẽ hiện kết quả ở messageBox:
![image](https://github.com/user-attachments/assets/416e757b-463c-4abd-91e1-3e51db5a386c)

- Với chức năng lấy thành phố theo mã quốc gia, khi click sẽ hiện kết quả ở listBox:
![image](https://github.com/user-attachments/assets/55be57ac-1a28-4900-8218-fb1103e77e77)
