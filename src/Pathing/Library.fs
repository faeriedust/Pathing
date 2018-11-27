namespace Pathing

type AbsoluteDirectoryPath = string
type RelativeDirectoryPath = string
type AbsoluteFilePath = string
type RelativeFilePath = string

module Pathing =
  let ToAbsoluteDirectoryPath path:string = 
    match path with
    | Null -> nullArg "path"
    | _ -> path

  let ToRelativeDirectoryPath path:string = 
    match path with
    | Null -> nullArg "path"
    | _ -> path

  let ToAbsoluteFilePath path:string = 
    match path with
    | Null -> nullArg "path"
    | _ -> path

  let ToRelativeFilePath path:string =
    match path with
    | Null -> nullArg "path"
    | _ -> path
