using Microsoft.AspNetCore.Mvc;
using momi.Models;

namespace momi.Controllers
{
  public class Demo2Controller : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public string Esercizio3(int valore)
    {
      // 5! = 5 * 4 * 3 * 2 * 1 * = 120
      long risultato = 1;
      string dettaglioCalcolo = "";
      for (int i = valore; i >= 1; i--)
      {
        risultato *= i;
        dettaglioCalcolo += $"{i} * ";
      }
      if (dettaglioCalcolo.Length > 3)
        dettaglioCalcolo =  dettaglioCalcolo.Substring(0, dettaglioCalcolo.Length - 3);
      return $"{valore}! = {dettaglioCalcolo} = {risultato}";
    }


    public string Esercizio4(int valore)
    {
      // 5! = 5 * 4 * 3 * 2 * 1 * = 120
      long risultato = valore;
      string dettaglioCalcolo = $"{valore}";
      for (int i = valore-1; i >= 1; i--)
      {
        risultato *= i;
        dettaglioCalcolo += $" * {i}";
      }
     
      return $"{valore}! = {dettaglioCalcolo} = {risultato}";
    }

    public IActionResult Esercizio5(int valore)
    {
      DtoFattoriale dto = new DtoFattoriale
      {
        Valore = valore
      };

      int risultato = 1;
      string dettaglioCalcolo = "";
      for (int i = valore; i >= 1; i--)
      {
        risultato *= i;
        dettaglioCalcolo += $"{i} * ";
      }
      if (dettaglioCalcolo.Length > 3)
        dettaglioCalcolo = dettaglioCalcolo.Substring(0, dettaglioCalcolo.Length - 3);

      dto.DettaglioCalcolo = dettaglioCalcolo;
      dto.Risultato = risultato;
      
      return View(dto);
    }

  }
}
