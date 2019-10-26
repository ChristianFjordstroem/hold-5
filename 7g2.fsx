let alphabet = ['a'..'z']@[' ']

/// <summary> Converts a string to another string such that all letters are
/// converted to lower case, and removes all characters except a...z and space </summary>
/// <param name = "src"> A string of characters</param>
/// <returns> The original string converted to lower case, and with all characters
/// except for a...z and space removed </returns>

let convertText (src : string) : string =
    let srcLower = src.ToLower()
    String.collect (fun char -> 
        match List.contains char alphabet with
        | true -> string char
        | _ -> "") srcLower

printfn "%s" (convertText "Aafahiuo4124whgeuZ zoih513''jo aw642eq")