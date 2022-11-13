using System;
namespace TranportProject
{			
	public class BoxOfBottles : Box
	{
		public int BottlesAmount { get; set; }
		public float BottleVolume { get; set; }
		public string ProductName { get; set; }

		public void SetAmount(int newA)
		{
			BottlesAmount = newA;
		}
		public void SetVolume(float newV)
		{
			BottleVolume = newV;
		}
		public void SetName(string newN)
		{
			ProductName = newN;
		}

	}

	
}