let alphabet = ['a'..'z']@[' ']

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