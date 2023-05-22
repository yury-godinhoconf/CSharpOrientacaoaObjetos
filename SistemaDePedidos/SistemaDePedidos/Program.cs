using SistemaDePedidos;


Produto produto1 = new Produto();
produto1.codigoProduto = 1;
produto1.descricao = "Pão, salsicha, purê e vinagrete";
produto1.valorUnitario = 17.00;
produto1.quantidade = 1;

Produto produto2 = new Produto();
produto2.codigoProduto = 2;
produto2.descricao = "Pão, 2 salsicha, purê e vinagrete";
produto2.valorUnitario = 19.00;
produto2.quantidade = 1;

Produto produto3 = new Produto();
produto3.codigoProduto = 3;
produto3.descricao = "Pão, 2 salsicha, purê, vinagrete e bacon";
produto3.valorUnitario = 22.00;
produto3.quantidade = 1;

ItemPedido itemPedido = new ItemPedido();
itemPedido.quantidade = produto1.quantidade + produto2.quantidade + produto3.quantidade;
itemPedido.numeroPedido = 156;
itemPedido.produto1 = produto1;
itemPedido.produto2 = produto2;
itemPedido.produto3 = produto3;


Endereco endereco1 = new Endereco();
endereco1.rua = "Av. Nações Unidas";
endereco1.bairro = "Vila Gertrudes";
endereco1.cidade = "São Paulo";
endereco1.cep = "04794-000";
endereco1.numero = 13797;

Cliente cliente1 = new Cliente();
cliente1.nome = "Roseane";
cliente1.cpf = "258369147";
cliente1.email = "roseane@gmail.com";
cliente1.endereco = endereco1;

Pedido pedido1 = new Pedido();
pedido1.numeroPedido = 156;
pedido1.valorPedido = produto1.valorUnitario + produto2.valorUnitario + produto3.valorUnitario;
pedido1.cliente = cliente1;
pedido1.item = itemPedido;

Console.WriteLine("Cliente: " + cliente1.nome);
Console.WriteLine("CPF: " + cliente1.cpf);
Console.WriteLine("Email: " + cliente1.email);
Console.WriteLine("Endereço: " + cliente1.endereco.rua);
Console.WriteLine("Bairro: " + cliente1.endereco.bairro);
Console.WriteLine("Cidade: " + cliente1.endereco.cidade);
Console.WriteLine("CEP: " + cliente1.endereco.cep);
Console.WriteLine("Número: " + cliente1.endereco.numero);
Console.WriteLine("Descrição Item: " + pedido1.item.produto1.descricao);
Console.WriteLine("Descrição Item: " + pedido1.item.produto2.descricao);
Console.WriteLine("Descrição Item: " + pedido1.item.produto3.descricao);
Console.WriteLine("Valor Pedido: " + pedido1.valorPedido);






