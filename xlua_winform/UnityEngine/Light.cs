/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/22
 * Time: 14:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace UnityEngine
{
	/// <summary>
	/// Description of Light.
	/// </summary>
	public class Light : GameObject
	{
		public Light()
		{
		}
		
		private Component component = new Component();
	    public override Component GetComponent(Type type)
	    {
	    	if (type == typeof(Light)) {
	    		return component;
	    	}
	    	return base.GetComponent(type);
	    }
	}
}
