## Video demo (1 phút 5s)
https://www.youtube.com/watch?v=Xgt3iJ5APsg
## Tên đề tài: Nhà Thuốc Online
## Môn học: Đồ án công nghệ web nâng cao ( 1 tín )
## Thành viên: Trần Mạnh Thế - 0205266
## Công nghệ sử dụng: ASP.NET Web API
## Schema
  <img src="https://i.imgur.com/PYCTlMZ.png" alt="" width="100%">
  
## Cách cấu hình và cài đặt
1. Tải repo về máy
`git clone https://github.com/manhthe647/NhaThuocOnlineNetCore.git`
2. Mở file .sln
3. Chuột phải -> Properties trên Solution 'Nha Thuoc Online'
4. Chọn single startup -> NhaThuocOnline.Data -> Ok
5. Thay đổi các chuỗi kết nối tại appsettings.json 
6. Tại thanh công cụ Visual Studio -> Tools -> Nuget Package Manage -> Package Manager Console
7. Tại cửa sổ Package Manager Console, nhập lệnh ` Add-Migration initDatabase ` ->  ` Update-Database`
8. Chuột phải -> Properties trên Solution 'Nha Thuoc Online' -> Multiple Startup -> Chọn Start cho  WebApi, WebAdmin, webApp
9. Run (Ctrl + F5)
   
