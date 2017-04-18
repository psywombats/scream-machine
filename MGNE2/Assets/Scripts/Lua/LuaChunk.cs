﻿using MoonSharp.Interpreter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// represents an eval-able piece of Lua, usually from an event field
public class LuaChunk {

    private DynValue function;

	public LuaChunk(DynValue scriptFunction) {
        this.function = scriptFunction;
    }

    public DynValue Evaluate() {
        return Global.Instance().Lua.Run(function);
    }

    public void Run() {
        Global.Instance().Lua.RunScript(function);
    }
}
