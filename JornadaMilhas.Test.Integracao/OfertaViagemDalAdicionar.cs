using JornadaMilhas.Dados;
using JornadaMilhasV1.Modelos;

namespace JornadaMilhas.Test.Integracao;

public class OfertaViagemDalAdicionar
{
    [Fact]
    public void RegistraOfertaNoBanco()
    {
        //arrange
        Rota rota = new Rota("São Paulo", "Fortaleza");
        Periodo periodo = new Periodo(new DateTime(2024, 8, 20), new DateTime(2024, 8, 30));
        double preco = 350;

        //act
        var oferta = new OfertaViagem(rota, periodo, preco);
        var dal = new OfertaViagemDAL();

        //assert

    }
}