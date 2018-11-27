namespace Pathing.Tests.FSharp

open Xunit
open Pathing
open System

module PathingTests = 
  [<Fact>]
  let ``Can construct AbsoluteDirectoryPath`` () =
    Pathing.ToAbsoluteDirectoryPath "C:\\" |> ignore

  [<Fact>]
  let ``Can construct RelativeDirectoryPath`` () =
    Pathing.ToRelativeDirectoryPath "." |> ignore

  [<Fact>]
  let ``Can construct AbsoluteFilePath`` () =
    Pathing.ToAbsoluteFilePath "C:\\x.txt" |> ignore

  [<Fact>]
  let ``Can construct RelativeFilePath`` () =
    Pathing.ToRelativeFilePath "x.txt" |> ignore

