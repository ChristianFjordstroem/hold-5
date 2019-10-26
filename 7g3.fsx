let alphabet = ['a'..'z']@[' ']

/// <summary> Generate a histogram of the characters 'a'..'z' and ' ' in a given
/// string. </summary>
/// <param name = "str"> Any string consisting of the characters: 'a'..'z' and
/// ' ' in any order. </param>
/// <returns> A list of character counts, with the first element is the count of
/// 'a's in str, second the count of 'b's etc. </returns>

let histogram (src : string) : int list =
    List.map (fun char -> 
        let rec amountOfChar (index : int) (acc : int) : int = 
            match index with
            | index when index >= 0 ->
                match char = src.[index] with
                | true -> (amountOfChar (index-1) (acc+1))
                | _ -> (amountOfChar (index-1) (acc))
            | _ -> acc
        amountOfChar (src.Length-1) 0
    ) alphabet
    

printfn "%A" (histogram "abc def ghi jkl mno pqr stu vwx yz")