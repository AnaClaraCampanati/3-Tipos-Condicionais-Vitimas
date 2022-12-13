//# Condicionais Vítima (a ideia é bem parecida com o de cima)
//-Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:

//“Telefonou para a vítima? “
//“Esteve no local do crime?”
//“Mora perto da vítima? “
//“Devia para a vítima? “
//“Já trabalhou com a vítima? “

//- O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. 
//- Se a pessoa responder positivamente a 2 questões ela deve ser classificada como “Suspeita”, entre 3 e 4 como “Cúmplice” e 5 como “Assassino“. 
//- Caso contrário, ele será classificado como “Inocente“.


Console.WriteLine("Telefonou para a vítima?");
bool telefonouParaAVitima = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Esteve no local do crima?");
bool esteveNoLocalDoCrime = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Mora perto da vítima?");
bool moraPertoDaVitima = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Devia para a vítima?");
bool deviaParaAVitima = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Já trabalhou com a vítima?");
bool jaTrabalhouComAVitima = Convert.ToBoolean(Console.ReadLine());


int quantidadeDeRespostaSim = 0;

if (telefonouParaAVitima)
{
    quantidadeDeRespostaSim++;
}

if (esteveNoLocalDoCrime)
{ 
    quantidadeDeRespostaSim++;
}

if (moraPertoDaVitima)
{ 
    quantidadeDeRespostaSim++;
}

if (deviaParaAVitima)
{
    quantidadeDeRespostaSim++;
}

if (jaTrabalhouComAVitima)
{ 
    quantidadeDeRespostaSim++;
}


if (quantidadeDeRespostaSim <= 2 && quantidadeDeRespostaSim != 0)
{
    Console.WriteLine("Suspeita");
}

if(quantidadeDeRespostaSim>=3 && quantidadeDeRespostaSim<=4)
{
    Console.WriteLine("Cumplice");
}

if (quantidadeDeRespostaSim==5)
{
    Console.WriteLine("Assassino");
}

if (quantidadeDeRespostaSim==0)
{
    Console.WriteLine("Inocente");
}