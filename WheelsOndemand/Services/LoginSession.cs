using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelsOndemand.Models;

namespace WheelsOndemand.Services
{
    public static class LoginSession
    {
        public static User LoggedInUser { get; set; }
    }
}
