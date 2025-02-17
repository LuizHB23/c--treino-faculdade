using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using treino_modelo_faculdade.interfaces;

namespace treino_modelo_faculdade.models;

public class Discentes : Turmas, IAcademia, IAulas
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