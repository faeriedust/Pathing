namespace Pathing.Tests.FSharp

open Xunit
open Pathing

module PathConstructionTests = 
  [<Fact>]
  let ``Can construct AbsoluteDirectoryPath`` () =
    let x: AbsoluteDirectoryPath = "C:\\"
    ()

  [<Fact>]
  let ``Can construct RelativeDirectoryPath`` () =
    let x: RelativeDirectoryPath = "."
    ()

  [<Fact>]
  let ``Can construct AbsoluteFilePath`` () =
    let x: AbsoluteFilePath = "C:\\x.txt"
    ()

  [<Fact>]
  let ``Can construct RelativeFilePath`` () =
    let x: AbsoluteFilePath = "x.txt"
    ()

