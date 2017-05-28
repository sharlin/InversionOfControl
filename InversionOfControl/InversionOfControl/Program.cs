using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(new MySQLDal());
            user.Add();
        }
    }

    public class User
    {
        IDal dal;

        public User(IDal dalService)
        {
            dal = dalService;
        }
        
        public bool IsValid
        {
            get { return true; }
        }

        public void Add()
        {
            if(IsValid)
            {
                dal.Add(this);
            }            
        }
    }

    public interface IDal
    {
        void Add(User user);
    }

    public class MySQLDal : IDal
    {
        public void Add(User user)
        {
            //Here your code
        }
    }

    public class MySqlServerDal : IDal
    {
        public void Add(User user)
        {
            //Here your code
        }
    }
}
