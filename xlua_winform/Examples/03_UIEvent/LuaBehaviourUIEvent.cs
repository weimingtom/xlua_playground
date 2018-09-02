/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/25
 * Time: 11:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Description of LuaBehaviourUIEvent.
/// </summary>
public class LuaBehaviourUIEvent : LuaBehaviour
{
	public InputField input = new InputField();
	public Button button = new Button();
	
	public LuaBehaviourUIEvent()
	{
		luaScript = new TextAsset("Examples/03_UIEvent/ButtonInteraction.lua.txt");
    	injections = new Injection[] {
    		new Injection() {name = "input", value = input}
    	};
	}
	
	public override Component GetComponent(string type)
	{
		if (type.Equals("Button")) {
			return button.GetComponent(typeof(Button));
		}
	 	return null;
	}
}
