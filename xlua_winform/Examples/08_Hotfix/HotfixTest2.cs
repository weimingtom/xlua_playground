/*

<>xLuaBaseProxy_

see 
private void __xLuaBaseProxy_Foo(int p)

XLua.LuaException: [string "Init"]:113: attempt to call a nil value (upvalue 'func')
stack traceback:
	[string "Init"]:113: in method 'Foo'
	[string "chunk"]:4: in function <[string "chunk"]:2>
   at System.Void XLua.LuaEnv.ThrowExceptionFromError(System.Int32 oldTop) in e:\sync\xlua\xlua\XLua\Src\LuaEnv.cs:line 434
   at System.Void XLua.DelegateBridge.__Gen_Delegate_Imp18(System.Object p0, System.Int32 p1) in e:\sync\xlua\xlua\XLua\Gen\DelegatesGensBridge.cs:line 540
   at System.Void BaseTest.Foo(System.Int32 p) in e:\sync\xlua\xlua\Examples\08_Hotfix\HotfixTest2.cs:line 358
   at System.Void HotfixTest2.Start() in e:\sync\xlua\xlua\Examples\08_Hotfix\HotfixTest2.cs:line 746
   at System.Void xlua.MainForm.setup() in e:\sync\xlua\xlua\MainForm.cs:line 165
   at System.Void xlua.MainForm.loop() in e:\sync\xlua\xlua\MainForm.cs:line 77
   at static System.Void xlua.MainForm.loop(System.Object parent_) in e:\sync\xlua\xlua\MainForm.cs:line 72
   at static System.Void System.Threading.ThreadHelper.ThreadStart_Context(System.Object state)
   at static System.Void System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, System.Object state, System.Boolean preserveSyncCtx)
   at static System.Void System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, System.Object state, System.Boolean preserveSyncCtx)
   at static System.Void System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, System.Object state)
   at System.Void System.Threading.ThreadHelper.ThreadStart(System.Object obj)


*/

using UnityEngine;
using System.Collections.Generic;
using XLua;

[CSharpCallLua]
public delegate int TestOutDelegate(HotfixCalc calc, int a, out double b, ref string c);

[Hotfix]
public class HotfixCalc
{
	//------------------------------------------
	private static DelegateBridge _c__Hotfix0_ctor = null;

	private static DelegateBridge __Hotfix0_Add = null;

	private static DelegateBridge __Hotfix1_Add = null;

	private static DelegateBridge __Hotfix0_TestOut = null;

	private static DelegateBridge __Hotfix1_TestOut = null;

	private static DelegateBridge __Hotfix0_Test1 = null;

	private static DelegateBridge __Hotfix0_Test2 = null;

	private static DelegateBridge __Hotfix0_Test3 = null;

	private static DelegateBridge __Hotfix0_Test4 = null;

	private static DelegateBridge __Hotfix0_Test5 = null;

	public HotfixCalc()
	{
		DelegateBridge c__Hotfix0_ctor = HotfixCalc._c__Hotfix0_ctor;
		if (c__Hotfix0_ctor != null)
		{
			c__Hotfix0_ctor.__Gen_Delegate_Imp13(this);
		}
	}	
	//------------------------------------------
	
	
    public int Add(int a, int b)
    {
		//------------------------------------------
		DelegateBridge _Hotfix0_Add = HotfixCalc.__Hotfix0_Add;
		if (_Hotfix0_Add != null)
		{
			return _Hotfix0_Add.__Gen_Delegate_Imp14(this, a, b);
		}
		//------------------------------------------
		
        return a - b;
    }

    public Vector3 Add(Vector3 a, Vector3 b)
    {
    	//------------------------------------------
		DelegateBridge _Hotfix1_Add = HotfixCalc.__Hotfix1_Add;
		if (_Hotfix1_Add != null)
		{
			return _Hotfix1_Add.__Gen_Delegate_Imp15(this, a, b);
		}    	
		//------------------------------------------
		
        return a - b;
    }

    public int TestOut(int a, out double b, ref string c)
    {
        //------------------------------------------
        DelegateBridge _Hotfix0_TestOut = HotfixCalc.__Hotfix0_TestOut;
		if (_Hotfix0_TestOut != null)
		{
			return _Hotfix0_TestOut.__Gen_Delegate_Imp16(this, a, out b, ref c);
		}
		//------------------------------------------
		b = a + 2;
        c = "wrong version";
        return a + 3;
    }

