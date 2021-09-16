namespace LeerData
{
    public class Precio
    {
        public int PrecioId {get;set;}
        public decimal PrecioActual{get;set;}
        public decimal Promocion{get;set;}
        public int CusrsoId{get;set;}
        public Cusrsos cusrsos{get;set;}
    }
}