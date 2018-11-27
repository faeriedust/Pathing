namespace Pathing

type AbsoluteDirectoryPath = string
type RelativeDirectoryPath = string
type AbsoluteFilePath = string
type RelativeFilePath = string

module Pathing =
  let ToAbsoluteDirectoryPath p = p
  let ToRelativeDirectoryPath p = p
  let ToAbsoluteFilePath p = p
  let ToRelativeFilePath p = p



//type Foo() = class end

//type Test() =
//    member this.AcceptFoo(foo:Foo) = //passed from C#
//        if isNull foo then nullArg "foo"
//        else ...

//    member this.AcceptFoo2(foo:Foo) = //passed from C#
//        match foo with
//        | Null -> nullArg "foo"
//        | _ -> ...

//    member this.AcceptBoxedFoo(boxedFoo:obj) =
//        let foo : Foo = safeUnbox boxedFoo
//        ...

//    member this.ReturnFoo() : Foo = //returning to C#
//        if (test) then new Foo()
//        else nil