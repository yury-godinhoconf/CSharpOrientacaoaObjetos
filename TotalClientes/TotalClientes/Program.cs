using TotalClientes;

Cliente cliente1 = new Cliente("ABC Construções");
Console.WriteLine("Clientes Novos: "+ Cliente.TotalDeCliente);

Cliente cliente2 = new Cliente("Confitec");
Console.WriteLine("Clientes Novos: " + Cliente.TotalDeCliente);

Cliente cliente3 = new Cliente("Linha 4");
Console.WriteLine("Clientes Novos: " + Cliente.TotalDeCliente);
