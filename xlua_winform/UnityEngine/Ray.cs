/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/30
 * Time: 8:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace UnityEngine
{
	/// <summary>
	/// Description of Ray.
	/// </summary>
	public struct Ray
	{
		public Vector3 origin;
		public Vector3 direction;
		
		public Ray(Vector3 origin, Vector3 direction)
		{
			this.origin = new Vector3(origin.x, origin.y, origin.z);
			this.direction = new Vector3(direction.x, direction.y, direction.z);
		}
	}
}
