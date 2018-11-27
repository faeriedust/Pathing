namespace Pathing

type AbsoluteDirectoryPath = string
type RelativeDirectoryPath = string
type AbsoluteFilePath = string
type RelativeFilePath = string

module Pathing =
  let private checkNotNullOrEmpty path =
    match path with
    | null -> nullArg "path" 
    | "" -> invalidArg "path" "'' is not a valid path."
    | _ -> ()

  let ToAbsoluteDirectoryPath (path:string) = 
    checkNotNullOrEmpty path
    path

  let ToRelativeDirectoryPath (path:string) = 
    checkNotNullOrEmpty path
    path

  let ToAbsoluteFilePath (path:string) = 
    checkNotNullOrEmpty path
    path

  let ToRelativeFilePath (path:string) =
    checkNotNullOrEmpty path
    path
