using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace pcstore_arm
{
    public interface IConnect
    {
        NpgsqlConnection GetConnection();
    }
}
