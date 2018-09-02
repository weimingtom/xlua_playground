/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/30
 * Time: 17:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace UnityEngine
{
	/// <summary>
	/// Description of Object.
	/// </summary>
	public class Object
	{
		public string name;
		
		public Object()
		{
		}
		
		public static void DontDestroyOnLoad(Object target)
		{
			
		}
		
		public static Object Instantiate(Object original)
		{
			return original;
		}
	}
}
