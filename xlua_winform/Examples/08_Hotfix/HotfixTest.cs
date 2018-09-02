/*

XLua.LuaException: xlua.access, no field __Hotfix0_Update
stack traceback:
	[C]: in field 'access'
	[string "Init"]:88: in field 'hotfix'
	[string "chunk"]:2: in main chunk
	
LuaEnv.cs
 xlua.access(cs, cflag .. '__Hotfix0_'..k, f) -- at least one

StaticLuaCallbacks.cs:
 public static int XLuaAccess(RealStatePtr L)

System.Reflection;

-------------------------------------

XLua.LuaException: xlua.access, no field __Hotfix0_Update
stack traceback:
	[C]: in field 'access'
	[string "Init"]:88: in field 'hotfix'
	[string "chunk"]:2: in main chunk
   at System.Void XLua.LuaEnv.ThrowExceptionFromError(System.Int32 oldTop) in e:\sync\xlua\xlua\XLua\Src\LuaEnv.cs:line 434
   at Object[] XLua.LuaEnv.DoString(System.Byte[] chunk, System.String chunkName, XLua.LuaTable env) in e:\sync\xlua\xlua\XLua\Src\LuaEnv.cs:line 267
   at Object[] XLua.LuaEnv.DoString(System.String chunk, System.String chunkName, XLua.LuaTable env) in e:\sync\xlua\xlua\XLua\Src\LuaEnv.cs:line 281
   at System.Void HotfixTest.OnGUI() in e:\sync\xlua\xlua\Examples\08_Hotfix\HotfixTest.cs:line 29
   at System.Void xlua.MainForm.update() in e:\sync\xlua\xlua\MainForm.cs:line 179
   at System.Void xlua.MainForm.loop() in e:\sync\xlua\xlua\MainForm.cs:line 87
   at static System.Void xlua.MainForm.loop(System.Object parent_) in e:\sync\xlua\xlua\MainForm.cs:line 71
   at static System.Void System.Threading.ThreadHelper.ThreadStart_Context(System.Object state)
   at static System.Void System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, System.Object state, System.Boolean preserveSyncCtx)
   at static System.Void System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, System.Object state, System.Boolean preserveSyncCtx)
   at static System.Void System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, System.Object state)
   at System.Void System.Threading.ThreadHelper.ThreadStart(System.Object obj)



*/

using UnityEngine;
using XLua;

[Hotfix]
public class HotfixTest : MonoBehaviour
{
	//------------------------------------------
	private static DelegateBridge _c__Hotfix0_ctor = null;

	private static DelegateBridge __Hotfix0_Start = null;

	private static DelegateBridge __Hotfix0_Update = null;

	private static DelegateBridge __Hotfix0_OnGUI = null;

	public HotfixTest()
	{
		DelegateBridge c__Hotfix0_ctor = HotfixTest._c__Hotfix0_ctor;
		if (c__Hotfix0_ctor != null)
		{
			c__Hotfix0_ctor.__Gen_Delegate_Imp13(this);
		}
	}
	//------------------------------------------	



	
	
	
	LuaEnv luaenv = new LuaEnv();

    private int tick = 0;

    // Use this for initialization
    public override void Start()
    {
    	//------------------------------------------
    	DelegateBridge _Hotfix0_Start = HotfixTest.__Hotfix0_Start;
		if (_Hotfix0_Start != null)
		{
			_Hotfix0_Start.__Gen_Delegate_Imp13(this);
			return;
		}
		//------------------------------------------
    }

    // Update is called once per frame
    public override void Update()
    {
    	//------------------------------------------
    	DelegateBridge _Hotfix0_Update = HotfixTest.__Hotfix0_Update;
		if (_Hotfix0_Update != null)
		{
			_Hotfix0_Update.__Gen_Delegate_Imp13(this);
			return;
		}
		//------------------------------------------
    	
        if (++tick % 50 == 0)
        {
            Debug.Log(">>>>>>>>Update in C#, tick = " + tick);
        }
    }

    public override void OnGUI()
    {
    	//------------------------------------------
    	DelegateBridge _Hotfix0_OnGUI = HotfixTest.__Hotfix0_OnGUI;
		if (_Hotfix0_OnGUI != null)
		{
			_Hotfix0_OnGUI.__Gen_Delegate_Imp13(this);
			return;
		}
    	//------------------------------------------
    	
        if (GUI.Button(new Rect(10, 10, 300, 80), "Hotfix"))
        {
            luaenv.DoString(@"
                xlua.hotfix(CS.HotfixTest, 'Update', function(self)
                    self.tick = self.tick + 1
                    if (self.tick % 50) == 0 then
                        print('<<<<<<<<Update in lua, tick = ' .. self.tick)
                    end
                end)
            ");
        }

        string chHint = @"在运行该示例之前，请细致阅读xLua文档，并执行以下步骤：

1.宏定义：添加 HOTFIX_ENABLE 到 'Edit > Project Settings > Player > Other Settings > Scripting Define Symbols'。
（注意：各平台需要分别设置）

2.生成代码：执行 'XLua > Generate Code' 菜单，等待Unity编译完成。

3.注入：执行 'XLua > Hotfix Inject In Editor' 菜单。注入成功会打印 'hotfix inject finish!' 或者 'had injected!' 。";
        string enHint = @"Read documents carefully before you run this example, then follow the steps below:

1. Define: Add 'HOTFIX_ENABLE' to 'Edit > Project Settings > Player > Other Settings > Scripting Define Symbols'.
(Note: Each platform needs to set this respectively)

2.Generate Code: Execute menu 'XLua > Generate Code', wait for Unity's compilation.


3.Inject: Execute menu 'XLua > Hotfix Inject In Editor'.There should be 'hotfix inject finish!' or 'had injected!' print in the Console if the Injection is successful.";
        GUIStyle style = GUI.skin.textArea;
        style.normal.textColor = Color.red;
        style.fontSize = 16;
        GUI.TextArea(new Rect(10, 100, 500, 290), chHint, style);
        GUI.TextArea(new Rect(10, 400, 500, 290), enHint, style);
    }
}
