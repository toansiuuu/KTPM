using System.Collections.Generic;

namespace DTO
{
    public static class RoleConstants
    {
        public static class Roles
        {
            public const string QuanTriVien = "Quản trị viên";
            public const string QuanLy = "Quản lý";
            public const string ThuThu = "Thủ thư"; 
            public const string NhanVienKho = "Nhân viên kho";

            public static readonly Dictionary<string, (int Min, int Max)> Limits = new Dictionary<string, (int Min, int Max)>
            {
                { QuanTriVien, (1, 1) },    // 1 quản trị viên
                { QuanLy, (1, 3) },         // 1-3 quản lý
                { ThuThu, (1, 1) },         // 1 thủ thư
                { NhanVienKho, (1, 10) }     // 1-3 nhân viên kho
            };
        }
    }
} 