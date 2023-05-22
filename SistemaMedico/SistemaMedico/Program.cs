using SistemaMedico;

CadastroPessoas paciente1 = new CadastroPessoas();
paciente1.nome = "Joãozinho";
paciente1.idade = 28;
paciente1.altura = 1.81;
paciente1.peso = "97 kg";

CadastroPessoas paciente2 = new CadastroPessoas();
paciente2.nome = "Mariazinha";
paciente2.idade = 19;
paciente2.altura = 1.68;
paciente2.peso = "72 kg";

Console.WriteLine("Pessoas que foram cadastradas: \nNome: " + paciente1.nome + "\nSua idade: " + paciente1.idade + "\nSua altura: " + paciente1.altura + "\nSeu peso: " + paciente1.peso);

Console.WriteLine("\nNome: " + paciente2.nome + "\nSua idade: " + paciente2.idade + "\nSua altura: " + paciente2.altura + "\nSeu peso: " + paciente2.peso);