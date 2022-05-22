using bytebank;
using bytebank.Titular;

Console.WriteLine("Bem vindo ao seu banco!!");

//ContaCorrente conta1 = new ContaCorrente();

//conta1.titular = "Leozin da Verdinha";
//conta1.conta = "10123-x";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agencia Central";
//conta1.saldo = 9500.46;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Amanda Nogueira";
//conta2.conta = "10106-X";
//conta2.numero_agencia = 321;
//conta2.nome_agencia = "Agência Central";
//conta2.saldo = 1000;

//conta1.ExibirDadosDaConta();

//Cliente cliente = new Cliente();
//cliente.Proffissao = "programador";
//cliente.Nome = "Leozin do C#";
//cliente.CPF = "Fake CPF";

//ContaCorrente conta3 = new ContaCorrente(32, "0000");
//conta3.Titular = cliente;
//conta3.Nome_Agencia = "Central";


//Ao criar uma classe, e atribuir propriedades a ela, temos valores padrões quando não os definimos

//Console.WriteLine("Saldo da Amanda: " + conta2.saldo);
//Console.WriteLine("Saldo do Leozin: " + conta1.saldo);

//bool transferencia = conta1.Transferir(450, conta2);
//Console.WriteLine("Transferncia com sucesso:  " + transferencia);

//Console.WriteLine("Saldo da Amanda: " + conta2.saldo);
//Console.WriteLine("Saldo do Leozin: " + conta1.saldo);

ContaCorrente conta5 = new ContaCorrente(123, "000001");
ContaCorrente conta6 = new ContaCorrente(768, "000011");

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
Console.ReadKey();