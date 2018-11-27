namespace Pathing.Tests.FSharp

open Xunit
open Pathing
open System

module PathParsingTests =
  open System.Collections.Generic

  [<Fact>]
  let ``Relative directory path "x" has one segment`` () =
   let path = RelativeDirectoryPath.Create "x" in
   let segmentCount = path.Segments |> Seq.length in
   Assert.Equal(1, segmentCount)
    
  [<Fact>]
  let ``Relative directory path ".\\x" has two segments`` () =
    let expected = ["."; "x"] |> Seq.map PathSegment.Create in
    let path = RelativeDirectoryPath.Create ".\\x" in 
    let getName = fun (x:PathSegment) -> x.Name in
    Assert.Equal<string>(expected |> Seq.map getName, path.Segments |> Seq.map getName)
