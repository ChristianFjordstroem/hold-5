let alphabet = ['a'..'z']@[' ']

let convertText (src : string) : string =
    let srcLower = src.ToLower()
    String.collect (fun char -> 
        match List.contains char alphabet with
        | true -> string char
        | _ -> "") srcLower

printfn "%s" (convertText "Aafahiuo4124whgeuZ zoih513''jo aw642eq")