using Microsoft.AspNetCore.Mvc;
using momi.Models;

namespace momi.Controllers
{
  public class Demo1Controller : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public string Esercizio1(int val1, int val2, int val3, int val4)
    {

      return $"{val1}/{val2} + {val3}/ {val4} = " +
        $"{(val1*1.0m/val2 + val3*1.0m/ val4)}";
    }

    public string Esercizio2(int id, string nome, string cognome)
    {

      Utente u = new Utente()
      {
        UtenteId = id,
        Nome = nome,
        Cognome = cognome,
      };

      //     u.FullName1 = $"{u.Cognome} {u.Nome}";
      ////  u.SetFullName($"{u.Cognome} {u.Nome}");

      ////  string x = u.FullName1;
      ////  x = u.GetFullName();
      return u.FullName();

      return u.ToString();

      
      

    }
  }
}
