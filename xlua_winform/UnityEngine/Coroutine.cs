/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/30
 * Time: 12:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;

namespace UnityEngine
{
	/// <summary>
	/// Description of Coroutine.
	/// </summary>
	public class Coroutine
	{
		public System.Collections.IEnumerator _enumerator;
		public int _skipMilli = 0;
		public long _startTick = 0;
		public WWW _www = null;
		
		public void _next()
		{			
			if (_www != null)
			{
				if (!_www._requestEnd)
				{
					return; //wait
				}
				else 
				{
					_www = null;
				}
			}
			if (_skipMilli != 0)
			{
				TimeSpan elapsedSpan = new TimeSpan(DateTime.Now.Ticks - _startTick);
				if (elapsedSpan.TotalMilliseconds < _skipMilli)
				{
					return; //wait
				}
				else
				{
					_skipMilli = 0; //WaitForSeconds over
				}
			}
			if (_enumerator.MoveNext())
			{
				object o = _enumerator.Current;
				if (o is WaitForSeconds)
				{
//						Debug.Log("o is WaitForSeconds");
					float seconds = ((WaitForSeconds)o)._seconds;
					_skipMilli = (int)(seconds * 1000);
					_startTick = DateTime.Now.Ticks;
				}
				else if (o is WWW)
				{
					string url = ((WWW)o).url;
					_www = (WWW)o;
					_www._request();
				}
			}
		}
		
		
		public Coroutine()
		{
			
		}
	}
}
