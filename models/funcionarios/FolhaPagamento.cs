using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treino_modelo_faculdade.models;

public abstract class FolhaPagamento
{
    private string nome;
    private decimal mensalidade;
    private double porcentagemHoraExtra;
    private double horaExtra;

    public string Nome 
    {
        get
        {
            return nome;
        }
    }
    public decimal Mensalidade 
    { 
        get
        {
            return mensalidade;
        }
    }

    public double PorcentagemHoraExtra
    {
        get
        {
            return porcentagemHoraExtra;
        }
    }

    public double HoraExtra
    {
        get
        {
            return horaExtra;
        }
        set
        {
            horaExtra = value;
        }
    }

    public FolhaPagamento(string nomeDaPessoa, decimal valorMensalidade, double porcentagem)
    {
        nome = nomeDaPessoa;
        mensalidade = valorMensalidade;
        porcentagemHoraExtra = porcentagem;
        horaExtra = 0;
    }

    public void ReajusteSalarial(decimal novoValor)
    {
        if(novoValor > 0)
            mensalidade = novoValor;
        else
            Console.WriteLine("Valor inválido");
    }

    public decimal ValorTotal()
    {
        decimal total = mensalidade + (decimal)(porcentagemHoraExtra*horaExtra);
        return total;
    }

    public virtual void ExibirFolhaPagamento(bool fazHoraextra)
    {
        string texto = string.Empty;
        if(fazHoraextra)
            texto = $"- Mensalidade : {mensalidade} \n - Hora extra: {horaExtra} \n - Porcentagem hora extra {porcentagemHoraExtra} \n - Total: {ValorTotal()}";
        else
            texto = $"- Mensalidade : {mensalidade}";

        Console.WriteLine(texto);
    }
}