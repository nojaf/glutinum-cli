module rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

[<Erase>]
type Exports =
    [<Import("Test", "module")>]
    static member Test () : Exports.Test = nativeOnly

module Exports =

    [<Global>]
    [<AllowNullLiteral>]
    type Test
        [<ParamObject; Emit("$0")>]
        (
            a: string,
            b: float
        ) =

        member val a : string = nativeOnly with get, set
        member val b : float = nativeOnly with get, set

(***)
#r "nuget: Fable.Core"
(***)
