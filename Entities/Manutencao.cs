using  VoeAirline.Entities.Enums;
namespace VoeAirline.Entities{
     public class Manuntecao{
        public Manuntecao(int dateTime, string observacao, TipoManutencao tipo, int aeroNaveId)
        {
            DateTime = dateTime;
            Observacao = observacao;
            Tipo = tipo;
            AeroNaveId = aeroNaveId;
        }

        public int Id { get; set; }
        public int DateTime { get; set; }
        public string Observacao { get; set; }
        public TipoManutencao Tipo { get; set; }
        public int AeroNaveId { get; set; }
        public  AeroNave AeroNave { get; set; }=null!;  
        public ICollection<Voo> Voos { get; set; }=null!;
}
}