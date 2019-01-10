void Main()
{
	using( var st = File.OpenRead(@"E:\SWITCH\hekate_ctcaer_4.5\hekate_ctcaer_4.5.bin"))
	{
		Console.WriteLine("Starting");
		Console.WriteLine("====================================");
		byte[] array = new byte[16];
		for(var red = st.Read(array, 0, 16); red > 0; red = st.Read(array, 0, 16))
		{
			string output = "";
			for (int i = 0; i < red; i++)
			{
				output = output + $"0x{array[i]:X2},";
			}
			Console.WriteLine(output);
		}
		
		Console.WriteLine("====================================");
	}
}

// Define other methods and classes here
