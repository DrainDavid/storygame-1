using System.Security;

Console.WriteLine("Du går in till NTI du ser de nya cafet");
Console.WriteLine("De säljer varm läsk och godis för 18kr");
Console.WriteLine("Du ser en magisk diamant");
Console.WriteLine("Du får välja att pussa den eller ta på den vad väljer du");

string puss = Console.ReadLine().ToLower();

if (puss == "pussa")
{
Console.WriteLine("Du åker tilbaka i tiden och ser sus");    
Console.WriteLine("1. Du går fram till henne  2.du skiter id de och går till makerspace ");

string maker = Console.ReadLine().ToLower();

if (maker == "1")
{
 Console.WriteLine("Du går till sus och får en gratis macka");
 Console.WriteLine("Hon ger dig ett matkort och du drar subwat tc");
 Console.WriteLine("Du är lycklig och glad");
}
else if (maker == "2")
{
Console.WriteLine("Du ser galen grabb där som har tagit cuba");  
Console.WriteLine("Han spyr på dig och du dör");
}
else 
{
Console.WriteLine("va va du skrev fel testa igen");
}
}

else if (puss == "ta på den")
{
Console.WriteLine("Du kommer till framtiden");
Console.WriteLine("Du ser en robot i cafet han säljer godis för 1984kr");
Console.WriteLine("Köper du den eller inte");
string köper = Console.ReadLine().ToLower();
if (köper == "köper")
{
Console.WriteLine("du äter godiset och ser en katt hoppa från skolmaten och han äter up dig");    
}
else if (köper == "inte")
{
Console.WriteLine("Du Köper den inte och går ut från nti");  
Console.WriteLine("Sen går du aldrig tillbaka för NTI är inte lika bra som förr");
}
else 
{
Console.WriteLine("va va du skrev fel testa igen");
}
}

else 
{
Console.WriteLine("va va du skrev fel testa igen");
}
Console.ReadLine();