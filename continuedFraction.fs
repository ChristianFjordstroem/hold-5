module continuedFraction
let cfrac2float lst =
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

let float2cfrac x =
    let rec rfloat2cfrac (x : float) (r : float) (acclist : int list) : int list =
        let q = int (x + 0.001)
        if r <= 0.0 then
            acclist
        else
            let r = x - (float q)
            rfloat2cfrac (1.0/r) r (q :: acclist)
    let r = rfloat2cfrac x 6000.0 []
    List.rev r

let frac2cfrac t n =
    let rec rfrac2cfrac (t : int) (n : int) (acclist : int list) =
        if n <= 0 then
            acclist
        else
            let q = t / n
            let r = t % n
            rfrac2cfrac n r (q :: acclist)
    let r = rfrac2cfrac t n []
    List.rev r

let cfrac2frac lst i =
    let rec cfrac2frac (lst : int list) (i : int) (acc : int * int) (accp : int * int) =
        if i = lst.Length then
            acc
        else
            let (tpp, npp) = accp
            let (tp, np) = acc
            let cur = lst.[i]
            let t = cur*tp+tpp
            let n = cur*np+npp
            cfrac2frac lst (i + 1) (t, n) (tp, np)
    cfrac2frac lst i (1, 0) (0, 1)