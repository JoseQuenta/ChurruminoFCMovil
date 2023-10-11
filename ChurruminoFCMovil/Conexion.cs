using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ChurruminoFCMovil
{
    public class Conexion : IDisposable
    {
        private SqlConnection _connection;

        private readonly string _server;
        private readonly string _database;
        private readonly string _userId;
        private readonly string _password;

        public Conexion()
        {
            //_connection = new SqlConnection("Server=tcp:serverejemplo123.database.windows.net,1433;Initial Catalog=MyTestDB;User ID=server123@serverejemplo123;Password=310416Xd;Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            _server = "LOCALHOST";
            _database = "ChurrominoDB";
            _userId = "DESKTOP-FOV8LK6";
            _password = "";

            _connection = new SqlConnection($"Server={_server};Initial Catalog={_database};User ID={_userId};Password={_password};Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public void Abrir()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Cerrar()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return _connection;
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                Cerrar();
                _connection.Dispose();
            }
        }
    }
}
