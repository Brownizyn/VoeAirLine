namespace VoeAirline.Entities{

public class Cancelamento{
        public Cancelamento(string motivo, DateTime dataHoraNotificacoa)
        {
            Motivo = motivo;
            DataHoraNotificacoa = dataHoraNotificacoa;
        }

        public int Id { get; set; }
public string Motivo { get; set; }
public DateTime DataHoraNotificacoa { get; set; }
public Voo Voo { get; set; }=null!;

}
}