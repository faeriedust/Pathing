namespace Pathing.Tests.FSharp

open Xunit
open Pathing
open System

module PathingTests = 
  [<Fact>]
  let ``Can construct AbsoluteDirectoryPath`` () =
    Pathing.ToAbsoluteDirectoryPath "C:\\" |> ignore

  [<Fact>]
  let ``Can construct RelativeDirectoryPath`` () =
    Pathing.ToRelativeDirectoryPath "." |> ignore

  [<Fact>]
  let ``Can construct AbsoluteFilePath`` () =
    Pathing.ToAbsoluteFilePath "C:\\x.txt" |> ignore

  [<Fact>]
  let ``Can construct RelativeFilePath`` () =
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
