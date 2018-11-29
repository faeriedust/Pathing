namespace Pathing.Tests.FSharp

open Xunit
open Pathing
open System.Collections.Generic

module PathParsingTests =

  [<Fact>]
  let ``Relative directory path "x" has expected segment`` () =
   let path = RelativeDirectoryPath.Create "x" in
   let segmentCount = path.Segments |> Seq.length in
   Assert.Equal(1, segmentCount)
    
  [<Fact>]
  let ``Relative directory path ".\\x" has expected segments`` () =
    let expected = ["."; "x"] |> Seq.map PathSegment.Create in
    let path = RelativeDirectoryPath.Create ".\\x" in 
    let getName = fun (x:PathSegment) -> x.Name in
    Assert.Equal<string>(expected |> Seq.map getName, path.Segments |> Seq.map getName)

  [<Fact>]
  let ``Can create relative directory path from segments`` () = 
    let path = RelativeDirectoryPath.Create ".\\x" in
    let newPath = RelativeDirectoryPath path.Segments in
    ()
