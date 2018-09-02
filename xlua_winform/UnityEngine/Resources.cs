/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/31
 * Time: 8:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace UnityEngine
{
	/// <summary>
	/// Description of Resources.
	/// </summary>
	public class Resources
	{
		public Resources()
		{
		}
		
		public static Object Load(string path)
		{
			return new TextAsset(path);
		}
	}
}
