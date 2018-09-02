/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/22
 * Time: 14:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;

namespace UnityEngine
{
	/// <summary>
	/// Description of TextAsset.
	/// </summary>
	public class TextAsset : Object
	{
		public string text;
		public byte[] bytes;
		
		public TextAsset(string filename)
		{
			if (!filename.EndsWith(".txt") && File.Exists(filename + ".txt"))
			{
				filename = filename + ".txt";
			}
			else if (!filename.EndsWith(".bytes") && File.Exists(filename + ".bytes"))
			{
				filename = filename + ".bytes";
			}
			text = File.ReadAllText(filename, Encoding.UTF8);
			bytes = Encoding.UTF8.GetBytes(text);
		}
	}
}
