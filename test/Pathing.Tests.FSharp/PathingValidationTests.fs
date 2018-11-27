namespace Pathing.Tests.FSharp

open Xunit
open Pathing
open System

module PathingValidationTests = 
  [<Fact>]
  let ``Can construct AbsoluteDirectoryPath from valid path`` () =
    AbsoluteDirectoryPath.Create "C:\\" |> ignore

  [<Fact>]
  let ``Can construct RelativeDirectoryPath from valid path`` () =
    RelativeDirectoryPath.Create "." |> ignore

  [<Fact>]
  let ``Can construct AbsoluteFilePath from valid path`` () =
    AbsoluteFilePath.Create "C:\\x.txt" |> ignore

  [<Fact>]
  let ``Can construct RelativeFilePath from valid path`` () =
    RelativeFilePath.Create "x.txt" |> ignore
  


  [<Fact>]
  let ``Cannot construct AbsoluteDirectoryPath from null`` () =
    Assert.Throws<ArgumentNullException> (fun () -> 
      AbsoluteDirectoryPath.Create null |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct RelativeDirectoryPath from null`` () =
    Assert.Throws<ArgumentNullException> (fun () -> 
      RelativeDirectoryPath.Create null |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct AbsoluteFilePath from null`` () =
    Assert.Throws<ArgumentNullException> (fun () -> 
      AbsoluteFilePath.Create null |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct RelativeFilePath from null`` () =
    Assert.Throws<ArgumentNullException> (fun () -> 
      RelativeFilePath.Create null |> ignore) |> ignore



  [<Fact>]
  let ``Cannot construct AbsoluteDirectoryPath from empty string`` () =
    Assert.Throws<ArgumentException> (fun () -> 
      AbsoluteDirectoryPath.Create "" |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct RelativeDirectoryPath from empty string`` () =
    Assert.Throws<ArgumentException> (fun () -> 
      RelativeDirectoryPath.Create "" |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct AbsoluteFilePath from empty string`` () =
    Assert.Throws<ArgumentException> (fun () -> 
      AbsoluteFilePath.Create "" |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct RelativeFilePath from empty string`` () =
    Assert.Throws<ArgumentException> (fun () -> 
      RelativeFilePath.Create "" |> ignore) |> ignore
