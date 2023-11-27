using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Toko_Bangunan_Watumas_Jaya
{
    class koneksi
    {
        SqlConnection con = new SqlConnection ("Data Source=RIEZJ\\SQLEXPRESS01;Initial Catalog=perusahaan2;Integrated Security=True");
    }
}
