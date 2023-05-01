using ConsoleApp1.Model;

Console.WriteLine("-----------");
Console.WriteLine("Estacionamento feito em Orientação a Objetos");
Console.WriteLine("-----------");

Console.WriteLine("1- Cadastrar, 2-Altear, 3-Excluir, 4- Exibir");


//Seta o construtor veículo
Veiculo veiculo = new Veiculo(1,"Camaro Amarelo","BUX7788");

//Seta o construtor tarifa
Tarifa tarifa = new Tarifa(1,"12",DateTime.Now);

//Seta o proprietario
Proprietario proprietario = new Proprietario(1,"Renato",veiculo);

//Seta Estacionamento
Estacionamento estacionamento = new Estacionamento(1, "12", true, tarifa);
