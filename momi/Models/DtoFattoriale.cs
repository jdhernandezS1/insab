using System.ComponentModel.DataAnnotations;

namespace momi.Models
{
  public class DtoFattoriale
  {
    public int Valore { get; set; }
    public int Risultato { get; set; }
  public string DettaglioCalcolo { get; set; } = "";

    [DataType(DataType.Date)]
    public DateTime Nascita { get; set; } = DateTime.Now;
    }
}
