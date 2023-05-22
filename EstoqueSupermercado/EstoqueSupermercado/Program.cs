using EstoqueSupermercado;

Estoque item = new Estoque();
item.nomeProduto = "Arroz";
item.fabricateProduto = "Camil";
item.codBarras = 45155;
item.valorUnit = 22.59;
item.valorCompra = 15.69;
item.quantidade = 5;

Console.WriteLine("O " + item.nomeProduto + " custa " + item.valorUnit);