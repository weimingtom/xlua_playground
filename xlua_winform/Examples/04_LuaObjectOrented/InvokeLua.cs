/*
-------------------------
(3) LuaTable different luaReference:
LUA: hi	john
sum(*10) =30
sum(*100)=300
list[0]=aaaa
list[1]=bbbb
LUA: add	System.EventHandler`1[PropertyChangedEventArgs]: 27836922
table :13 has property changed 1=dddd 
list[1]=dddd
LUA: remove	System.EventHandler`1[PropertyChangedEventArgs]: 27836922
list[1]=eeee


table :13 has property changed 1=dddd 
->Unity is diff
table :14 has property changed 1=dddd
UnityEngine.Debug:Log(Object)
InvokeLua:Notify(Object, PropertyChangedEventArgs) (at Assets/Examples/04_LuaObjectOrented/InvokeLua.cs:118)
System.Reflection.MethodBase:Invoke(Object, Object[])
XLua.OverloadMethodWrap:Call(IntPtr) (at Assets/XLua/Src/MethodWarpsCache.cs:242)
XLua.MethodWrap:Call(IntPtr) (at Assets/XLua/Src/MethodWarpsCache.cs:297)
XLua.StaticLuaCallbacks:DelegateCall(IntPtr) (at Assets/XLua/Src/StaticLuaCallbacks.cs:150)
XLua.LuaDLL.Lua:lua_pcall(IntPtr, Int32, Int32, Int32)
XLua.CSObjectWrap.InvokeLuaICalcBridge:set_Item(Int32, Object) (at Assets/XLua/Gen/InvokeLuaICalcBridge.c

------------------------------------
(2)
XLuaGenAutoRegister.cs->InvokeLuaICalcBridge.cs

ObjectTranslator.cs
AddInterfaceBridgeCreator

System.InvalidCastException: This type must add to CSharpCallLua: InvokeLua+ICalc
   at Type XLua.CodeEmit.EmitInterfaceImpl(System.Type to_be_impl) in e:\sync\xlua\xlua\XLua\Src\CodeEmit.cs:line 393
   at Object XLua.ObjectTranslator.CreateInterfaceBridge(System.IntPtr L, System.Type interfaceType, System.Int32 idx) in e:\sync\xlua\xlua\XLua\Src\ObjectTranslator.cs:line 514
   at Object XLua.ObjectCasters+<>c__DisplayClassf.<genCaster>b__3(System.IntPtr L, System.Int32 idx, System.Object target) in e:\sync\xlua\xlua\XLua\Src\ObjectCasters.cs:line 471
   at Object XLua.ObjectTranslator.GetObject(System.IntPtr L, System.Int32 index, System.Type type) in e:\sync\xlua\xlua\XLua\Src\ObjectTranslator.cs:line 806
   at ICalc XLua.DelegateBridge.__Gen_Delegate_Imp4(System.Int32 p0, System.String[] p1) in e:\sync\xlua\xlua\XLua\Gen\DelegatesGensBridge.cs:line 147
   at System.Void InvokeLua.Test(XLua.LuaEnv luaenv) in e:\sync\xlua\xlua\Examples\04_LuaObjectOrented\InvokeLua.cs:line 140
   at System.Void InvokeLua.Start() in e:\sync\xlua\xlua\Examples\04_LuaObjectOrented\InvokeLua.cs:line 132
   at System.Void xlua.MainForm.MainFormLoad(System.Object sender, System.EventArgs e) in e:\sync\xlua\xlua\MainForm.cs:line 49
   at System.Void System.Windows.Forms.Form.OnLoad(System.EventArgs e)
   at System.Void System.Windows.Forms.Form.OnCreateControl()
   at System.Void System.Windows.Forms.Control.CreateControl(System.Boolean fIgnoreVisible)
   at System.Void System.Windows.Forms.Control.CreateControl()
   at System.Void System.Windows.Forms.Control.WmShowWindow(System.Windows.Forms.Message m)
   at System.Void System.Windows.Forms.Control.WndProc(System.Windows.Forms.Message m)
   at System.Void System.Windows.Forms.ScrollableControl.WndProc(System.Windows.Forms.Message m)
   at System.Void System.Windows.Forms.Form.WmShowWindow(System.Windows.Forms.Message m)
   at System.Void System.Windows.Forms.Form.WndProc(System.Windows.Forms.Message m)
   at System.Void System.Windows.Forms.Control+ControlNativeWindow.OnMessage(System.Windows.Forms.Message m)
   at System.Void System.Windows.Forms.Control+ControlNativeWindow.WndProc(System.Windows.Forms.Message m)
   at IntPtr System.Windows.Forms.NativeWindow.DebuggableCallback(System.IntPtr hWnd, System.Int32 msg, System.IntPtr wparam, System.IntPtr lparam)
   at System.Void System.Windows.Forms.Control.SetVisibleCore(System.Boolean value)
   at System.Void System.Windows.Forms.Form.SetVisibleCore(System.Boolean value)
   at System.Void System.Windows.Forms.Control.set_Visible(System.Boolean value)
   at System.Void System.Windows.Forms.Application+ThreadContext.RunMessageLoopInner(System.Int32 reason, System.Windows.Forms.ApplicationContext context)
   at System.Void System.Windows.Forms.Application+ThreadContext.RunMessageLoop(System.Int32 reason, System.Windows.Forms.ApplicationContext context)
   at static System.Void System.Windows.Forms.Application.Run(System.Windows.Forms.Form mainForm)
   at static System.Void xlua.Program.Main(System.String[] args) in e:\sync\xlua\xlua\Program.cs:line 27




----------------------------
(1)

InvalidCastException: This type must add to CSharpCallLua: InvokeLua+CalcNew
XLua.ObjectTranslator.getDelegate (XLua.DelegateBridgeBase bridge, System.Type delegateType) (at Assets/XLua/Src/ObjectTranslator.cs:376)
XLua.ObjectTranslator.CreateDelegateBridge (IntPtr L, System.Type delegateType, Int32 idx) (at Assets/XLua/Src/ObjectTranslator.cs:447)


System.InvalidCastException: This type must add to CSharpCallLua: InvokeLua+CalcNew
   at Delegate XLua.ObjectTranslator.getDelegate(XLua.DelegateBridgeBase bridge, System.Type delegateType) in e:\sync\xlua\xlua\XLua\Src\ObjectTranslator.cs:line 376
   at Object XLua.ObjectTranslator.CreateDelegateBridge(System.IntPtr L, System.Type delegateType, System.Int32 idx) in e:\sync\xlua\xlua\XLua\Src\ObjectTranslator.cs:line 447
   at Object XLua.ObjectCasters+<>c__DisplayClassf.<genCaster>b__1(System.IntPtr L, System.Int32 idx, System.Object target) in e:\sync\xlua\xlua\XLua\Src\ObjectCasters.cs:line 442
   at Object XLua.ObjectTranslator.GetObject(System.IntPtr L, System.Int32 index, System.Type type) in e:\sync\xlua\xlua\XLua\Src\ObjectTranslator.cs:line 805
   at System.Void XLua.ObjectTranslator.Get(System.IntPtr L, System.Int32 index, System.Object v) in e:\sync\xlua\xlua\XLua\Src\ObjectTranslator.cs:line 818
   at Object XLua.LuaTable.GetInPath(System.String path) in e:\sync\xlua\xlua\XLua\Src\LuaTable.cs:line 156
   at System.Void InvokeLua.Test(XLua.LuaEnv luaenv) in e:\sync\xlua\xlua\Examples\04_LuaObjectOrented\InvokeLua.cs:line 97
   at System.Void InvokeLua.Start() in e:\sync\xlua\xlua\Examples\04_LuaObjectOrented\InvokeLua.cs:line 90
   at System.Void xlua.MainForm.MainFormLoad(System.Object sender, System.EventArgs e) in e:\sync\xlua\xlua\MainForm.cs:line 49
   at System.Void System.Windows.Forms.Form.OnLoad(System.EventArgs e)
   at System.Void System.Windows.Forms.Form.OnCreateControl()
   at System.Void System.Windows.Forms.Control.CreateControl(System.Boolean fIgnoreVisible)
   at System.Void System.Windows.Forms.Control.CreateControl()
   at System.Void System.Windows.Forms.Control.WmShowWindow(System.Windows.Forms.Message m)
   at System.Void System.Windows.Forms.Control.WndProc(System.Windows.Forms.Message m)
   at System.Void System.Windows.Forms.ScrollableControl.WndProc(System.Windows.Forms.Message m)
   at System.Void System.Windows.Forms.Form.WmShowWindow(System.Windows.Forms.Message m)
   at System.Void System.Windows.Forms.Form.WndProc(System.Windows.Forms.Message m)
   at System.Void System.Windows.Forms.Control+ControlNativeWindow.OnMessage(System.Windows.Forms.Message m)
   at System.Void System.Windows.Forms.Control+ControlNativeWindow.WndProc(System.Windows.Forms.Message m)
   at IntPtr System.Windows.Forms.NativeWindow.DebuggableCallback(System.IntPtr hWnd, System.Int32 msg, System.IntPtr wparam, System.IntPtr lparam)
   at System.Void System.Windows.Forms.Control.SetVisibleCore(System.Boolean value)
   at System.Void System.Windows.Forms.Form.SetVisibleCore(System.Boolean value)
   at System.Void System.Windows.Forms.Control.set_Visible(System.Boolean value)
   at System.Void System.Windows.Forms.Application+ThreadContext.RunMessageLoopInner(System.Int32 reason, System.Windows.Forms.ApplicationContext context)
   at System.Void System.Windows.Forms.Application+ThreadContext.RunMessageLoop(System.Int32 reason, System.Windows.Forms.ApplicationContext context)
   at static System.Void System.Windows.Forms.Application.Run(System.Windows.Forms.Form mainForm)
   at static System.Void xlua.Program.Main(System.String[] args) in e:\sync\xlua\xlua\Program.cs:line 27

*/

