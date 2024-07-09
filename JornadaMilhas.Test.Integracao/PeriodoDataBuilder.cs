using Bogus;
using JornadaMilhasV1.Modelos;

namespace JornadaMilhas.Test.Integracao;
public class PeriodoDataBuilder : Faker<Periodo>
{
    public DateTime? DataInicial { get; set; }
    public DateTime? DataFinal { get; set; }

    public PeriodoDataBuilder()
    {
       CustomInstantiator(f =>
            {
                DateTime dataInicial = DataInicial ?? f.Date.Soon();
                DateTime dataFinal = DataFinal ?? dataInicial.AddDays(30);
                return new Periodo(dataInicial, dataFinal);
            });
    }

    public Periodo Build() => Generate();

}
