using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositiry
{
    public class UserRepository
    {
        private readonly TempArquitechureContext _context;
        public UserRepository(TempArquitechureContext context)
        {
            _context = context;
        }
    }
}
