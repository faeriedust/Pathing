[<AutoOpen>]
//TODO Add tests for this
module Interop 
    let inline isNull value = System.Object.ReferenceEquals(value, null)
    let inline nil<'T> = Unchecked.defaultof<'T>
    let inline safeUnbox value = if isNull value then nil else unbox value
    let (|Null|_|) value = if isNull value then Some() else None
