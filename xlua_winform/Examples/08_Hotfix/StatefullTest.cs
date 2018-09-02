using UnityEngine;
using XLua;

[XLua.Hotfix]
public class StatefullTest {
	//------------------------------------------
	private static DelegateBridge _c__Hotfix0_ctor = null;

	private static DelegateBridge _c__Hotfix1_ctor = null;

	private static DelegateBridge __Hotfix0_add_AEvent = null;

	private static DelegateBridge __Hotfix0_remove_AEvent = null;

	private static DelegateBridge __Hotfix0_get_AProp = null;

	private static DelegateBridge __Hotfix0_set_AProp = null;

	private static DelegateBridge __Hotfix0_get_Item = null;

	private static DelegateBridge __Hotfix0_set_Item = null;

	private static DelegateBridge __Hotfix0_Start = null;

	private static DelegateBridge __Hotfix0_Update = null;

	private static DelegateBridge __Hotfix0_GenericTest = null;

	private static DelegateBridge __Hotfix0_StaticFunc = null;

	private static DelegateBridge __Hotfix1_StaticFunc = null;

	private static DelegateBridge __Hotfix0_Finalize = null;
	//------------------------------------------
	
	
    public StatefullTest()
    {
		//------------------------------------------
		DelegateBridge c__Hotfix0_ctor = StatefullTest._c__Hotfix0_ctor;
		if (c__Hotfix0_ctor != null)
		{
			c__Hotfix0_ctor.__Gen_Delegate_Imp13(this);
		}
		//------------------------------------------
	}

    public StatefullTest(int a, int b)
    {
    	//FIXME:
    	//------------------------------------------
		DelegateBridge c__Hotfix1_ctor;
		//------------------------------------------
		
        if (a > 0)
        {
        	//------------------------------------------
			c__Hotfix1_ctor = StatefullTest._c__Hotfix1_ctor;
			if (c__Hotfix1_ctor != null)
			{
				c__Hotfix1_ctor.__Gen_Delegate_Imp28(this, a, b);
			}
			//------------------------------------------
			return;
        }

        Debug.Log("a=" + a);
        if (b > 0)
        {
            //------------------------------------------
			c__Hotfix1_ctor = StatefullTest._c__Hotfix1_ctor;
			if (c__Hotfix1_ctor != null)
			{
				c__Hotfix1_ctor.__Gen_Delegate_Imp28(this, a, b);
			}
			//------------------------------------------
			return;
        }
        else
        {
            if (a + b > 0)
            {
                //------------------------------------------
				c__Hotfix1_ctor = StatefullTest._c__Hotfix1_ctor;
				if (c__Hotfix1_ctor != null)
				{
					c__Hotfix1_ctor.__Gen_Delegate_Imp28(this, a, b);
				}
				//------------------------------------------
				return;
            }
        }
        Debug.Log("b=" + b);
        //------------------------------------------
		c__Hotfix1_ctor = StatefullTest._c__Hotfix1_ctor;
		if (c__Hotfix1_ctor != null)
		{
			c__Hotfix1_ctor.__Gen_Delegate_Imp28(this, a, b);
		}
		//------------------------------------------
	}

    private int aProp;
    public int AProp
    {
        get
		{
        	//------------------------------------------
			DelegateBridge _Hotfix0_get_AProp = StatefullTest.__Hotfix0_get_AProp;
			if (_Hotfix0_get_AProp != null)
			{
				return _Hotfix0_get_AProp.__Gen_Delegate_Imp24(this);
			}
			//------------------------------------------
			return this.aProp;
		}
		set
		{
			//------------------------------------------
			DelegateBridge _Hotfix0_set_AProp = StatefullTest.__Hotfix0_set_AProp;
			if (_Hotfix0_set_AProp != null)
			{
				_Hotfix0_set_AProp.__Gen_Delegate_Imp18(this, value);
				return;
			}
			//------------------------------------------
			this.aProp = value;
		}
    }

