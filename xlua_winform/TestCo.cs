/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/30
 * Time: 11:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using UnityEngine;
using System.Collections;
using System.Text;

namespace xlua
{
	/// <summary>
	/// Description of TestCo.
	/// </summary>
	public class TestCo : MonoBehaviour
	{
		public TestCo()
		{
		}
		
		// Use this for initialization
		public override void Start () 
		{
			StartCoroutine(WaitAndPrint());
		}
		
		// Update is called once per frame
		public override void Update () 
		{
		
		}
		
		IEnumerator WaitAndPrint()
	    {
	        // suspend execution for 5 seconds
	        yield return new WaitForSeconds(3);
	        Debug.Log("WaitAndPrint " + Time.time);
	        
//	        WWW www_ = new WWW("http://127.0.0.1");
//	        yield return www_;
//	        Debug.Log("WWW: " + Encoding.UTF8.GetString(www_.bytes));
	    }
	}
}
