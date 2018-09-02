/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/30
 * Time: 13:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;
using System.Web;
using System.Text;
using System.IO;
using System.Collections.Specialized;
using System.Threading;

namespace UnityEngine
{
	/// <summary>
	/// Description of WWW.
	/// </summary>
	public class WWW
	{
		public volatile bool _requestEnd = false;
		
		public string url;
		public byte[] bytes;
		public string error;
		
		public WWW(string url)
		{
			this.url = url;
		}
		
		private Thread thread;
		public void _request()
		{
			thread = new Thread(new ParameterizedThreadStart(_loop));
           	thread.Start(this);
		}
		
		private static void _loop(object parent_)
        {
			WWW parent = parent_ as WWW;
			parent._loop();
		}
		
		private void _loop()
		{
			string result = _GetData(this.url, out this.error);
			this.bytes = Encoding.UTF8.GetBytes(result);
			_requestEnd = true;
		}
		
		public static string _GetData(string MsgUrl, out string error)
        {
			error = null;
			try 
			{
	            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(MsgUrl);
	            req.Method = "GET";
	            req.KeepAlive = true;
	            req.Timeout = 5000; //FIXME:
	            req.ReadWriteTimeout = 5000;
	            req.AllowAutoRedirect = true;
	            req.ContentType = "text/html";
	            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
	            using (Stream rspStream = rsp.GetResponseStream())
	            {
	                StreamReader reader = new StreamReader(rspStream, Encoding.UTF8);
	                string rt = reader.ReadToEnd();
					return rt;
	            }
			}
			catch (Exception e)
			{
				error = e.Message;
			}
			return null;
        }
	}
}
