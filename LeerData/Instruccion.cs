using System.Collections.Generic;

namespace LeerData
{
    public class Instruccion
    {
        public int InstruccionId {get;set;}
        public string Nombre {get;set;}
        public string Apellido {get; set;} 
        public string Grado {get; set;}
        public byte[] FotoPerfil {get;set;}
        public ICollection<CursoInstructor> cursoLinck {get;set;}
    }
}