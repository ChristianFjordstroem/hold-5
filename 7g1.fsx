let readText (filename : string) : string =
    let filename = filename
    let text = 
        try
        let reader = System.IO.File.OpenText filename
        reader.ReadToEnd ()
        with
        _ -> "" // The file cannot be read, so we return an empty string

printfn "%s" (readText "readFile.fsx")