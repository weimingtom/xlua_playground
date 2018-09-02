/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/30
 * Time: 8:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace UnityEngine
{
	/// <summary>
	/// Description of Bounds.
	/// </summary>
	public struct Bounds
	{
		public Vector3 center;
		public Vector3 size;
		public Vector3 extents;
		
		public Bounds(Vector3 center, Vector3 size)
		{
			this.center = new Vector3(center.x, center.y, center.z);
			this.size = new Vector3(size.x, size.y, size.z);
			this.extents = new Vector3(size.x / 2, size.y / 2, size.z / 2);
		}
	}
}
