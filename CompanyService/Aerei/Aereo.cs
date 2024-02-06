namespace CompanyService;

public class Aereo
{
    public int IdAero { get; set; }
    public string CodiceAereo { get; set; }

     public Aereo(int idAero, string codiceAereo)
    {
        IdAero = idAero;
        CodiceAereo = codiceAereo;
    }
}