    private event System.Action<int, double> aEvent;
    public event System.Action<int, double> AEvent
    {
    	add 
    	{ 
    		//------------------------------------------
			DelegateBridge _Hotfix0_add_AEvent = StatefullTest.__Hotfix0_add_AEvent;
			if (_Hotfix0_add_AEvent != null)
			{
				_Hotfix0_add_AEvent.__Gen_Delegate_Imp23(this, value);
				return;
			}
    		//------------------------------------------
			aEvent += value; 
    	}
   		remove 
   		{ 
   			//------------------------------------------
			DelegateBridge _Hotfix0_remove_AEvent = StatefullTest.__Hotfix0_remove_AEvent;
			if (_Hotfix0_remove_AEvent != null)
			{
				_Hotfix0_remove_AEvent.__Gen_Delegate_Imp23(this, value);
				return;
			}
   			//------------------------------------------
			aEvent -= value; 
   		}
    }

    public int this[string field]
    {
        get
        {
        	//------------------------------------------
        	DelegateBridge _Hotfix0_get_Item = StatefullTest.__Hotfix0_get_Item;
			if (_Hotfix0_get_Item != null)
			{
				return _Hotfix0_get_Item.__Gen_Delegate_Imp25(this, field);
			}
			//------------------------------------------
            return 1;
        }
        set
        {
        	//------------------------------------------
        	DelegateBridge _Hotfix0_set_Item = StatefullTest.__Hotfix0_set_Item;
			if (_Hotfix0_set_Item != null)
			{
				_Hotfix0_set_Item.__Gen_Delegate_Imp26(this, field, value);
				return;
			}
			//------------------------------------------
        }
    }

    public void Start () {
		//------------------------------------------
        DelegateBridge _Hotfix0_Start = StatefullTest.__Hotfix0_Start;
		if (_Hotfix0_Start != null)
		{
			_Hotfix0_Start.__Gen_Delegate_Imp13(this);
			return;
		}
		//------------------------------------------
    }
	
	void Update () {
		//------------------------------------------
        DelegateBridge _Hotfix0_Update = StatefullTest.__Hotfix0_Update;
		if (_Hotfix0_Update != null)
		{
			_Hotfix0_Update.__Gen_Delegate_Imp13(this);
			return;
		}
		//------------------------------------------
    }

    public void GenericTest<T>(T a)
    {
		//------------------------------------------
        DelegateBridge _Hotfix0_GenericTest = StatefullTest.__Hotfix0_GenericTest;
		if (_Hotfix0_GenericTest != null)
		{
			_Hotfix0_GenericTest.InvokeSessionStart();
			_Hotfix0_GenericTest.InParam<StatefullTest>(this);
			_Hotfix0_GenericTest.InParam<T>(a);
			_Hotfix0_GenericTest.Invoke(0);
			_Hotfix0_GenericTest.InvokeSessionEnd();
			return;
		}
		//------------------------------------------
    }

    static public void StaticFunc(int a, int b)
    {
    	//------------------------------------------
        DelegateBridge _Hotfix0_StaticFunc = StatefullTest.__Hotfix0_StaticFunc;
		if (_Hotfix0_StaticFunc != null)
		{
			_Hotfix0_StaticFunc.__Gen_Delegate_Imp27(a, b);
			return;
		}
		//------------------------------------------
    }
    static public void StaticFunc(string a, int b, int c)
    {
    	//------------------------------------------
        DelegateBridge _Hotfix1_StaticFunc = StatefullTest.__Hotfix1_StaticFunc;
		if (_Hotfix1_StaticFunc != null)
		{
			_Hotfix1_StaticFunc.__Gen_Delegate_Imp28(a, b, c);
			return;
		}
		//------------------------------------------
    }

    ~StatefullTest()
    {
        DelegateBridge _Hotfix0_Finalize = StatefullTest.__Hotfix0_Finalize;
		if (_Hotfix0_Finalize != null)
		{
			_Hotfix0_Finalize.__Gen_Delegate_Imp13(this);
			return;
		}
		Debug.Log("~StatefullTest");
    }
    
    //FIXME:???<>xLuaBaseProxy
    private void __xLuaBaseProxy_Finalize()
	{
//		base.Finalize();
	}
}

