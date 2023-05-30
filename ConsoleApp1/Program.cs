using ConsoleApp1;
using System.Text;
using static Vanara.PInvoke.UserEnv;

Console.WriteLine("Here are all the AppContainers:");
ListAppContainer.List();

while (true)
{
	Console.WriteLine("Enter Q to quit.");
	Console.Write("Enter the name(Monikor) of AppContainer:");
	string name = Console.ReadLine();
	if (name.ToUpper() == "Q")
	{
		return;
	}
	StringBuilder appcontainer = new StringBuilder(name);
	var ret = DeleteAppContainerProfile(appcontainer.ToString());
	Console.WriteLine(ret);
}