/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/30
 * Time: 8:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace UnityEngine
{
	/// <summary>
	/// Description of Quaternion.
	/// </summary>
	public struct Quaternion
	{
		public float x;
		public float y;
		public float z;
		public float w;
		public Quaternion(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}
	}
}
