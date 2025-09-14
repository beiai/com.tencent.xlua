using UnityEditor;
using UnityEngine;
using XLua;
using LuaApi = XLua.LuaDLL.Lua;

public static class Menu
{
    [MenuItem("Tools/XLua")]
    public static void XLua()
    {
        Debug.Log(1);

        var test = new LuaEnv();
        
        var ver = LuaApi.xlua_get_lib_version();
        Debug.Log(ver);
        ver = LuaApi.xlua_get_lib_version();
        Debug.Log(ver);
    }
}