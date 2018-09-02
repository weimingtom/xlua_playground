/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/21
 * Time: 16:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace UnityEngine
{
	/// <summary>
	/// Description of Debug.
	/// </summary>
	public class Debug
	{
		public Debug()
		{
		}
		
		public static void Log(object message)
		{
			System.Diagnostics.Debug.WriteLine(message.ToString());
		}
		
		public static void Log(object message, Object context)
		{
			System.Diagnostics.Debug.WriteLine(message.ToString());
		}
	}
}
