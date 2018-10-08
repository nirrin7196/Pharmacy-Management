using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BDConnect
    {
<<<<<<< HEAD
        public SqlConnection _cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Integrated Security=True;Initial Catalog=QUANLYNHATHUOC"); 
||||||| merged common ancestors
        public SqlConnection _cn = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=QUANLYNHATHUOC;Integrated Security=True"); 

=======
        public SqlConnection _cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QUANLYNHATHUOC;Integrated Security=True"); 

>>>>>>> c48813add82012e3453a2ee26d387dfd2ed392c9
    }
}
