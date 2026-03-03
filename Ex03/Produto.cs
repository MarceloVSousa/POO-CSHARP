namespace Classe;

public enum TipoPagamento
{
    Avista,
    Prazo
}

class Produto{
    public string Nome {get; private set;}
    public decimal Valor {get; private set;}
    public TipoPagamento Tipo {get; private set;}

    public Produto(string nome, decimal valor, TipoPagamento tipo)
    {
        if(string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("Nome inválido do produto");
        
        if(valor < 0)
            throw new InvalidOperationException("O valor do produto não pode ser menor que 0");
        
        Nome = nome;
        Valor = valor;
        Tipo = tipo;
    }

    public void Comprar()
    {
        if(Tipo == TipoPagamento.Avista && Valor >= 500)
            Valor -=  (Valor * 0.1m);
    }
}