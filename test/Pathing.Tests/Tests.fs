namespace Pathing.Tests

open Xunit
open Pathing

module PathConstructionTests = 
  [<Fact>]
  let ``Can construct a path`` () =
    let x: RelativeDirectoryPath = "C:\\"
    ()