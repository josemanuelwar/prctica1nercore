using System.Collections;
using System.Collections.Generic;
namespace LeerData
{
    public class Cusrsos
    {
        public int CusrsosId {get;set;}
        public string Titulo {get; set;}  
        public string Descripcion {get; set;}
        public System.DateTime FechaPublicacion {get; set;} 
        public Precio PrecioPromocion {get;set;}
        public ICollection<Cometario> CometarioLista {get;set;}
        public ICollection<CursoInstructor> InstruccionLinck {get;set;}
    }
}
