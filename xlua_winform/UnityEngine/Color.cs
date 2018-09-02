/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/22
 * Time: 15:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace UnityEngine
{
	/// <summary>
	/// Description of Color.
	/// </summary>
	public struct Color
	{
		public static Color red = new Color(1, 0, 0, 1);
		
		public float r;
		public float g;
		public float b;
		public float a;
			
		public Color(float r, float g, float b, float a)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}
	}
}
