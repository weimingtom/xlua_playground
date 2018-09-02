/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/21
 * Time: 16:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace UnityEngine
{
	/// <summary>
	/// Description of MonoBehaviour.
	/// </summary>
	public class MonoBehaviour : Component
	{
		public static List<Coroutine> _listCoReady = new List<Coroutine>();
		public static List<Coroutine> _listCo = new List<Coroutine>();
		
		public Transform transform = new Transform();
		
		public MonoBehaviour()
		{
		}		
		public virtual void Awake() {
			
		}
		
		public virtual void Start() {
			
		}
		
		public virtual void Update() {
			
		}
		
		public virtual void OnGUI()
		{
			
		}
		
		public virtual void OnDestroy() {
			
		}
		
		public virtual Component GetComponent(string type)
		{
		 	return null;
		}
		
		public Coroutine StartCoroutine(System.Collections.IEnumerator routine)
		{
			Coroutine result = new Coroutine();
			result._enumerator = routine;
			_listCoReady.Add(result);
			result._next();
			return result;
		}
	}
}
