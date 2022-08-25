using bytebank;


Console.WriteLine("Boas Vindas ao seu banco, ByteBank");

contacorrente conta1 = new contacorrente();
conta1.titular = "Andre Silva";
conta1.conta = "10123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 100;

contacorrente conta2 = new contacorrente();
conta2.titular = "João Ribeiro";
conta2.conta = "10124-X";
conta2.numero_agencia = 24;
conta2.nome_agencia = "Agencia Sudeste";
conta2.saldo = 1562.02;

Produto produto1 = new Produto();
produto1.nome = "Calça Jeans";
produto1.fabricante = "C&A";
produto1.codigoDeBarra = "145236987";
produto1.valorUnitario = 10.55;
produto1.valorDeCompra = 05.45;
produto1.quantidadeEmEstoque = 22;



Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Numero Agencia: " + conta1.numero_agencia);
Console.WriteLine("Nome Agencia: " + conta1.nome_agencia);
Console.WriteLine("Saldo: " + conta1.saldo);

Console.WriteLine();

Console.WriteLine("Titular: " + conta2.titular);
Console.WriteLine("Conta: " + conta2.conta);
Console.WriteLine("Numero Agencia: " + conta2.numero_agencia);
Console.WriteLine("Nome Agencia: " + conta2.nome_agencia);
Console.WriteLine("Saldo: " + conta2.saldo);

Console.WriteLine();

Console.WriteLine("Nome: " + produto1.nome);
Console.WriteLine("Fabricante: " + produto1.fabricante);
Console.WriteLine("Codigo de Barras: " + produto1.codigoDeBarra);
Console.WriteLine("Valor Unitario: " + produto1.valorUnitario);
Console.WriteLine("Valor de Compra: " + produto1.valorDeCompra);
Console.WriteLine("Quantidade em Estoque: " + produto1.nome);


Console.ReadKey();
