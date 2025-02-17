using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_modelo_faculdade.models;

public class Discentes : FolhaPagamento, IAcademia, IAulas
{
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
}