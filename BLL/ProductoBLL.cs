using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DAL;
using Entidades;

namespace BLL
{
   public class ProductoBLL
    {
        public static Productos Guardar(Productos nuevo)
        {
            Productos retorno = null;
            using (var conn = new Repositorio<Productos>())
            {
                retorno = conn.Guardar(nuevo);
            }
            return retorno;
        }

        public static Productos Buscar(Expression<Func<Productos, bool>> tipo)
        {
            Productos Result = null;
            using (var repositorio = new Repositorio<Productos>())
            {
                Result = repositorio.Buscar(tipo);



            }
            return Result;
        }


        public static bool Mofidicar(Productos criterio)
        {
            bool mod = false;
            using (var db = new Repositorio<Productos>())
            {
                mod = db.Modificar(criterio);
            }

            return mod;

        }

        public static bool Eliminar(Productos existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Productos>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }

        public static List<Productos> GetList(Expression<Func<Productos, bool>> criterio)
        {
            List<Productos> retorno = null;
            using (var conn = new Repositorio<Productos>())
            {
                try
                {
                    retorno = conn.GetList(criterio).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }

        }

        public static List<Productos> GetListTodo()
        {
            List<Productos> retorno = null;
            using (var conn = new Repositorio<Productos>())
            {
                try
                {
                    retorno = conn.GetListTodo().ToList();

                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }

        }
    }
}
