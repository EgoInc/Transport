using System;

namespace TranportProject
{
	public class Box : Container
	{
		public float length { get; set; }
		public float width { get; set; }

		public void SetLength(float newL)
		{
			length = newL;
		}

		public void SetWidth(float newW)
		{
			width = newW;
		}
	}
}
