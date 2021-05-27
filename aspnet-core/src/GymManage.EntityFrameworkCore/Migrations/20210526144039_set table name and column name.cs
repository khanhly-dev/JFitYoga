using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManage.Migrations
{
    public partial class settablenameandcolumnname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Customer_CustomerId",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerInTimeTable_Customer_CustomerId",
                table: "CustomerInTimeTable");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerInTimeTable_TimeTable_TimeTableId",
                table: "CustomerInTimeTable");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeePosition_PositionId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Option_OptionId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Service_ServiceId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInBill_Bill_BillId",
                table: "ProductInBill");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInBill_ProductCategory_ProductCategoryId",
                table: "ProductInBill");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeTable_Employee_employeeId",
                table: "TimeTable");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeTable_SessionWork_SessionId",
                table: "TimeTable");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeTable_TrainingClass_ClassId",
                table: "TimeTable");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingClass_TrainingClassCategory_TrainingClassCategoryId",
                table: "TrainingClass");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingClassCategory_Product_ProductId",
                table: "TrainingClassCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingClassCategory",
                table: "TrainingClassCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingClass",
                table: "TrainingClass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeTable",
                table: "TimeTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SessionWork",
                table: "SessionWork");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Service",
                table: "Service");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInBill",
                table: "ProductInBill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Option",
                table: "Option");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeePosition",
                table: "EmployeePosition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerInTimeTable",
                table: "CustomerInTimeTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bill",
                table: "Bill");

            migrationBuilder.RenameTable(
                name: "TrainingClassCategory",
                newName: "PhanLoaiLopHoc");

            migrationBuilder.RenameTable(
                name: "TrainingClass",
                newName: "LopHoc");

            migrationBuilder.RenameTable(
                name: "TimeTable",
                newName: "LichHoc");

            migrationBuilder.RenameTable(
                name: "SessionWork",
                newName: "Ca");

            migrationBuilder.RenameTable(
                name: "Service",
                newName: "DichVu");

            migrationBuilder.RenameTable(
                name: "ProductInBill",
                newName: "ChiTietHoaDon");

            migrationBuilder.RenameTable(
                name: "ProductCategory",
                newName: "DanhMucSanPham");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "BoMon");

            migrationBuilder.RenameTable(
                name: "Option",
                newName: "GoiThoiHan");

            migrationBuilder.RenameTable(
                name: "EmployeePosition",
                newName: "ChucVu");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "NhanVien");

            migrationBuilder.RenameTable(
                name: "CustomerInTimeTable",
                newName: "KhachHangDangKi");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "KhachHang");

            migrationBuilder.RenameTable(
                name: "Bill",
                newName: "HoaDon");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "PhanLoaiLopHoc",
                newName: "MaBoMon");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PhanLoaiLopHoc",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "PhanLoaiLopHoc",
                newName: "MoTa");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingClassCategory_ProductId",
                table: "PhanLoaiLopHoc",
                newName: "IX_PhanLoaiLopHoc_MaBoMon");

            migrationBuilder.RenameColumn(
                name: "TrainingClassCategoryId",
                table: "LopHoc",
                newName: "MaPhanLoaiLop");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "LopHoc",
                newName: "Ten");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingClass_TrainingClassCategoryId",
                table: "LopHoc",
                newName: "IX_LopHoc_MaPhanLoaiLop");

            migrationBuilder.RenameColumn(
                name: "employeeId",
                table: "LichHoc",
                newName: "MaNhanVien");

            migrationBuilder.RenameColumn(
                name: "SessionId",
                table: "LichHoc",
                newName: "MaCaHoc");

            migrationBuilder.RenameColumn(
                name: "Lesson",
                table: "LichHoc",
                newName: "BaiHoc");

            migrationBuilder.RenameColumn(
                name: "Day",
                table: "LichHoc",
                newName: "Thu");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "LichHoc",
                newName: "Ngay");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "LichHoc",
                newName: "MaLopHoc");

            migrationBuilder.RenameIndex(
                name: "IX_TimeTable_SessionId",
                table: "LichHoc",
                newName: "IX_LichHoc_MaCaHoc");

            migrationBuilder.RenameIndex(
                name: "IX_TimeTable_employeeId",
                table: "LichHoc",
                newName: "IX_LichHoc_MaNhanVien");

            migrationBuilder.RenameIndex(
                name: "IX_TimeTable_ClassId",
                table: "LichHoc",
                newName: "IX_LichHoc_MaLopHoc");

            migrationBuilder.RenameColumn(
                name: "ToTime",
                table: "Ca",
                newName: "ThoiGianKetThuc");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Ca",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "FromTime",
                table: "Ca",
                newName: "ThoiGianBatDau");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "DichVu",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "DichVu",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "ToDate",
                table: "ChiTietHoaDon",
                newName: "NgayKetThuc");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryId",
                table: "ChiTietHoaDon",
                newName: "MaDanhMucSanPham");

            migrationBuilder.RenameColumn(
                name: "FromDate",
                table: "ChiTietHoaDon",
                newName: "NgayBatDau");

            migrationBuilder.RenameColumn(
                name: "BillId",
                table: "ChiTietHoaDon",
                newName: "MaHoaDon");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInBill_ProductCategoryId",
                table: "ChiTietHoaDon",
                newName: "IX_ChiTietHoaDon_MaDanhMucSanPham");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInBill_BillId",
                table: "ChiTietHoaDon",
                newName: "IX_ChiTietHoaDon_MaHoaDon");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "DanhMucSanPham",
                newName: "MaDichVu");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "DanhMucSanPham",
                newName: "MaBoMon");

            migrationBuilder.RenameColumn(
                name: "OptionId",
                table: "DanhMucSanPham",
                newName: "MaGoiThoiHan");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategory_ServiceId",
                table: "DanhMucSanPham",
                newName: "IX_DanhMucSanPham_MaDichVu");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategory_ProductId",
                table: "DanhMucSanPham",
                newName: "IX_DanhMucSanPham_MaBoMon");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategory_OptionId",
                table: "DanhMucSanPham",
                newName: "IX_DanhMucSanPham_MaGoiThoiHan");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "BoMon",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "BoMon",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "GoiThoiHan",
                newName: "DonVi");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "GoiThoiHan",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "GoiThoiHan",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "GoiThoiHan",
                newName: "ChiSo");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ChucVu",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "ChucVu",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "Bonus",
                table: "ChucVu",
                newName: "PhuCap");

            migrationBuilder.RenameColumn(
                name: "BaseSalary",
                table: "ChucVu",
                newName: "LuongCoBan");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "NhanVien",
                newName: "TaiKhoan");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "NhanVien",
                newName: "TrangThai");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "NhanVien",
                newName: "Luong");

            migrationBuilder.RenameColumn(
                name: "PositionId",
                table: "NhanVien",
                newName: "MaChucVu");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "NhanVien",
                newName: "SoDienThoai");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "NhanVien",
                newName: "MatKhau");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "NhanVien",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "FromDate",
                table: "NhanVien",
                newName: "NgayBatDau");

            migrationBuilder.RenameColumn(
                name: "Born",
                table: "NhanVien",
                newName: "NgaySinh");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "NhanVien",
                newName: "DiaChi");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_PositionId",
                table: "NhanVien",
                newName: "IX_NhanVien_MaChucVu");

            migrationBuilder.RenameColumn(
                name: "TimeTableId",
                table: "KhachHangDangKi",
                newName: "MaLichHoc");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "KhachHangDangKi",
                newName: "MaKhachHang");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "KhachHangDangKi",
                newName: "CheckIn");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerInTimeTable_TimeTableId",
                table: "KhachHangDangKi",
                newName: "IX_KhachHangDangKi_MaLichHoc");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerInTimeTable_CustomerId",
                table: "KhachHangDangKi",
                newName: "IX_KhachHangDangKi_MaKhachHang");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "KhachHang",
                newName: "TaiKhoan");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "KhachHang",
                newName: "SoDienThoai");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "KhachHang",
                newName: "MatKhau");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "KhachHang",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "Born",
                table: "KhachHang",
                newName: "NgaySinh");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "KhachHang",
                newName: "DiaChi");

            migrationBuilder.RenameColumn(
                name: "UserCreated",
                table: "HoaDon",
                newName: "NguoiTao");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "HoaDon",
                newName: "ThanhTien");

            migrationBuilder.RenameColumn(
                name: "OriginalPrice",
                table: "HoaDon",
                newName: "TongTien");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "HoaDon",
                newName: "GhiChu");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "HoaDon",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "Discount",
                table: "HoaDon",
                newName: "GiamGia");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "HoaDon",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "HoaDon",
                newName: "MaKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_CustomerId",
                table: "HoaDon",
                newName: "IX_HoaDon_MaKhachHang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhanLoaiLopHoc",
                table: "PhanLoaiLopHoc",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LopHoc",
                table: "LopHoc",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LichHoc",
                table: "LichHoc",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ca",
                table: "Ca",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DichVu",
                table: "DichVu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietHoaDon",
                table: "ChiTietHoaDon",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMucSanPham",
                table: "DanhMucSanPham",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoMon",
                table: "BoMon",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoiThoiHan",
                table: "GoiThoiHan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChucVu",
                table: "ChucVu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHangDangKi",
                table: "KhachHangDangKi",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDon",
                table: "HoaDon",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NgaySinh", "NgayBatDau" },
                values: new object[] { new DateTime(2021, 5, 26, 21, 40, 38, 218, DateTimeKind.Local).AddTicks(1869), new DateTime(2021, 5, 26, 21, 40, 38, 220, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_DanhMucSanPham_MaDanhMucSanPham",
                table: "ChiTietHoaDon",
                column: "MaDanhMucSanPham",
                principalTable: "DanhMucSanPham",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_HoaDon_MaHoaDon",
                table: "ChiTietHoaDon",
                column: "MaHoaDon",
                principalTable: "HoaDon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DanhMucSanPham_BoMon_MaBoMon",
                table: "DanhMucSanPham",
                column: "MaBoMon",
                principalTable: "BoMon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DanhMucSanPham_DichVu_MaDichVu",
                table: "DanhMucSanPham",
                column: "MaDichVu",
                principalTable: "DichVu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DanhMucSanPham_GoiThoiHan_MaGoiThoiHan",
                table: "DanhMucSanPham",
                column: "MaGoiThoiHan",
                principalTable: "GoiThoiHan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_KhachHang_MaKhachHang",
                table: "HoaDon",
                column: "MaKhachHang",
                principalTable: "KhachHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KhachHangDangKi_KhachHang_MaKhachHang",
                table: "KhachHangDangKi",
                column: "MaKhachHang",
                principalTable: "KhachHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KhachHangDangKi_LichHoc_MaLichHoc",
                table: "KhachHangDangKi",
                column: "MaLichHoc",
                principalTable: "LichHoc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LichHoc_Ca_MaCaHoc",
                table: "LichHoc",
                column: "MaCaHoc",
                principalTable: "Ca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LichHoc_LopHoc_MaLopHoc",
                table: "LichHoc",
                column: "MaLopHoc",
                principalTable: "LopHoc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LichHoc_NhanVien_MaNhanVien",
                table: "LichHoc",
                column: "MaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LopHoc_PhanLoaiLopHoc_MaPhanLoaiLop",
                table: "LopHoc",
                column: "MaPhanLoaiLop",
                principalTable: "PhanLoaiLopHoc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_ChucVu_MaChucVu",
                table: "NhanVien",
                column: "MaChucVu",
                principalTable: "ChucVu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhanLoaiLopHoc_BoMon_MaBoMon",
                table: "PhanLoaiLopHoc",
                column: "MaBoMon",
                principalTable: "BoMon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_DanhMucSanPham_MaDanhMucSanPham",
                table: "ChiTietHoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_HoaDon_MaHoaDon",
                table: "ChiTietHoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_DanhMucSanPham_BoMon_MaBoMon",
                table: "DanhMucSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_DanhMucSanPham_DichVu_MaDichVu",
                table: "DanhMucSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_DanhMucSanPham_GoiThoiHan_MaGoiThoiHan",
                table: "DanhMucSanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_KhachHang_MaKhachHang",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_KhachHangDangKi_KhachHang_MaKhachHang",
                table: "KhachHangDangKi");

            migrationBuilder.DropForeignKey(
                name: "FK_KhachHangDangKi_LichHoc_MaLichHoc",
                table: "KhachHangDangKi");

            migrationBuilder.DropForeignKey(
                name: "FK_LichHoc_Ca_MaCaHoc",
                table: "LichHoc");

            migrationBuilder.DropForeignKey(
                name: "FK_LichHoc_LopHoc_MaLopHoc",
                table: "LichHoc");

            migrationBuilder.DropForeignKey(
                name: "FK_LichHoc_NhanVien_MaNhanVien",
                table: "LichHoc");

            migrationBuilder.DropForeignKey(
                name: "FK_LopHoc_PhanLoaiLopHoc_MaPhanLoaiLop",
                table: "LopHoc");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_ChucVu_MaChucVu",
                table: "NhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_PhanLoaiLopHoc_BoMon_MaBoMon",
                table: "PhanLoaiLopHoc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhanLoaiLopHoc",
                table: "PhanLoaiLopHoc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LopHoc",
                table: "LopHoc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LichHoc",
                table: "LichHoc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHangDangKi",
                table: "KhachHangDangKi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDon",
                table: "HoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GoiThoiHan",
                table: "GoiThoiHan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DichVu",
                table: "DichVu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMucSanPham",
                table: "DanhMucSanPham");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChucVu",
                table: "ChucVu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietHoaDon",
                table: "ChiTietHoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ca",
                table: "Ca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoMon",
                table: "BoMon");

            migrationBuilder.RenameTable(
                name: "PhanLoaiLopHoc",
                newName: "TrainingClassCategory");

            migrationBuilder.RenameTable(
                name: "NhanVien",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "LopHoc",
                newName: "TrainingClass");

            migrationBuilder.RenameTable(
                name: "LichHoc",
                newName: "TimeTable");

            migrationBuilder.RenameTable(
                name: "KhachHangDangKi",
                newName: "CustomerInTimeTable");

            migrationBuilder.RenameTable(
                name: "KhachHang",
                newName: "Customer");

            migrationBuilder.RenameTable(
                name: "HoaDon",
                newName: "Bill");

            migrationBuilder.RenameTable(
                name: "GoiThoiHan",
                newName: "Option");

            migrationBuilder.RenameTable(
                name: "DichVu",
                newName: "Service");

            migrationBuilder.RenameTable(
                name: "DanhMucSanPham",
                newName: "ProductCategory");

            migrationBuilder.RenameTable(
                name: "ChucVu",
                newName: "EmployeePosition");

            migrationBuilder.RenameTable(
                name: "ChiTietHoaDon",
                newName: "ProductInBill");

            migrationBuilder.RenameTable(
                name: "Ca",
                newName: "SessionWork");

            migrationBuilder.RenameTable(
                name: "BoMon",
                newName: "Product");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "TrainingClassCategory",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "TrainingClassCategory",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "MaBoMon",
                table: "TrainingClassCategory",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_PhanLoaiLopHoc_MaBoMon",
                table: "TrainingClassCategory",
                newName: "IX_TrainingClassCategory_ProductId");

            migrationBuilder.RenameColumn(
                name: "TrangThai",
                table: "Employee",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "Employee",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "TaiKhoan",
                table: "Employee",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "SoDienThoai",
                table: "Employee",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "NgaySinh",
                table: "Employee",
                newName: "Born");

            migrationBuilder.RenameColumn(
                name: "NgayBatDau",
                table: "Employee",
                newName: "FromDate");

            migrationBuilder.RenameColumn(
                name: "MatKhau",
                table: "Employee",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "MaChucVu",
                table: "Employee",
                newName: "PositionId");

            migrationBuilder.RenameColumn(
                name: "Luong",
                table: "Employee",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "DiaChi",
                table: "Employee",
                newName: "Adress");

            migrationBuilder.RenameIndex(
                name: "IX_NhanVien_MaChucVu",
                table: "Employee",
                newName: "IX_Employee_PositionId");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "TrainingClass",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MaPhanLoaiLop",
                table: "TrainingClass",
                newName: "TrainingClassCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_LopHoc_MaPhanLoaiLop",
                table: "TrainingClass",
                newName: "IX_TrainingClass_TrainingClassCategoryId");

            migrationBuilder.RenameColumn(
                name: "Thu",
                table: "TimeTable",
                newName: "Day");

            migrationBuilder.RenameColumn(
                name: "Ngay",
                table: "TimeTable",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "MaNhanVien",
                table: "TimeTable",
                newName: "employeeId");

            migrationBuilder.RenameColumn(
                name: "MaLopHoc",
                table: "TimeTable",
                newName: "ClassId");

            migrationBuilder.RenameColumn(
                name: "MaCaHoc",
                table: "TimeTable",
                newName: "SessionId");

            migrationBuilder.RenameColumn(
                name: "BaiHoc",
                table: "TimeTable",
                newName: "Lesson");

            migrationBuilder.RenameIndex(
                name: "IX_LichHoc_MaNhanVien",
                table: "TimeTable",
                newName: "IX_TimeTable_employeeId");

            migrationBuilder.RenameIndex(
                name: "IX_LichHoc_MaLopHoc",
                table: "TimeTable",
                newName: "IX_TimeTable_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_LichHoc_MaCaHoc",
                table: "TimeTable",
                newName: "IX_TimeTable_SessionId");

            migrationBuilder.RenameColumn(
                name: "MaLichHoc",
                table: "CustomerInTimeTable",
                newName: "TimeTableId");

            migrationBuilder.RenameColumn(
                name: "MaKhachHang",
                table: "CustomerInTimeTable",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "CheckIn",
                table: "CustomerInTimeTable",
                newName: "Active");

            migrationBuilder.RenameIndex(
                name: "IX_KhachHangDangKi_MaLichHoc",
                table: "CustomerInTimeTable",
                newName: "IX_CustomerInTimeTable_TimeTableId");

            migrationBuilder.RenameIndex(
                name: "IX_KhachHangDangKi_MaKhachHang",
                table: "CustomerInTimeTable",
                newName: "IX_CustomerInTimeTable_CustomerId");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "Customer",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "TaiKhoan",
                table: "Customer",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "SoDienThoai",
                table: "Customer",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "NgaySinh",
                table: "Customer",
                newName: "Born");

            migrationBuilder.RenameColumn(
                name: "MatKhau",
                table: "Customer",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "DiaChi",
                table: "Customer",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "TongTien",
                table: "Bill",
                newName: "OriginalPrice");

            migrationBuilder.RenameColumn(
                name: "ThanhTien",
                table: "Bill",
                newName: "TotalPrice");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "Bill",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NguoiTao",
                table: "Bill",
                newName: "UserCreated");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "Bill",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "MaKhachHang",
                table: "Bill",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "GiamGia",
                table: "Bill",
                newName: "Discount");

            migrationBuilder.RenameColumn(
                name: "GhiChu",
                table: "Bill",
                newName: "Note");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDon_MaKhachHang",
                table: "Bill",
                newName: "IX_Bill_CustomerId");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "Option",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "Option",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "DonVi",
                table: "Option",
                newName: "Unit");

            migrationBuilder.RenameColumn(
                name: "ChiSo",
                table: "Option",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "Service",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "Service",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "MaGoiThoiHan",
                table: "ProductCategory",
                newName: "OptionId");

            migrationBuilder.RenameColumn(
                name: "MaDichVu",
                table: "ProductCategory",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "MaBoMon",
                table: "ProductCategory",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_DanhMucSanPham_MaGoiThoiHan",
                table: "ProductCategory",
                newName: "IX_ProductCategory_OptionId");

            migrationBuilder.RenameIndex(
                name: "IX_DanhMucSanPham_MaDichVu",
                table: "ProductCategory",
                newName: "IX_ProductCategory_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_DanhMucSanPham_MaBoMon",
                table: "ProductCategory",
                newName: "IX_ProductCategory_ProductId");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "EmployeePosition",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PhuCap",
                table: "EmployeePosition",
                newName: "Bonus");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "EmployeePosition",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "LuongCoBan",
                table: "EmployeePosition",
                newName: "BaseSalary");

            migrationBuilder.RenameColumn(
                name: "NgayKetThuc",
                table: "ProductInBill",
                newName: "ToDate");

            migrationBuilder.RenameColumn(
                name: "NgayBatDau",
                table: "ProductInBill",
                newName: "FromDate");

            migrationBuilder.RenameColumn(
                name: "MaHoaDon",
                table: "ProductInBill",
                newName: "BillId");

            migrationBuilder.RenameColumn(
                name: "MaDanhMucSanPham",
                table: "ProductInBill",
                newName: "ProductCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietHoaDon_MaHoaDon",
                table: "ProductInBill",
                newName: "IX_ProductInBill_BillId");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietHoaDon_MaDanhMucSanPham",
                table: "ProductInBill",
                newName: "IX_ProductInBill_ProductCategoryId");

            migrationBuilder.RenameColumn(
                name: "ThoiGianKetThuc",
                table: "SessionWork",
                newName: "ToTime");

            migrationBuilder.RenameColumn(
                name: "ThoiGianBatDau",
                table: "SessionWork",
                newName: "FromTime");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "SessionWork",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "Product",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "Product",
                newName: "Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingClassCategory",
                table: "TrainingClassCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingClass",
                table: "TrainingClass",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeTable",
                table: "TimeTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerInTimeTable",
                table: "CustomerInTimeTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bill",
                table: "Bill",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Option",
                table: "Option",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Service",
                table: "Service",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeePosition",
                table: "EmployeePosition",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInBill",
                table: "ProductInBill",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SessionWork",
                table: "SessionWork",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Born", "FromDate" },
                values: new object[] { new DateTime(2021, 5, 15, 21, 5, 2, 747, DateTimeKind.Local).AddTicks(9849), new DateTime(2021, 5, 15, 21, 5, 2, 748, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Customer_CustomerId",
                table: "Bill",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerInTimeTable_Customer_CustomerId",
                table: "CustomerInTimeTable",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerInTimeTable_TimeTable_TimeTableId",
                table: "CustomerInTimeTable",
                column: "TimeTableId",
                principalTable: "TimeTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeePosition_PositionId",
                table: "Employee",
                column: "PositionId",
                principalTable: "EmployeePosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Option_OptionId",
                table: "ProductCategory",
                column: "OptionId",
                principalTable: "Option",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Service_ServiceId",
                table: "ProductCategory",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInBill_Bill_BillId",
                table: "ProductInBill",
                column: "BillId",
                principalTable: "Bill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInBill_ProductCategory_ProductCategoryId",
                table: "ProductInBill",
                column: "ProductCategoryId",
                principalTable: "ProductCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTable_Employee_employeeId",
                table: "TimeTable",
                column: "employeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTable_SessionWork_SessionId",
                table: "TimeTable",
                column: "SessionId",
                principalTable: "SessionWork",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTable_TrainingClass_ClassId",
                table: "TimeTable",
                column: "ClassId",
                principalTable: "TrainingClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingClass_TrainingClassCategory_TrainingClassCategoryId",
                table: "TrainingClass",
                column: "TrainingClassCategoryId",
                principalTable: "TrainingClassCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingClassCategory_Product_ProductId",
                table: "TrainingClassCategory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
