namespace Pathing.Tests.FSharp

open Xunit
open Pathing
open System

module PathingValidationTests = 
  [<Fact>]
  let ``Can construct AbsoluteDirectoryPath from valid path`` () =
    Pathing.ToAbsoluteDirectoryPath "C:\\" |> ignore

  [<Fact>]
  let ``Can construct RelativeDirectoryPath from valid path`` () =
    Pathing.ToRelativeDirectoryPath "." |> ignore

  [<Fact>]
  let ``Can construct AbsoluteFilePath from valid path`` () =
    Pathing.ToAbsoluteFilePath "C:\\x.txt" |> ignore

  [<Fact>]
  let ``Can construct RelativeFilePath from valid path`` () =
    Pathing.ToRelativeFilePath "x.txt" |> ignore
  


  [<Fact>]
  let ``Cannot construct AbsoluteDirectoryPath from null`` () =
    Assert.Throws<ArgumentNullException> (fun () -> 
      Pathing.ToAbsoluteDirectoryPath null |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct RelativeDirectoryPath from null`` () =
    Assert.Throws<ArgumentNullException> (fun () -> 
      Pathing.ToRelativeDirectoryPath null |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct AbsoluteFilePath from null`` () =
    Assert.Throws<ArgumentNullException> (fun () -> 
      Pathing.ToAbsoluteFilePath null |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct RelativeFilePath from null`` () =
    Assert.Throws<ArgumentNullException> (fun () -> 
      Pathing.ToRelativeFilePath null |> ignore) |> ignore



  [<Fact>]
  let ``Cannot construct AbsoluteDirectoryPath from empty string`` () =
    Assert.Throws<ArgumentException> (fun () -> 
      Pathing.ToAbsoluteDirectoryPath "" |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct RelativeDirectoryPath from empty string`` () =
    Assert.Throws<ArgumentException> (fun () -> 
      Pathing.ToRelativeDirectoryPath "" |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct AbsoluteFilePath from empty string`` () =
    Assert.Throws<ArgumentException> (fun () -> 
      Pathing.ToAbsoluteFilePath "" |> ignore) |> ignore

  [<Fact>]
  let ``Cannot construct RelativeFilePath from empty string`` () =
    Assert.Throws<ArgumentException> (fun () -> 
      Pathing.ToRelativeFilePath "" |> ignore) |> ignore
