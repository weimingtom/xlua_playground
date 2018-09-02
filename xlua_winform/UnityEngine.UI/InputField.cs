/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/25
 * Time: 11:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace UnityEngine.UI
{
	/// <summary>
	/// Description of IntputField.
	/// </summary>
	public class InputField : GameObject
	{
		public InputField()
		{
			component.text = "InputField is empty";
		}
		
		private Component component = new Component();
	    public override Component GetComponent(string type)
	    {
	    	if (type.Equals("InputField")) {
	    		return component;
	    	}
	    	return base.GetComponent(type);
	    }
	}
}
