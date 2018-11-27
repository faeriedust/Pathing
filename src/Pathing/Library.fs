namespace Pathing

type PathSegment(name) =
  member this.Name = name

[<AbstractClass>]
type AbstractPath(path) =    
  do match path with
     | null -> nullArg "path" 
     | "" -> invalidArg "path" "'' is not a valid path."
     | _ -> ()
     
  member this.Segments = Seq.singleton path

type AbsoluteDirectoryPath(path) =
  inherit AbstractPath(path)

type RelativeDirectoryPath(path) =
  inherit AbstractPath(path)

type AbsoluteFilePath(path) = 
  inherit AbstractPath(path)

type RelativeFilePath(path) = 
  inherit AbstractPath(path)
