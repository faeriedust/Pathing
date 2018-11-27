namespace Pathing.Tests.FSharp

open Xunit
open Pathing
open System

module PathParsingTests =
  [<Fact>]
  let ``Relative directory path "x" has one segment`` () =
    new RelativeDirectoryPath "x"
    |> fun p -> p.Segments
    |> Seq.length
    |> fun segmentCount -> Assert.Equal(1, segmentCount)
