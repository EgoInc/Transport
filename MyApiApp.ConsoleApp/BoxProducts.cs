using System;
namespace TranportProject
{

	public class CandyBox : Box
	{
		public int CandiesAmount { get; set; }
		public string CandiesName { get; set; }

		public void SetAmount(int newA)
		{
			CandiesAmount = newA;
		}
				
		public void SetName(string newN)
		{
			CandiesName = newN;
		}

	}
}