    public int TestOut(int a, out double b, ref string c, GameObject go)
    {
        //------------------------------------------
        DelegateBridge _Hotfix1_TestOut = HotfixCalc.__Hotfix1_TestOut;
		if (_Hotfix1_TestOut != null)
		{
			return _Hotfix1_TestOut.__Gen_Delegate_Imp17(this, a, out b, ref c, go);
		}
		//------------------------------------------
		return TestOut(a, out b, ref c);
    }

    public T Test1<T>()
    {
        //------------------------------------------
        DelegateBridge _Hotfix0_Test = HotfixCalc.__Hotfix0_Test1;
		if (_Hotfix0_Test != null)
		{
			_Hotfix0_Test.InvokeSessionStart();
			_Hotfix0_Test.InParam<HotfixCalc>(this);
			_Hotfix0_Test.Invoke(1);
			return _Hotfix0_Test.InvokeSessionEndWithResult<T>();
		}
		//------------------------------------------
		return default(T);
    }

    public T1 Test2<T1, T2, T3>(T1 a, out T2 b, ref T3 c)
    {
        //------------------------------------------
        DelegateBridge _Hotfix0_Test = HotfixCalc.__Hotfix0_Test2;
		if (_Hotfix0_Test != null)
		{
			_Hotfix0_Test.InvokeSessionStart();
			_Hotfix0_Test.InParam<HotfixCalc>(this);
			_Hotfix0_Test.InParam<T1>(a);
			_Hotfix0_Test.InParam<T3>(c);
			_Hotfix0_Test.Invoke(3);
			_Hotfix0_Test.OutParam<T2>(1, out b);
			_Hotfix0_Test.OutParam<T3>(2, out c);
			return _Hotfix0_Test.InvokeSessionEndWithResult<T1>();
		}
		//------------------------------------------
		b = default(T2);
        return a;
    }

    public static int Test3<T>(T a)
    {
        //------------------------------------------
        DelegateBridge _Hotfix0_Test = HotfixCalc.__Hotfix0_Test3;
		if (_Hotfix0_Test != null)
		{
			_Hotfix0_Test.InvokeSessionStart();
			_Hotfix0_Test.InParam<T>(a);
			_Hotfix0_Test.Invoke(1);
			return _Hotfix0_Test.InvokeSessionEndWithResult<int>();
		}
		//------------------------------------------
		return 0;
    }

    public static void Test4<T>(T a)
    { 
    	//------------------------------------------
    	DelegateBridge _Hotfix0_Test = HotfixCalc.__Hotfix0_Test4;
		if (_Hotfix0_Test != null)
		{
			_Hotfix0_Test.InvokeSessionStart();
			_Hotfix0_Test.InParam<T>(a);
			_Hotfix0_Test.Invoke(0);
			_Hotfix0_Test.InvokeSessionEnd();
			return;
		}
		//------------------------------------------
	}

    public void Test5<T>(int a, params T[] arg)
    {
		//------------------------------------------
		DelegateBridge _Hotfix0_Test = HotfixCalc.__Hotfix0_Test5;
		if (_Hotfix0_Test != null)
		{
			_Hotfix0_Test.InvokeSessionStart();
			_Hotfix0_Test.InParam<HotfixCalc>(this);
			_Hotfix0_Test.InParam<int>(a);
			_Hotfix0_Test.InParams<T>(arg);
			_Hotfix0_Test.Invoke(0);
			_Hotfix0_Test.InvokeSessionEnd();
			return;
		}
		//------------------------------------------
    }
}

public class NoHotfixCalc
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

[Hotfix]
public class GenericClass<T>
{
	//------------------------------------------
	private static DelegateBridge _c__Hotfix0_ctor = null;

	private static DelegateBridge __Hotfix0_Func1 = null;

	private static DelegateBridge __Hotfix0_Func2 = null;
	//------------------------------------------
	
    T a;

    public GenericClass(T a)
    {
        this.a = a;
        //------------------------------------------
		DelegateBridge c__Hotfix0_ctor = GenericClass<T>._c__Hotfix0_ctor;
		if (c__Hotfix0_ctor != null)
		{
			c__Hotfix0_ctor.InvokeSessionStart();
			c__Hotfix0_ctor.InParam<GenericClass<T>>(this);
			c__Hotfix0_ctor.InParam<T>(a);
			c__Hotfix0_ctor.Invoke(0);
			c__Hotfix0_ctor.InvokeSessionEnd();
		}
		//------------------------------------------
	}

