using System;

public class Pessoa 
{
    //estado
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }

    //comportamento
    public int CalcularIdade()
    {
        var dataAtual = DateTime.Now;
        var idade = dataAtual.Year - DataNascimento.Year;

        if(dataAtual < DataNascimento.AddYears(idade)) idade--;

        return idade;
    }
}