module rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

[<Erase>]
type Exports =
    /// <param name="arg1">
    /// The name of the tag.
    /// </param>
    /// <param name="arg2">
    /// The number of the tag.
    /// </param>
    [<Import("isInlineTag", "module")>]
    static member isInlineTag (arg1: string, arg2: int) : bool = nativeOnly

(***)
#r "nuget: Fable.Core"
(***)
