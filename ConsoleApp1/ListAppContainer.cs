using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal static class ListAppContainer
	{
		public static void List()
		{
			RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\AppContainer\Mappings");

			string[] subkeyNames = key.GetSubKeyNames();

			foreach (string subkeyName in subkeyNames)
			{
				Console.WriteLine(subkeyName);
				RegistryKey subkey = key.OpenSubKey(subkeyName, true);
				string[] valueNames = subkey.GetValueNames();
				foreach (string valueName in valueNames)
				{
					Console.WriteLine("  {0} = {1}", valueName, subkey.GetValue(valueName));
				}
			}
		}
	}
}