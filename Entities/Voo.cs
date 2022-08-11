namespace VoeAirline.Entities{

public class Voo{
        public Voo(string origem, string destino, DateTime dataHoraPartida, DateTime dataHoraChegada, int aeroNaveId, int pilotoId)
        {
            Origem = origem;
            Destino = destino;
            DataHoraPartida = dataHoraPartida;
            DataHoraChegada = dataHoraChegada;
            AeroNaveId = aeroNaveId;
            PilotoId = pilotoId;
        }

        public int Id { get; set; }
public string Origem { get; set; }
public string Destino { get; set; }
public DateTime DataHoraPartida { get; set; }
public DateTime DataHoraChegada { get; set; }
public int AeroNaveId { get; set; }
public int PilotoId { get; set; }
public AeroNave AeroNave { get; set; }=null!;
public Piloto Piloto { get; set; }=null!;
public Cancelamento? Cancelamento { get; set; }
}
}