    public void Func1()
    {
    	//------------------------------------------
		DelegateBridge _Hotfix0_Func = GenericClass<T>.__Hotfix0_Func1;
		if (_Hotfix0_Func != null)
		{
			_Hotfix0_Func.InvokeSessionStart();
			_Hotfix0_Func.InParam<GenericClass<T>>(this);
			_Hotfix0_Func.Invoke(0);
			_Hotfix0_Func.InvokeSessionEnd();
			return;
		}
        //------------------------------------------
		Debug.Log("a=" + a);
    }

    public T Func2()
    {
    	//------------------------------------------
		DelegateBridge _Hotfix0_Func = GenericClass<T>.__Hotfix0_Func2;
		if (_Hotfix0_Func != null)
		{
			_Hotfix0_Func.InvokeSessionStart();
			_Hotfix0_Func.InParam<GenericClass<T>>(this);
			_Hotfix0_Func.Invoke(1);
			return _Hotfix0_Func.InvokeSessionEndWithResult<T>();
		}
        //------------------------------------------
		return default(T);
    }
}

[Hotfix]
public class InnerTypeTest
{
	//------------------------------------------
	private static DelegateBridge _c__Hotfix0_ctor = null;

	private static DelegateBridge __Hotfix0_Foo = null;

	private static DelegateBridge __Hotfix0_Bar = null;

	public InnerTypeTest()
	{
		DelegateBridge c__Hotfix0_ctor = InnerTypeTest._c__Hotfix0_ctor;
		if (c__Hotfix0_ctor != null)
		{
			c__Hotfix0_ctor.__Gen_Delegate_Imp13(this);
		}
	}
	//------------------------------------------
	
    public void Foo()
    {
    	//------------------------------------------
		DelegateBridge _Hotfix0_Foo = InnerTypeTest.__Hotfix0_Foo;
		if (_Hotfix0_Foo != null)
		{
			_Hotfix0_Foo.__Gen_Delegate_Imp13(this);
			return;
		}
		//------------------------------------------
	
        _InnerStruct ret = Bar();
        Debug.Log("{x=" + ret.x + ",y= " + ret.y + "}");
    }

    struct _InnerStruct
    {
        public int x;
        public int y;
    }

    _InnerStruct Bar()
    {
    	//------------------------------------------
		DelegateBridge _Hotfix0_Bar = InnerTypeTest.__Hotfix0_Bar;
		if (_Hotfix0_Bar != null)
		{
			_Hotfix0_Bar.InvokeSessionStart();
			_Hotfix0_Bar.InParam<InnerTypeTest>(this);
			_Hotfix0_Bar.Invoke(1);
			return _Hotfix0_Bar.InvokeSessionEndWithResult<InnerTypeTest._InnerStruct>();
		}
        //------------------------------------------
		return new _InnerStruct { x = 1, y = 2 };
    }
}

public class BaseTestHelper
{
    
}

public class BaseTestBase<T> : BaseTestHelper
{
    public virtual void Foo(int p)
    {
        Debug.Log("BaseTestBase<>.Foo, p = " + p);
    }
}

[Hotfix]
[LuaCallCSharp]
public class BaseTest : BaseTestBase<InnerTypeTest>
{
	//------------------------------------------
	private static DelegateBridge _c__Hotfix0_ctor = null;

	private static DelegateBridge __Hotfix0_Foo = null;

	private static DelegateBridge __Hotfix0_Proxy = null;

	private static DelegateBridge __Hotfix0_ToString = null;	
	
	public BaseTest()
	{
		DelegateBridge c__Hotfix0_ctor = BaseTest._c__Hotfix0_ctor;
		if (c__Hotfix0_ctor != null)
		{
			c__Hotfix0_ctor.__Gen_Delegate_Imp13(this);
		}
	}
	//------------------------------------------
	
    public override void Foo(int p)
    {
    	//------------------------------------------
		DelegateBridge _Hotfix0_Foo = BaseTest.__Hotfix0_Foo;
		if (_Hotfix0_Foo != null)
		{
			_Hotfix0_Foo.__Gen_Delegate_Imp18(this, p);
			return;
		}
		//------------------------------------------
		
        Debug.Log("BaseTest<>.Foo, p = " + p);
    }

