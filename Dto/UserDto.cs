using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sales.Dto
{
    public  class UserDto
    {
        public int Id { get; set; } 
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string Confirm_Password { get; set; } = "";
        public string Profile { get; set; } = "";


    }
}
