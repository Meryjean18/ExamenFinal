using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.Core;
using Examen.Data;

namespace Examen.Logic
{
    public class ExamenBL
    {
        public static List<Prestamo> Listar()
        {
            using (var db = new FinancieraEntities())
            {
                return db.Prestamo.ToList();
            } 
        }

        public static Cliente Buscar(int id)
        {
            using (var db = new FinancieraEntities())
            {
                return db.Cliente.Find(id);
            }
        }
    }
}
