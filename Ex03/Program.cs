using Classe;

Produto mouse = new Produto("Mouse Redragon", 200m, TipoPagamento.Prazo);
Produto teclado = new Produto("Teclado HyperX", 600m, TipoPagamento.Prazo);
Produto fone = new Produto("Fone Razer", 500m, TipoPagamento.Avista);
Produto monitor = new Produto("Monitor AOC", 1500m, TipoPagamento.Avista);


mouse.Comprar();
Console.WriteLine($"Você comprou {mouse.Nome}, {mouse.Tipo} por R${mouse.Valor}");   
teclado.Comprar();
Console.WriteLine($"Você comprou {teclado.Nome}, {teclado.Tipo} por R${teclado.Valor}");   
fone.Comprar();
Console.WriteLine($"Você comprou {fone.Nome}, {fone.Tipo} por R${fone.Valor}");   
monitor.Comprar();
Console.WriteLine($"Você comprou {monitor.Nome}, {monitor.Tipo} por R${monitor.Valor}");   
