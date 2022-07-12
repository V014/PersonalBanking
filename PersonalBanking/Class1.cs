using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBanking
{
    class Auth
    {
        public static string GetID()
        {
            var query = "SELECT ID FROM customer WHERE status = 'online'";
            var con = new Connection();
            var result = con.ReadString(query);
            return result;
        }
    }
}
