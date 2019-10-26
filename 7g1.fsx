/// <summary> Read the contents of a file </summary>
/// <param name = "filename"> The name of a file as a string </param>
/// <returns> The contents of the specified file as a string </param>

let readText (filename : string) : string =
    let filename = filename
    let text = 
        try
        let reader = System.IO.File.OpenText filename
        reader.ReadToEnd ()
        with
        _ -> "" // The file cannot be read, so we return an empty string

printfn "%s" (readText "readFile.fsx")