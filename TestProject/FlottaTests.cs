using CompanyService;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace TestProject;

public class FlottaTests
{
    [Fact]
    public void Test1()
    {
        var aereo = new Aereo(123, "BM123");
        var aereo1 = new Aereo(1265, "BM126");
        var aereo2 = new Aereo(125214, "BM124");
        List<Aereo> aereos= new List<Aereo>();
        aereos.Add(aereo);
        aereos.Add(aereo1);
        aereos.Add(aereo2);
        var Flottas = new Flotta(aereos);
        Assert.Equal(aereo1,Flottas.GetAereoById(1265));

    }
    [Fact]
    public void Test2()
    {

    }

}
