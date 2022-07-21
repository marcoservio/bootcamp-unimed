using jogo_rpg.src.Model;

Knight arus = new Knight("Arus", 42, 469, 749, 72, 72, "Knight");
Ninja wedge = new Ninja("Wedge", 42, 292, 574, 89, 89, "Ninja");
WhiteWizard jennica = new WhiteWizard("Jennica", 42, 325, 601, 472, 482, "White Wizard");
BlackWizard topapa = new BlackWizard("Topapa", 42, 106, 385, 611, 641, "Black Wizard");

Console.WriteLine(arus);
Console.WriteLine(arus.Attack());
Console.WriteLine("-----------------------------");
Console.WriteLine(wedge);
Console.WriteLine(wedge.Attack());
Console.WriteLine("-----------------------------");
Console.WriteLine(jennica);
Console.WriteLine(jennica.Attack());
Console.WriteLine(jennica.Attack(50));
Console.WriteLine("-----------------------------");
Console.WriteLine(topapa);
Console.WriteLine(topapa.Attack());
Console.WriteLine(topapa.Attack(50));