    public void Proxy(int p)
    {
    	//------------------------------------------
		DelegateBridge _Hotfix0_Proxy = BaseTest.__Hotfix0_Proxy;
		if (_Hotfix0_Proxy != null)
		{
			_Hotfix0_Proxy.__Gen_Delegate_Imp18(this, p);
			return;
		}
    	//------------------------------------------
		
        base.Foo(p);
    }

    public override string ToString()
    {
    	//------------------------------------------
		DelegateBridge _Hotfix0_ToString = BaseTest.__Hotfix0_ToString;
		if (_Hotfix0_ToString != null)
		{
			return _Hotfix0_ToString.__Gen_Delegate_Imp19(this);
		}
    	//------------------------------------------
	
        return base.ToString();
    }
    
    //FIXME:???<>xLuaBaseProxy_ToString
    private string __xLuaBaseProxy_ToString()
	{
		return base.ToString();
	}
    
    //FIXME:??? not generated
    private void __xLuaBaseProxy_Foo(int p)
	{
		base.Foo(p);
	}
}

[Hotfix]
public struct StructTest
{
	//------------------------------------------
	private static DelegateBridge _c__Hotfix0_ctor = null;

	private static DelegateBridge __Hotfix0_GetGo = null;

	private static DelegateBridge __Hotfix0_ToString = null;

	private static DelegateBridge __Hotfix0_Proxy = null;
	//------------------------------------------
	
    GameObject go;
    public StructTest(GameObject go)
    {
        this.go = go;
        //------------------------------------------
		DelegateBridge c__Hotfix0_ctor = StructTest._c__Hotfix0_ctor;
		if (c__Hotfix0_ctor != null)
		{
			c__Hotfix0_ctor.__Gen_Delegate_Imp22(this, go);
		}
		//------------------------------------------
	}

    public GameObject GetGo(int a, object b)
    {
    	//------------------------------------------
		DelegateBridge _Hotfix0_GetGo = StructTest.__Hotfix0_GetGo;
		if (_Hotfix0_GetGo != null)
		{
			return _Hotfix0_GetGo.__Gen_Delegate_Imp20(this, a, b);
		}
    	//------------------------------------------
	    return go;
    }

    public override string ToString()
    {
    	//------------------------------------------
		DelegateBridge _Hotfix0_ToString = StructTest.__Hotfix0_ToString;
		if (_Hotfix0_ToString != null)
		{
			return _Hotfix0_ToString.__Gen_Delegate_Imp21(this);
		}
    	//------------------------------------------
	    return base.ToString();
    }

    public string Proxy()
    {
    	//------------------------------------------
		DelegateBridge _Hotfix0_Proxy = StructTest.__Hotfix0_Proxy;
		if (_Hotfix0_Proxy != null)
		{
			return _Hotfix0_Proxy.__Gen_Delegate_Imp21(this);
		}
    	//------------------------------------------
	    return base.ToString();
    }
    
    
    //------------------------------------------
	//FIXME:???<>xLuaBaseProxy_ToString()
    private string __xLuaBaseProxy_ToString()
	{
		return base.ToString();
	}
    //------------------------------------------
}

[Hotfix]
public struct GenericStruct<T>
{
	//------------------------------------------
	private static DelegateBridge _c__Hotfix0_ctor = null;

	private static DelegateBridge __Hotfix0_GetA = null;	
	//------------------------------------------
			
    T a;

    public GenericStruct(T a)
    {
        this.a = a;
        
    	//------------------------------------------
		DelegateBridge c__Hotfix0_ctor = GenericStruct<T>._c__Hotfix0_ctor;
		if (c__Hotfix0_ctor != null)
		{
			c__Hotfix0_ctor.InvokeSessionStart();
			c__Hotfix0_ctor.InParam<GenericStruct<T>>(this);
			c__Hotfix0_ctor.InParam<T>(a);
			c__Hotfix0_ctor.Invoke(0);
			c__Hotfix0_ctor.InvokeSessionEnd();
		}
		//------------------------------------------
	}

    public T GetA(int p)
    {
    	//------------------------------------------
		DelegateBridge _Hotfix0_GetA = GenericStruct<T>.__Hotfix0_GetA;
		if (_Hotfix0_GetA != null)
		{
			_Hotfix0_GetA.InvokeSessionStart();
			_Hotfix0_GetA.InParam<GenericStruct<T>>(this);
			_Hotfix0_GetA.InParam<int>(p);
			_Hotfix0_GetA.Invoke(1);
			return _Hotfix0_GetA.InvokeSessionEndWithResult<T>();
		}
    	//------------------------------------------
		return a;
    }
}

