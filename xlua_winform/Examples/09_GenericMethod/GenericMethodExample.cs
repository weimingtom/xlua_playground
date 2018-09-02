using UnityEngine;
using XLua;

public class GenericMethodExample : MonoBehaviour
{
    private const string script = @"
        local foo1 = CS.Foo1Child()
        local foo2 = CS.Foo2Child()

        local obj = CS.UnityEngine.GameObject()
        foo1:PlainExtension()
        foo1:Extension1()
        foo1:Extension2(obj) -- overload1
        foo1:Extension2(foo2) -- overload2
        
        local foo = CS.Foo()
        foo:Test1(foo1)
        foo:Test2(foo1,foo2,obj)
";
    private LuaEnv env;

    public override void Start()
    {
        env = new LuaEnv();
        env.DoString(script);
    }

    public override void Update()
    {
        if (env != null)
            env.Tick();
    }

    public override void OnDestroy()
    {
        env.Dispose();
    }
}