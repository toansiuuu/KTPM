# Quản lý thư viện

## Tóm tắt dự án

Dự án Quản lý thư viện là một ứng dụng Windows Forms được xây dựng theo kiến trúc 3 lớp (GUI, BUS, DAO). Ứng dụng hỗ trợ quản lý thông tin sách, tác giả, nhân viên, phiếu mượn/trả, phân quyền người dùng và các hoạt động liên quan đến thư viện.

## Cách cài đặt

### Yêu cầu:
- Hệ điều hành: Windows 10 hoặc cao hơn
- Visual Studio (2019/2022)
- .NET Framework (ví dụ: .NET Framework 4.5 hoặc cao hơn)
- SSMS (Microsoft SQL Server Management Studio)

### Hướng dẫn cài đặt:
1. Clone dự án từ kho lưu trữ: git clone https://github.com/toansiuuu/KTPM
2. Mở file solution: `C#Quanlythuvien.sln` bằng Visual Studio.
3. Kiểm tra và cấu hình kết nối cơ sở dữ liệu trong file `DataBaseConnection.cs` bên thư mục DAO (nếu cần).
Cấu hình như hình:
![Cấu hình kết nối SQL Server](https://raw.githubusercontent.com/toansiuuu/KTPM/main/images/cauhinh.png)
4. Import database bằng file QLTV.bacpac vào SSMS.
5. Build giải pháp bằng cách chọn Build -> Build Solution.
6. Chạy ứng dụng bằng cách nhấn F5 (Debug) hoặc chọn Debug -> Start Debugging.

## Hướng dẫn sử dụng

1. Khi chạy ứng dụng, người dùng sẽ được mở trang đăng nhập.
2. Sau khi đăng nhập thành công, giao diện chính sẽ xuất hiện với các chức năng:
   - **Quản lý Sách**: Thêm, sửa, xóa sách; xem danh sách sách.
   - **Quản lý Tác giả**: Quản lý thông tin tác giả, thêm mới, và sửa đổi.
   - **Quản lý Nhân viên**: Quản lý thông tin nhân viên sử dụng hệ thống.
   - **Phiếu Mượn/Trả**: Quản lý các hoạt động mượn và trả sách.
   - **Phân quyền**: Quản lý quyền truy cập và phân quyền người dùng.
   - **Các chức năng bổ sung khác**: Quản lý nhà xuất bản, nhà cung cấp, và các chức năng thư viện khác.
3. Giao diện được thiết kế trực quan với các form tương ứng, giúp thao tác dễ dàng và hiển thị thông tin chi tiết.
4. Đối với sự trợ giúp hay thắc mắc, người dùng có thể liên hệ với quản trị hệ thống qua email đã được cung cấp.

## Kiến trúc dự án

- **GUI**: Chứa các form giao diện người dùng được xây dựng bằng Windows Forms.
- **BUS**: Chứa logic nghiệp vụ của hệ thống, xử lý các yêu cầu từ giao diện.
- **DAO**: Chứa các lớp truy xuất dữ liệu, tương tác với cơ sở dữ liệu.
- Các tệp khác: Các file cấu hình, backup database, và các tài nguyên thiết kế.

## Hướng dẫn phát triển

1. Mỗi chức năng được tách biệt rõ ràng theo từng tầng.
2. Khi cần thay đổi logic nghiệp vụ, hãy cập nhật trong tầng BUS.
3. Khi cập nhật giao diện, chỉnh sửa các file trong GUI (bao gồm các file Designer tương ứng).
4. Kiểm thử tích hợp giữa các tầng trước khi commit mã nguồn.
5. Sử dụng Git để quản lý các thay đổi dự án.

## Cấu hình dự án

Dự án được cấu hình sử dụng file solution `C#Quanlythuvien.sln` và các dự án con cho từng tầng (GUI, BUS, DAO). Đảm bảo các tham chiếu giữa các dự án được cấu hình đúng để tránh lỗi khi build.

## Liên hệ

Nếu bạn có thắc mắc hoặc gặp vấn đề trong quá trình cài đặt, vui lòng liên hệ với nhóm phát triển qua email: zaikaman123@gmail.com 
