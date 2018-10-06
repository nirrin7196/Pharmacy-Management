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
        public SqlConnection _cn = new SqlConnection("Data Source=DESKTOP-MOTGGRV;Integrated Security=True;Initial Catalog=QUANLYNHATHUOC"); 
    }
}
