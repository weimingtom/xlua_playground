/*

(2) TODO:
onDestroy() : System.InvalidOperationException: try to dispose a LuaEnv with C# callback!
   在 XLua.LuaEnv.Dispose(Boolean dispose) 位置 e:\sync\xlua\xlua\XLua\Src\LuaEnv.cs:行号 403
   在 XLua.LuaEnv.Dispose() 位置 e:\sync\xlua\xlua\XLua\Src\LuaEnv.cs:行号 386
   在 CoroutineTest.OnDestroy() 位置 e:\sync\xlua\xlua\Examples\06_Coroutine\CoroutineTest.cs:行号 35
   在 xlua.MainForm.loop() 位置 e:\sync\xlua\xlua\MainForm.cs:行号 86
   

------------------------------
(1) require

        internal static int LoadFromResource(RealStatePtr L)
        
*/

using UnityEngine;
using XLua;

public class CoroutineTest : MonoBehaviour {
    LuaEnv luaenv = null;
    // Use this for initialization
    public override void Start()
    {
        luaenv = new LuaEnv();
        luaenv.DoString("require 'Examples/06_Coroutine/Resources/coruntine_test'");
    }

    // Update is called once per frame
    public override void Update()
    {
        if (luaenv != null)
        {
            luaenv.Tick();
        }
    }

    public override void OnDestroy()
    {
        luaenv.Dispose();
    }
}
