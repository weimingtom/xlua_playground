/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/25
 * Time: 11:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using UnityEngine;

namespace UnityEngine.UI
{
	/// <summary>
	/// Description of Button.
	/// </summary>
	public class Button : GameObject
	{
		public ButtonClickedEvent onClick
		{
			get
			{
				return this.GetComponent(typeof(UnityEngine.UI.Button)).onClick;
			}
		}
		
		public Button()
		{
		}
		
		private Component component = new Component();
	    public override Component GetComponent(Type type)
	    {
	    	if (type == typeof(Button)) {
	    		return component;
	    	}
	    	return base.GetComponent(type);
	    }
	    public override Component GetComponent(string type)
	    {
	    	if (type.Equals("Button")) {
	    		return component;
	    	}
	    	return base.GetComponent(type);
	    }
	    
	    
	    public class ButtonClickedEvent
	    {
	    	public Events.UnityAction _call;
	    	
		    public void AddListener(Events.UnityAction call)
		    {
		    	_call = call;
		    }

			public void RemoveAllListeners()
			{
				
			}
	    }
	    
	}
}
