using System;

namespace TranportProject
{
	public class Can : Container
	{
		public float diametr { get; set; }
		public void SetDiametr (float newDiam)
        {
			diametr = newDiam;
        }
    }
}