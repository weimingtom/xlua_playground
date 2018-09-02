/*

System.InvalidCastException: This type must add to CSharpCallLua: System.Action`1[System.Boolean]
   at Delegate XLua.ObjectTranslator.getDelegate(XLua.DelegateBridgeBase bridge, System.Type delegateType) in e:\sync\xlua\xlua\XLua\Src\ObjectTranslator.cs:line 377
   at Object XLua.ObjectTranslator.CreateDelegateBridge(System.IntPtr L, System.Type delegateType, System.Int32 idx) in e:\sync\xlua\xlua\XLua\Src\ObjectTranslator.cs:line 448
   at Object XLua.ObjectCasters+<>c__DisplayClassf.<genCaster>b__1(System.IntPtr L, System.Int32 idx, System.Object target) in e:\sync\xlua\xlua\XLua\Src\ObjectCasters.cs:line 442
   at Int32 XLua.OverloadMethodWrap.Call(System.IntPtr L) in e:\sync\xlua\xlua\XLua\Src\MethodWarpsCache.cs:line 232
   at Int32 XLua.MethodWrap.Call(System.IntPtr L) in e:\sync\xlua\xlua\XLua\Src\MethodWarpsCache.cs:line 304
   at static Int32 XLua.StaticLuaCallbacks.FixCSFunction(System.IntPtr L) in e:\sync\xlua\xlua\XLua\Src\StaticLuaCallbacks.cs:line 111
   at System.Void XLua.DelegateBridge.__Gen_Delegate_Imp0() in e:\sync\xlua\xlua\XLua\Gen\DelegatesGensBridge.cs:line 32
   at System.Void MessageBox+<>c__DisplayClass1.<ShowAlertBox>b__0() in e:\sync\xlua\xlua\Examples\07_AsyncTest\MessageBox.cs:line 37
   at System.Void xlua.MainForm.loop() in e:\sync\xlua\xlua\MainForm.cs:line 105
   at static System.Void xlua.MainForm.loop(System.Object parent_) in e:\sync\xlua\xlua\MainForm.cs:line 65
   at static System.Void System.Threading.ThreadHelper.ThreadStart_Context(System.Object state)
   at static System.Void System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, System.Object state, System.Boolean preserveSyncCtx)
   at static System.Void System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, System.Object state, System.Boolean preserveSyncCtx)
   at static System.Void System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, System.Object state)
   at System.Void System.Threading.ThreadHelper.ThreadStart(System.Object obj)



*/

/*
 * Tencent is pleased to support the open source community by making xLua available.
 * Copyright (C) 2016 THL A29 Limited, a Tencent company. All rights reserved.
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/

using UnityEngine;
using XLua;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class AsyncTest : MonoBehaviour
{
	public Canvas canvas = new Canvas();
	public Button button = new Button();
	
	public Transform alertBox = new Transform();
	public Transform title = new Transform();
	public Transform message = new Transform();
	public Transform alertBtn = new Transform();
	
	public Transform confirmBox = new Transform();
	public Transform confirmTitle = new Transform();
	public Transform conmessage = new Transform();
	public Transform confirmBtn = new Transform();
	public Transform cancelBtn = new Transform();
	
	public AsyncTest()
	{
		alertBox.gameObject = new GameObject();
		title._component = new Text();
		message._component = new Text();
		alertBtn._component = new Button();

		confirmBox.gameObject = new GameObject();
		confirmTitle._component = new Text();
		conmessage._component = new Text();
		confirmBtn._component = new Button();
		cancelBtn._component = new Button();
	}
	
	
    LuaEnv luaenv = null;
    
    public override void Start()
    {
        luaenv = new LuaEnv();
        luaenv.DoString("require 'Examples/07_AsyncTest/Resources/async_test'");
    }

    // Update is called once per frame
    public override void Update()
    {
        if (luaenv != null)
        {
            luaenv.Tick();
        }
    }
}


