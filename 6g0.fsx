let cfrac2float (lst : int list) : float =
    let length = lst.Length
    let rec rcfrac2float (lst : int list) (acc : float) : float =
        if lst.Length = 1 then
            acc
        else
            if lst.Length = length then
                rcfrac2float lst.Tail (float(lst.Tail.Head) + 1.0/(acc + float(lst.Head)))
            else
                rcfrac2float lst.Tail (float(lst.Tail.Head) + 1.0/(acc))
    rcfrac2float (List.rev lst) 0.0
printfn "%f" (cfrac2float [3;4;12;4])