module rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

[<Erase>]
type Exports =
    interface end

[<AllowNullLiteral>]
[<Interface>]
type Class =
    static member inline extend (props: obj): obj =
        emitJsExpr (props) $$"""
import { Class } from "module";
Class.extend($0)"""
    static member inline ``include`` (props: obj): obj =
        emitJsExpr (props) $$"""
import { Class } from "module";
Class.include($0)"""
    static member inline mergeOptions (props: obj): obj =
        emitJsExpr (props) $$"""
import { Class } from "module";
Class.mergeOptions($0)"""
    static member inline addInitHook (initHookFn: (unit -> unit)): obj =
        emitJsExpr (initHookFn) $$"""
import { Class } from "module";
Class.addInitHook($0)"""
    static member inline addInitHook (methodName: string, [<ParamArray>] args: obj []): obj =
        emitJsExpr (methodName, args) $$"""
import { Class } from "module";
Class.addInitHook($0, $1)"""
    static member inline callInitHooks () : unit =
        emitJsExpr () $$"""
import { Class } from "module";
Class.callInitHooks()"""

(***)
#r "nuget: Fable.Core"
(***)
