using Data.Entities;
using Data.Repositiry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService
    {
        private readonly UserRepository _data;
        public UserService(UserRepository data)
        {
            _data = data;
        }
    }
}
