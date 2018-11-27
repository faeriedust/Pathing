namespace Pathing.Tests.FSharp

open Xunit
open Pathing
open System

module PathParsingTests =
  open System.Collections.Generic

  [<Fact>]
  let ``Relative directory path "x" has one segment`` () =
   RelativeDirectoryPath.Create "x"
    |> fun p -> p.Segments
    |> Seq.length
    |> fun segmentCount -> Assert.Equal(1, segmentCount)  
    
  [<Fact>]
  let ``Relative directory path ".\\x" has two segments`` () =
    let expected = ["."; "x"] |> Seq.map PathSegment.Create in
    RelativeDirectoryPath.Create ".\\x" |> fun p -> Assert.Equal<string>(expected |> Seq.map(fun x->x.Name), p.Segments |> Seq.map(fun x->x.Name))
