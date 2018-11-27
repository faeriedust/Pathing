namespace Pathing.Tests.FSharp

open Xunit
open Pathing
open System

module PathingValidationTests = 
  [<Fact>]
  let ``Can construct AbsoluteDirectoryPath from valid path`` () =
    new AbsoluteDirectoryPath "C:\\" |> ignore

  [<Fact>]
  let ``Can construct RelativeDirectoryPath from valid path`` () =
    new RelativeDirectoryPath "." |> ignore

  [<Fact>]
  let ``Can construct AbsoluteFilePath from valid path`` () =
    new AbsoluteFilePath "C:\\x.txt" |> ignore

  [<Fact>]
  let ``Can construct RelativeFilePath from valid path`` () =
    new RelativeFilePath "x.txt" |> ignore
  


  [<Fact>]
  let ``Cannot construct AbsoluteDirectoryPath from null`` () =
    Assert.Throws<ArgumentNullException> (fun () -> 
      new AbsoluteDirectoryPath null |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct RelativeDirectoryPath from null`` () =
    Assert.Throws<ArgumentNullException> (fun () -> 
      new RelativeDirectoryPath null |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct AbsoluteFilePath from null`` () =
    Assert.Throws<ArgumentNullException> (fun () -> 
      new AbsoluteFilePath null |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct RelativeFilePath from null`` () =
    Assert.Throws<ArgumentNullException> (fun () -> 
      new RelativeFilePath null |> ignore) |> ignore



  [<Fact>]
  let ``Cannot construct AbsoluteDirectoryPath from empty string`` () =
    Assert.Throws<ArgumentException> (fun () -> 
      new AbsoluteDirectoryPath "" |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct RelativeDirectoryPath from empty string`` () =
    Assert.Throws<ArgumentException> (fun () -> 
      new RelativeDirectoryPath "" |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct AbsoluteFilePath from empty string`` () =
    Assert.Throws<ArgumentException> (fun () -> 
      new AbsoluteFilePath "" |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct RelativeFilePath from empty string`` () =
    Assert.Throws<ArgumentException> (fun () -> 
      new RelativeFilePath "" |> ignore) |> ignore
