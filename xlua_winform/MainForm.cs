/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/21
 * Time: 15:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UnityEngine;
using System.Threading;

namespace xlua
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static MonoBehaviour global_beh = null;
		
		private MonoBehaviour beh = new Helloworld();
//		private MonoBehaviour beh = new LuaBehaviour();
//		private MonoBehaviour beh = new LuaBehaviourUIEvent();
//		private MonoBehaviour beh = new InvokeLua();
//		private MonoBehaviour beh = new XLuaTest.NoGc();
//		private MonoBehaviour beh = new TestCo();
//		private MonoBehaviour beh = new CoroutineTest();
//		private MonoBehaviour beh = new AsyncTest();
//		private MonoBehaviour beh = new HotfixTest();
//		private MonoBehaviour beh = new HotfixTest2();
//		private MonoBehaviour beh = new GenericMethodExample();
//		private MonoBehaviour beh = new SignatureLoaderTest();
//		private MonoBehaviour beh = new XLuaTest.RawObjectTest();
//		private MonoBehaviour beh = new ReImplementInLua();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			global_beh = beh;
		}
		
		private volatile bool stopThread = false;
		private volatile bool click = false;
		private volatile bool click2 = false;
		private volatile bool click3 = false;
		private volatile bool click4 = false;
		public static volatile bool GUI_button = false; 
		private Thread thread = null;
		void MainFormLoad(object sender, EventArgs e)
		{
			if (beh is AsyncTest)
			{
				this.button1.Text = "购买";
				this.button2.Text = "余额不足/充值成功确定";
				this.button3.Text = "充值确定";
				this.button4.Text = "充值取消";
			}
           	thread = new Thread(new ParameterizedThreadStart(loop));
           	thread.Start(this);
		}
		
		private static void loop(object parent_)
        {
			MainForm parent = parent_ as MainForm;
			parent.loop();
		}
		
		public void loop()
		{
			setup();
			
			while (!stopThread)
			{
				MonoBehaviour._listCo.AddRange(MonoBehaviour._listCoReady);
				MonoBehaviour._listCoReady.Clear();
				foreach (Coroutine e in MonoBehaviour._listCo)
				{
					e._next();
				}
				
				update();
				if (click) 
				{
					click = false;
					if (beh is LuaBehaviourUIEvent)
					{
						LuaBehaviourUIEvent beh2 = beh as LuaBehaviourUIEvent;
						Component comp = beh2.button.GetComponent(typeof(UnityEngine.UI.Button));
						comp.onClick._call();
					}
					else if (beh is AsyncTest)
					{
						AsyncTest beh2 = beh as AsyncTest;
						Component comp = beh2.button.GetComponent(typeof(UnityEngine.UI.Button));
						comp.onClick._call();
					}
				}
				if (click2)
				{
					click2 = false;
					if (beh is AsyncTest)
					{
						AsyncTest beh2 = beh as AsyncTest;
						Component comp = ((UnityEngine.UI.Button)beh2.alertBtn._component).GetComponent(typeof(UnityEngine.UI.Button));
						comp.onClick._call();
					}
				}
				if (click3)
				{
					click3 = false;
					if (beh is AsyncTest)
					{
						AsyncTest beh2 = beh as AsyncTest;
						Component comp = ((UnityEngine.UI.Button)beh2.confirmBtn._component).GetComponent(typeof(UnityEngine.UI.Button));
						comp.onClick._call();
					}
				}
				if (click4)
				{
					click4 = false;
					if (beh is AsyncTest)
					{
						AsyncTest beh2 = beh as AsyncTest;
						Component comp = ((UnityEngine.UI.Button)beh2.cancelBtn._component).GetComponent(typeof(UnityEngine.UI.Button));
						comp.onClick._call();
					}
				}
				if (GUI_button)
				{
					GUI_button = false;
				}
				if (beh is HotfixTest)
				{
					Thread.Sleep(10);
				}
				else
				{
					Thread.Sleep(100);
				}
			}
			
            try {
				beh.OnDestroy();
			} catch (Exception ex) {
				System.Diagnostics.Debug.WriteLine("OnDestroy() : " + ex.ToString());
			}
		}
		
		public void setup()
		{
			try {
				beh.Awake();
			} catch (Exception ex) {
				System.Diagnostics.Debug.WriteLine("Awake() : " + ex.ToString());
			}
			
			try {
				beh.Start();
			} catch (Exception ex) {
				System.Diagnostics.Debug.WriteLine("Start() :" + ex.ToString());
			}	
		}
		
		public void update()
        { 
            //this.label1.Text = DateTime.Now.ToString();
            try {
				beh.Update();
			} catch (Exception ex) {
				System.Diagnostics.Debug.WriteLine("Update() : " + ex.ToString());
			}
            try {
				beh.OnGUI();
			} catch (Exception ex) {
				System.Diagnostics.Debug.WriteLine("OnGUI() : " + ex.ToString());
			}
        }
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			stopThread = true;
			thread.Join();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			click = true;
			if (beh is HotfixTest)
			{
				GUI_button = true;
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			click2 = true;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			click3 = true;
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			click4 = true;
		}
	}
}
