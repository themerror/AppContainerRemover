using System.Runtime.InteropServices;
using System.Text;

Console.WriteLine("Hello World!");

[DllImport("Userenv.dll", CharSet = CharSet.Unicode)]
static extern long DeleteAppContainerProfile(StringBuilder appcontainerName);

Console.Write("Enter the name of AppContainer:");
string name = Console.ReadLine();
StringBuilder appcontainer = new StringBuilder(name);
long ret = DeleteAppContainerProfile(appcontainer);
Console.WriteLine(ret);