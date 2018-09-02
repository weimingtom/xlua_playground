/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/22
 * Time: 15:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using xlua;

namespace UnityEngine
{
	/// <summary>
	/// Description of Transform.
	/// </summary>
	public class Transform : Component
	{
		public Vector3 localPosition;
		
		public Transform()
		{
		}
		
		public void Rotate(Vector3 eulers)
		{
			
		}
		
		public Transform Find(string n)
		{
			if (MainForm.global_beh is AsyncTest)
			{
				AsyncTest beh = MainForm.global_beh as AsyncTest;
				if (n.Equals("AlertBox"))
				{
					return beh.alertBox;
				}
				else if (n.Equals("title"))
				{
					return beh.title;
				}
				else if (n.Equals("message"))
				{
					return beh.message;
				}
				else if (n.Equals("alertBtn"))
				{
					return beh.alertBtn;
				}
				else if (n.Equals("ConfirmBox"))
				{
					return beh.confirmBox;
				}
				else if (n.Equals("confirmTitle"))
				{
					return beh.confirmTitle;
				}
				else if (n.Equals("conmessage"))
				{
					return beh.conmessage;
				}
				else if (n.Equals("confirmBtn"))
				{
					return beh.confirmBtn;
				}
				else if (n.Equals("cancelBtn"))
				{
					return beh.cancelBtn;
				}
			}
			return null;
		}
		
		public void SetParent(Transform p)
		{
			
		}
	}
}
