using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola jose manuel sanchez juarez");

            using (var db = new AppVentasCursosContext())
            {


                var cursos = db.Cusrsos.Include(p => p.InstruccionLinck).ThenInclude(ci => ci.Instruccion);

                //Console.WriteLine(cursos);
                foreach (var curso in cursos)
                {
                     Console.WriteLine(curso.Titulo);

                    foreach (var instlink in curso.InstruccionLinck)
                    {
                        Console.WriteLine("*********** "+instlink.Instruccion.Nombre);
                        
                    }
                    
                }

                // var cursos = db.Cusrsos.Include(p => p.CometarioLista).AsNoTracking();

                // foreach (var curso in cursos)
                // {
                //      Console.WriteLine(curso.Titulo);
                //      foreach (var cometario in curso.CometarioLista)
                //      {
                //         Console.WriteLine("*******"+ cometario.CometarioTexto);   
                //      }
                // }



                // var cursos = db.Cusrsos.Include(p => p.PrecioPromocion).AsNoTracking();

                // foreach (var item in cursos)
                // {
                //     Console.WriteLine(item.Titulo+"------"+item.PrecioPromocion.PrecioActual);
                    
                // }
                // var cursos = db.cusrsos.AsNoTracking();
                // // Console.ReadLine(cursos);
                // foreach (var curso in cursos)
                // {
                //      Console.WriteLine(curso.Titulo+"------"+curso.Descripcion);   
                // }    
            }
        }
    }
}