public class HotfixTest2 : MonoBehaviour {

	// Use this for initialization
	public override void Start () {
        LuaEnv luaenv = new LuaEnv();
        HotfixCalc calc = new HotfixCalc();
        NoHotfixCalc ordinaryCalc = new NoHotfixCalc();

        int CALL_TIME = 100 * 1000 * 1000 ;
        var start = System.DateTime.Now;
        for (int i = 0; i < CALL_TIME; i++)
        {
            calc.Add(2, 1);
        }
        var d1 = (System.DateTime.Now - start).TotalMilliseconds;
        Debug.Log("Hotfix using:" + d1);

        start = System.DateTime.Now;
        for (int i = 0; i < CALL_TIME; i++)
        {
            ordinaryCalc.Add(2, 1);
        }
        var d2 = (System.DateTime.Now - start).TotalMilliseconds;
        Debug.Log("No Hotfix using:" + d2);

        Debug.Log("drop:" + ((d1 - d2) / d1));

        Debug.Log("Before Fix: 2 + 1 = " + calc.Add(2, 1));
        Debug.Log("Before Fix: Vector3(2, 3, 4) + Vector3(1, 2, 3) = " + calc.Add(new Vector3(2, 3, 4), new Vector3(1, 2, 3)));
        luaenv.DoString(@"
            xlua.hotfix(CS.HotfixCalc, 'Add', function(self, a, b)
                return a + b
            end)
        ");
        Debug.Log("After Fix: 2 + 1 = " + calc.Add(2, 1));
        Debug.Log("After Fix: Vector3(2, 3, 4) + Vector3(1, 2, 3) = " + calc.Add(new Vector3(2, 3, 4), new Vector3(1, 2, 3)));

        double num;
        string str = "hehe";
        int ret = calc.TestOut(100, out num, ref str);
        Debug.Log("ret = " + ret + ", num = " + num + ", str = " + str);

        luaenv.DoString(@"
            xlua.hotfix(CS.HotfixCalc, 'TestOut', function(self, a, c, go)
                    print('TestOut', self, a, c, go)
                    if go then error('test error') end
                    return a + 10, a + 20, 'right version'
                end)
        ");
        str = "hehe";
        ret = calc.TestOut(100, out num, ref str);
        Debug.Log("ret = " + ret + ", num = " + num + ", str = " + str);

        luaenv.DoString(@"
            xlua.hotfix(CS.HotfixCalc, {
                 Test1 = function(self)
                    print('Test1', self)
                    return 1
                 end;
                 Test2 = function(self, a, b)
                     print('Test1', self, a, b)
                     return a + 10, 1024, b
                 end;
                 Test3 = function(a)
                    print(a)
                    return 10
                 end;
                 Test4 = function(a)
                    print(a)
                 end;
                 Test5 = function(self, a, ...)
                    print('Test4', self, a, ...)
                 end
            })
        ");

        int r1 = calc.Test1<int>();
        double r2 = calc.Test1<double>();

        Debug.Log("r1:" + r1 + ",r2:" + r2);

        string ss = "heihei";
        int r3 = calc.Test2(r1, out r2, ref ss);
        Debug.Log("r1:" + r1 + ",r2:" + r2 + ",r3:" + r3 + ",ss:" + ss);

        r3 = HotfixCalc.Test3("test3");
        r3 = HotfixCalc.Test3(2);
        r3 = HotfixCalc.Test3(this);
        Debug.Log("r3:" + r3);
        HotfixCalc.Test4(this);
        HotfixCalc.Test4(2);
        calc.Test5(10, "a", "b", "c");
        calc.Test5(10, 1, 3, 5);

        Debug.Log("----------------------before------------------------");
        TestStateful();
        System.GC.Collect();
        System.GC.WaitForPendingFinalizers();
        luaenv.DoString(@"
            local util = require 'XLua/Resources/xlua.util'
            xlua.hotfix(CS.StatefullTest, {
                ['.ctor'] = function(csobj)
                    util.state(csobj, {evt = {}, start = 0, prop = 0})
                end;
                set_AProp = function(self, v)
                    print('set_AProp', v)
                    self.prop = v
                end;
                get_AProp = function(self)
                    return self.prop
                end;
                get_Item = function(self, k)
                    print('get_Item', k)
                    return 1024
                end;
                set_Item = function(self, k, v)
                    print('set_Item', k, v)
                end;
                add_AEvent = function(self, cb)
                    print('add_AEvent', cb)
                    table.insert(self.evt, cb)
                end;
                remove_AEvent = function(self, cb)
                   print('remove_AEvent', cb)
                   for i, v in ipairs(self.evt) do
                       if v == cb then
                           table.remove(self.evt, i)
                           break
                       end
                   end
                end;
                Start = function(self)
                    print('Start')
                    for _, cb in ipairs(self.evt) do
                        cb(self.start, 2)
                    end
                    self.start = self.start + 1
                end;
                StaticFunc = function(a, b, c)
                   print(a, b, c)
                end;
                GenericTest = function(self, a)
                   print(self, a)
                end;
                Finalize = function(self)
                   print('Finalize', self)
                end
           })
        ");
        Debug.Log("----------------------after------------------------");
        TestStateful();
        luaenv.FullGc();
        System.GC.Collect();
        System.GC.WaitForPendingFinalizers();

        var genericObj = new GenericClass<double>(1.1);
        genericObj.Func1();
        Debug.Log(genericObj.Func2());
        luaenv.DoString(@"
            xlua.hotfix(CS['GenericClass`1[System.Double]'], {
                ['.ctor'] = function(obj, a)
                    print('GenericClass<double>', obj, a)
                end;
                Func1 = function(obj)
                    print('GenericClass<double>.Func1', obj)
                end;
                Func2 = function(obj)
                    print('GenericClass<double>.Func2', obj)
                    return 1314
                end
            })
        ");
        genericObj = new GenericClass<double>(1.1);
        genericObj.Func1();
        Debug.Log(genericObj.Func2());

        InnerTypeTest itt = new InnerTypeTest();
        itt.Foo();
        luaenv.DoString(@"
            xlua.hotfix(CS.InnerTypeTest, 'Bar', function(obj)
                    print('lua Bar', obj)
                    return {x = 10, y = 20}
                end)
        ");
        itt.Foo();

        StructTest st = new StructTest(gameObject);
        Debug.Log("go=" + st.GetGo(123, "john"));
        luaenv.DoString(@"
            xlua.hotfix(CS.StructTest, 'GetGo', function(self, a, b)
                    print('GetGo', self, a, b)
                    return nil
                end)
        ");
        Debug.Log("go=" + st.GetGo(123, "john"));

        GenericStruct<int> gs = new GenericStruct<int>(1);
        Debug.Log("gs.GetA()=" + gs.GetA(123));
        luaenv.DoString(@"
            xlua.hotfix(CS['GenericStruct`1[System.Int32]'], 'GetA', function(self, a)
                    print('GetA',self, a)
                    return 789
                end)
        ");
        Debug.Log("gs.GetA()=" + gs.GetA(123));

        try
        {
            calc.TestOut(100, out num, ref str, gameObject);
        }
        catch(LuaException e)
        {
            Debug.Log("throw in lua an catch in c# ok, e.Message:" + e.Message);
        }


        BaseTestBase<InnerTypeTest> bt = new BaseTest();
        bt.Foo(1);
        Debug.Log(bt);

        luaenv.DoString(@"
            xlua.hotfix(CS.BaseTest, 'Foo', function(self, p)
                    print('BaseTest', p)
                    base(self):Foo(p)
                end)
            xlua.hotfix(CS.BaseTest, 'ToString', function(self)
                    return '>>>' .. base(self):ToString()
                end)
        ");
        bt.Foo(2); //FIXME:breakpoint:search __xLuaBaseProxy_Foo
        Debug.Log(bt);
    }

    void TestStateful()
    {
        StatefullTest sft = new StatefullTest();
        sft.AProp = 10;
        Debug.Log("sft.AProp:" + sft.AProp);
        sft["1"] = 1;
        Debug.Log("sft['1']:" + sft["1"]);
        System.Action<int, double> cb = (a, b) =>
        {
            Debug.Log("a:" + a + ",b:" + b);
        };
        sft.AEvent += cb;
        sft.Start();
        sft.Start();
        sft.AEvent -= cb;
        sft.Start();
        StatefullTest.StaticFunc(1, 2);
        StatefullTest.StaticFunc("e", 3, 4);
        sft.GenericTest(1);
        sft.GenericTest("hehe");
    }
	
	// Update is called once per frame
	public override void Update () {
	
	}
}

