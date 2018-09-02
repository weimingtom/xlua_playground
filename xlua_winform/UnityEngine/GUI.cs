/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/31
 * Time: 14:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using xlua;

namespace UnityEngine
{
	/// <summary>
	/// Description of GUI.
	/// </summary>
	public class GUI
	{
		public static GUISkin skin = new GUISkin();
		
		public GUI()
		{
			
		}
		
		public static bool Button(Rect position, string text)
		{
			if (MainForm.global_beh is HotfixTest)
			{
				return MainForm.GUI_button;	
			}
			else
			{
				return false;
			}
		}
		
		public static string TextArea(Rect position, string text, GUIStyle style)
		{
			return text;
		}
	}
}
