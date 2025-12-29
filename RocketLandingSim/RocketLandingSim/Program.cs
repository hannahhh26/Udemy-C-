string rocket = "  |\r\n / \\\r\n*---*\r\n| o |\r\n| o |\r\n*---*\r\n /_\\";

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine( rocket );
    rocket = "\n" + rocket;
    Thread.Sleep( 500 );
    Console.Clear();
}

Console.WriteLine( rocket );
Console.WriteLine( "Successful landing !" );

Console.ReadKey();