using System;
using System.Collections.Generic;
using System.Text;

namespace FinalMobileProject
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
