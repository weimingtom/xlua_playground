/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/22
 * Time: 15:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using UnityEngine.UI;

namespace UnityEngine
{
	/// <summary>
	/// Description of Component.
	/// </summary>
	public class Component : Object
	{
		public GameObject gameObject;
		
		public Color color = new Color(0, 0, 0, 0);
		public Button.ButtonClickedEvent onClick = new Button.ButtonClickedEvent();
		public string text = "";
		
		public object _component;
		
		public Component()
		{
			
		}
		
		public T GetComponent<T>()
		{
			return (T)_component;
		}
	}
}
