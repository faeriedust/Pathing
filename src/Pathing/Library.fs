namespace Pathing

open System

type PathSegment = {
  Name:string
}
with static member Create(name) = { Name = name }

[<AbstractClass>]
type AbstractPath (path) =    
  do match path with
     | null -> nullArg "path"
     | "" -> invalidArg "path" "'' is not a valid path."
     | _ -> ()
     
  member this.Segments = 
    path.Split('\\', '/') 
    |> Seq.map (fun s -> { Name = s })

type AbsoluteDirectoryPath private(path) =
  inherit AbstractPath(path)
  static member Create(name) = new AbsoluteDirectoryPath(name)

type RelativeDirectoryPath private(path) =
  inherit AbstractPath(path)
  static member Create(name) = new RelativeDirectoryPath(name)

type AbsoluteFilePath private(path) = 
  inherit AbstractPath(path)
  static member Create(name) = new AbsoluteFilePath(name)

type RelativeFilePath private(path) = 
  inherit AbstractPath(path)
  static member Create(name) = new RelativeFilePath(name)
