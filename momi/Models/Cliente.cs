namespace momi.Models
{
  public class Cliente
  {
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public string Cognome { get; set; }
        public DateTime? Nascita { get; set; }
    }
}
