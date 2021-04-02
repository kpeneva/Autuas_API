using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autuas.Dtos
{
    public class UserUpdateDto
    {


        public string Name { get; set; }


        public string Username { get; set; }


        public string Email { get; set; }

        public string OldPassword { get; set; }
        public string NewPassword { get; set; }


    }
}

