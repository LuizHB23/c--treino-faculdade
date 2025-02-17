using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_modelo_faculdade.models;

public interface IAcademia
{
    public List<string> Horario();
    public string Bloco();
    public string Funcao();
    public string InformacoesGerais();
        
}