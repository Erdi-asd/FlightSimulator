using CompanyService;

namespace TestProject;

public class AereoTests
{
    [Fact]
    public void Test1()
    {
        var aereo = new Aereo(123,"BM123");
        Assert.Equal(123, aereo.IdAero);
        Assert.Equal("BM123", aereo.CodiceAereo);

    }

}
