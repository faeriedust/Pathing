namespace Pathing

open System
open System.Collections.Generic

type PathSegment = {
  Name:string
} 
with static member Create(name) = { Name = name };

module PathingHelpers = 
  let ParseSegments (path:string) :IEnumerable<PathSegment> = 
    match path with
     | null -> nullArg "path"
     | "" -> invalidArg "path" "'' is not a valid path."
     | _ -> path.Split('\\', '/') |> Seq.map (fun s -> { Name = s })

[<AbstractClass>]
type AbstractPath (segments) = 
  member __.Segments = segments

type AbsoluteDirectoryPath (segments) =
  inherit AbstractPath(segments)
  static member Create(name) = new AbsoluteDirectoryPath(name |> PathingHelpers.ParseSegments)

type RelativeDirectoryPath (segments) =
  inherit AbstractPath(segments)
  static member Create(name) = new RelativeDirectoryPath(name |> PathingHelpers.ParseSegments)

type AbsoluteFilePath (segments) = 
  inherit AbstractPath(segments)
  static member Create(name) = new AbsoluteFilePath(name |> PathingHelpers.ParseSegments)

type RelativeFilePath (segments) = 
  inherit AbstractPath(segments)
  static member Create(name) = new RelativeFilePath(name |> PathingHelpers.ParseSegments)
