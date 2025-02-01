using System.Security.Policy;

namespace momi.Models
{
  public class Utente
  {
    public int UtenteId { get; set; }
    public string Nome { get; set; } = "";
    public string Cognome { get; set; } = "";

    //private  string _fullName = "";
    //public string GetFullName()
    //{
    //  return _fullName;
    //}

    //private string _fullName1 = "";
    //public string FullName1
    //{
    //  get {  return _fullName1; }
    //  set { _fullName1 = value; }
    //}



    //public string SetFullName()
    //{
    //  return $"{UtenteId} {Cognome} {Nome}";
    //}


    public string FullName()
    {
      return $"{UtenteId} {Cognome} {Nome}";
    }
    public override string ToString()
    {
      return FullName();
    }


  }
}
