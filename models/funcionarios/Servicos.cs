using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using treino_modelo_faculdade.interfaces;

namespace treino_modelo_faculdade.models;

public class Servicos : FolhaPagamento, IAcademia
{
    private string Nome;
    public Servicos(decimal mensalidade, double porcentagem) : base(mensalidade, porcentagem)
    {
        
    }
    public List<string> Horario()
    {
        return null;
    }

    public string Bloco()
    {
        return "";
    }

    public string Funcao()
    {
        return "";
    }

    public string InformacoesGerais()
    {
        return "";
    }

    public override void ExibirFolhaPagamento(bool fazHoraextra)
    {
        Console.WriteLine($"Estes são os detalhes do pagamento de {Nome}");
        base.ExibirFolhaPagamento(fazHoraextra);
    }
}
