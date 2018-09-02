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
	/// Description of Ray2D.
	/// </summary>
	public struct Ray2D
	{
		public Vector2 origin;
		public Vector2 direction;
		public Ray2D(Vector2 origin, Vector2 direction)
		{
			this.origin = new Vector2(origin.x, origin.y);
			this.direction = new Vector2(direction.x, direction.y);
		}
	}
}
