namespace Pathing.Tests.FSharp

open Xunit
open Pathing
open System

module PathParsingTests =
  open System.Collections.Generic

  [<Fact>]
  let ``Relative directory path "x" has one segment`` () =
    new RelativeDirectoryPath "x"
    |> fun p -> p.Segments
    |> Seq.length
    |> fun segmentCount -> Assert.Equal(1, segmentCount)  
    
  [<Fact>]
  let ``Relative directory path ".\\x" has two segments`` () =
    let expected = ["."; "x"] |> Seq.map (fun x -> new PathSegment(x)) in
    new RelativeDirectoryPath(".\\x") |> fun p -> Assert.Equal<string>(expected |> Seq.map(fun x->x.Name), p.Segments |> Seq.map(fun x->x.Name))
