using System;
using System.Collections.Generic;
using System.Text;

namespace ExcaMetr_Ver_0._0
{
    public static class CurrentUser
    {
        public static int Id { get; set; }
        public static string Login { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Role { get; set; }
        public static string Email { get; set; }
        public static string PhoneNumber { get; set; }
        public static int IsActive { get; set; }

        public static void Logout()
        {
            Id = 0;
            Login = null;
            FirstName = null;
            LastName = null;
            Role = null;
            Email = null;
            PhoneNumber = null;
            IsActive = 0;
        }
    }
}
