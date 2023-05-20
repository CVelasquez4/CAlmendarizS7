using System;
using System.Collections.Generic;
using System.Text;
using SQLite; //utiliza los metodos del gestor de base de datos

namespace CAlmendarizS7
{
    public interface DataBase
    {
        SQLiteAsyncConnection GetConnection(); //defino el metodo de conexion
    }
}
