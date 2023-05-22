using ContaCorrenteConstrutor;

ContaCorrente conta = new ContaCorrente("Yury", "147.258.369-12", 2563, "12536-Y");

Console.WriteLine("Titular: " + conta.nomeTitular);
Console.WriteLine("CPF: " + conta.cpf);
Console.WriteLine("Agencia: " + conta.numeroAgencia);
Console.WriteLine("Conta: " + conta.conta);