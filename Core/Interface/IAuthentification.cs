using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IAuthentification
    {
       public bool CustomerLogin(string userEmail, string userPassword);
       public void CustomerLogOut();
    }
}
