## Video demo (1 phút 5s)
https://www.youtube.com/watch?v=Xgt3iJ5APsg
## Giao diện
Trang chính
![image](https://github.com/manhthe647/NhaThuocOnlineNetCore/assets/89081405/d072ff9f-d0df-4876-b753-61f5578af098)
![image](https://github.com/manhthe647/NhaThuocOnlineNetCore/assets/89081405/b14f4698-71f3-4400-a8b9-4ebe0808aa27)
![image](https://github.com/manhthe647/NhaThuocOnlineNetCore/assets/89081405/1c8a0a18-a7fb-4b6e-8bc2-b0bdfa047097)
![image](https://github.com/manhthe647/NhaThuocOnlineNetCore/assets/89081405/dc3453d0-86f6-419a-803d-dca27aeee959)
![image](https://github.com/manhthe647/NhaThuocOnlineNetCore/assets/89081405/c1d580a2-516b-43d9-87ba-b78a75e06b36)
![image](https://github.com/manhthe647/NhaThuocOnlineNetCore/assets/89081405/ddd20bf9-eaf5-4502-a453-d1fe42d65de1)
![image](https://github.com/manhthe647/NhaThuocOnlineNetCore/assets/89081405/8942f1b8-f074-4e2b-a1dc-38902e4b1141)

Quản lý
![image](https://github.com/manhthe647/NhaThuocOnlineNetCore/assets/89081405/f274330f-0fe3-4eb7-8a9f-2a1caf4a9e86)
![image](https://github.com/manhthe647/NhaThuocOnlineNetCore/assets/89081405/04db0162-4542-4e2e-83b5-c3becd72f21e)
![image](https://github.com/manhthe647/NhaThuocOnlineNetCore/assets/89081405/6f2fd4df-bbcf-4ec0-a70c-eccc7033188b)


## Tên đề tài: Nhà Thuốc Online
## Môn học: Đồ án công nghệ web nâng cao ( 1 tín )
## Thành viên: Trần Mạnh Thế - 0205266
## Công nghệ sử dụng: ASP.NET Web API (.NET 6)
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
   
