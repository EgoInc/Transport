using System;
namespace TranportProject
{
		public class ColdTea : BoxOfBottles
	{
			public string teaType { get; set; }
			public string flavour { get; set; }

			public void SetType(string newT)
			{
				teaType = newT;
			}

			public void SetFlavour(string newF)
			{
				flavour = newF;
			}

		}
		public class Juice : BoxOfBottles
	{
			public string Ingredient { get; set; }
			public string BottleMaterial { get; set; }

			public void SetIngredient(string newI)
					{
						Ingredient = newI;
					}

		public void SetMaterial(string newM)
					{
						BottleMaterial = newM;
					}

}
}