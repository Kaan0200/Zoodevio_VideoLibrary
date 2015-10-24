/*
 * Accesses and executes direct queries to the Zoodevio database.
 * This is an SQLite database, database.sqlite, located in
 * the Zoodevio installation. 
 */
using System.Data.SQLite;

namespace Zoodevio.DataModel
{
    public static class Database
    {
        // the database filename
        // never changed while Zoodevio is executing
        // in the future, perhaps could be read from an ini or registry key? 
        private const string DATABASE_FILE = "database.sqlite";

        // the SQLite connection. all database access is done through this class
        // so this connection is private.
        private static SQLiteConnection dbConnection = new SQLiteConnection(
            "Data Source=" + DATABASE_FILE + ";Version=3");
        
        // 
        public static string Read(string Table, )


}
}