/*
 * Tencent is pleased to support the open source community by making xLua available.
 * Copyright (C) 2016 THL A29 Limited, a Tencent company. All rights reserved.
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/

using System;
using UnityEngine;
using XLua;

public class PropertyChangedEventArgs : EventArgs
{
    public string name;
    public object value;
}

public class InvokeLua : MonoBehaviour
{
    [CSharpCallLua]
    public interface ICalc
    {
        event EventHandler<PropertyChangedEventArgs> PropertyChanged;

        int Add(int a, int b);
        int Mult { get; set; }

        object this[int index] { get; set; }
    }

    [CSharpCallLua]
    public delegate ICalc CalcNew(int mult, params string[] args);

    private string script = @"
                local calc_mt = {
                    __index = {
                        Add = function(self, a, b)
                            return (a + b) * self.Mult
                        end,
                        
                        get_Item = function(self, index)
                            return self.list[index + 1]
                        end,

                        set_Item = function(self, index, value)
                            self.list[index + 1] = value
                            self:notify({name = index, value = value})
                        end,
                        
                        add_PropertyChanged = function(self, delegate)
	                        if self.notifylist == nil then
		                        self.notifylist = {}
	                        end
	                        table.insert(self.notifylist, delegate)
                            print('add',delegate)
                        end,
                                                
                        remove_PropertyChanged = function(self, delegate)
                            for i=1, #self.notifylist do
		                        if CS.System.Object.Equals(self.notifylist[i], delegate) then
			                        table.remove(self.notifylist, i)
			                        break
		                        end
	                        end
                            print('remove', delegate)
                        end,

                        notify = function(self, evt)
	                        if self.notifylist ~= nil then
		                        for i=1, #self.notifylist do
			                        self.notifylist[i](self, evt)
		                        end
	                        end	
                        end,
                    }
                }

                Calc = {
	                New = function (mult, ...)
                        print(...)
                        return setmetatable({Mult = mult, list = {'aaaa','bbbb','cccc'}}, calc_mt)
                    end
                }
	        ";
    // Use this for initialization
    public override void Start()
    {
        LuaEnv luaenv = new LuaEnv();
        Test(luaenv);//调用了带可变参数的delegate，函数结束都不会释放delegate，即使置空并调用GC
        luaenv.Dispose();
    }

    void Test(LuaEnv luaenv)
    {
        luaenv.DoString(script);
        CalcNew calc_new = luaenv.Global.GetInPath<CalcNew>("Calc.New");
        ICalc calc = calc_new(10, "hi", "john"); //constructor
        Debug.Log("sum(*10) =" + calc.Add(1, 2));
        calc.Mult = 100;
        Debug.Log("sum(*100)=" + calc.Add(1, 2));

        Debug.Log("list[0]=" + calc[0]);
        Debug.Log("list[1]=" + calc[1]);
        
        calc.PropertyChanged += Notify;
        calc[1] = "dddd";
        Debug.Log("list[1]=" + calc[1]);

        calc.PropertyChanged -= Notify;

        calc[1] = "eeee";
        Debug.Log("list[1]=" + calc[1]);
    }

    void Notify(object sender, PropertyChangedEventArgs e)
    {
        Debug.Log(string.Format("{0} has property changed {1}={2}", sender, e.name, e.value));
    }

    // Update is called once per frame
    public override void Update()
    {

    }
}
