using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace CompanyService;

public class Flotta
{
 
    public List<Aereo> Aerei { get; set; }

       public Flotta(List<Aereo> aerei)
    {
        Aerei = aerei;
    }

    public Aereo? GetAereoById(int idAereo){
        foreach(var c in Aerei){
            if(idAereo==c.IdAero){
                return c;
            }
        }
        return null;
    }

}
