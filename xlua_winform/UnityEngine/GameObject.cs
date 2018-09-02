/*

???
not gen: winform ok, but Unity error

*/

/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/22
 * Time: 14:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using UnityEngine.UI;
using xlua;

namespace UnityEngine
{
	/// <summary>
	/// Description of GameObject.
	/// </summary>
	public class GameObject : Object
	{
		public Transform transform = new Transform();
		
		public GameObject()
		{
		}
		
		public GameObject(string name)
		{
			
		}
		
		public virtual Component GetComponent(Type type)
		{
		 	return null;
		}
		public virtual Component GetComponent(string type)
		{
		 	return null;
		}
		
		public T GetComponent<T>()
		{
			return default(T);
		}
		
		Coroutine_Runner component = new Coroutine_Runner();
		public Component AddComponent(Type componentType)
		{
			if (componentType == typeof(Coroutine_Runner))
		    {
		    	return component;
		    }
			return null;
		}
		
		public static GameObject Find(string name)
		{
			if (MainForm.global_beh is AsyncTest)
			{
				AsyncTest beh = MainForm.global_beh as AsyncTest;
				if (name.Equals("Canvas"))
				{
					return beh.canvas;
				}
				else if (name.Equals("Button"))
				{
					return beh.button;
				}
			}
			return null;
		}
		
		public void SetActive(bool value)
		{
			
		}
	}
}
