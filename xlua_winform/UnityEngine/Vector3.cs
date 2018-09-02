/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/22
 * Time: 15:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace UnityEngine
{
	/// <summary>
	/// Description of Vector3.
	/// </summary>
	public struct Vector3
	{
		public static Vector3 up = new Vector3(0, 1, 0);
		
		public float x;
		public float y;
		public float z;
		
		public Vector3(float x, float y, float z)
		{
			this.x = x; 
			this.y = y;
			this.z = z;
		}
		

		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
		}
		
		public static Vector3 operator -(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
		}
		
		
		public static Vector3 operator *(Vector3 a, float d)
		{
			return new Vector3(a.x * d, a.y * d, a.z * d);
		}
		
		public void Set(float newX, float newY, float newZ)
		{
			this.x = newX;
			this.y = newY;
			this.z = newZ;
		}
		
		public static Vector3 Normalize(Vector3 value)
		{
			return value;
		}
	}
}
