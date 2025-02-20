using System;
using System.Collections.Generic;
using System.Linq;
using DTO;

namespace BUS
{
    public class RoleService
    {
        private readonly NhanVienBUS _nhanVienBUS;

        public RoleService()
        {
            _nhanVienBUS = new NhanVienBUS();
        }

        public Dictionary<string, int> GetCurrentRoleCounts()
        {
            var allEmployees = _nhanVienBUS.getAllNhanVien();
            var roles = new[] 
            {
                "Quản trị viên",
                "Quản lý",
                "Thủ thư",
                "Nhân viên kho"
            };
            return roles.ToDictionary(
                role => role,
                role => allEmployees.Count(e => e.ChucVu == role)
            );
        }

        public bool CanAssignRole(string newRole, string currentRole = null)
        {
            var roleCounts = GetCurrentRoleCounts();
            
            // Nếu đang thay đổi role, trừ đi số lượng role hiện tại
            if (!string.IsNullOrEmpty(currentRole))
            {
                roleCounts[currentRole]--;
            }

            // Kiểm tra xem có thể thêm role mới không
            if (!roleCounts.ContainsKey(newRole))
                return false;

            int maxLimit;
            switch (newRole)
            {
                case "Quản trị viên":
                    maxLimit = 1;
                    break;
                case "Quản lý":
                    maxLimit = 3;
                    break;
                case "Thủ thư":
                    maxLimit = 1;
                    break;
                case "Nhân viên kho":
                    maxLimit = 10;
                    break;
                default:
                    return false;
            }

            return roleCounts[newRole] + 1 <= maxLimit;
        }

        public bool ValidateRoleAssignment(string newRole, string currentRole = null)
        {
            var roleCounts = GetCurrentRoleCounts();
            
            // Kiểm tra role hiện tại
            if (!string.IsNullOrEmpty(currentRole))
            {
                if (!roleCounts.ContainsKey(currentRole))
                    return false;

                int currentMin;
                switch (currentRole)
                {
                    case "Quản trị viên":
                    case "Quản lý":
                    case "Thủ thư":
                    case "Nhân viên kho":
                        currentMin = 1;
                        break;
                    default:
                        return false;
                }

                if (roleCounts[currentRole] <= currentMin)
                    return false;

                roleCounts[currentRole]--;
            }

            // Kiểm tra role mới
            if (!roleCounts.ContainsKey(newRole))
                return false;

            int newMin, newMax;
            switch (newRole)
            {
                case "Quản trị viên":
                    newMin = 1;
                    newMax = 1;
                    break;
                case "Quản lý":
                    newMin = 1;
                    newMax = 3;
                    break;
                case "Thủ thư":
                    newMin = 1;
                    newMax = 1;
                    break;
                case "Nhân viên kho":
                    newMin = 1;
                    newMax = 10;
                    break;
                default:
                    return false;
            }

            var newCount = roleCounts[newRole] + 1;
            return newCount >= newMin && newCount <= newMax;
        }

        public List<string> GetAvailableRoles(string currentRole = null)
        {
            var roles = new[] 
            {
                "Quản trị viên",
                "Quản lý", 
                "Thủ thư",
                "Nhân viên kho"
            };
            return roles.Where(role => CanAssignRole(role, currentRole)).ToList();
        }
    }
} 