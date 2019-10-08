let float2cfrac (x : float) : int list =
    let rec rfloat2cfrac (x : float) (acclist : int list) : int list =
        let qi = int x
        let ri = x - (float qi)
        if ri <= 0.0 then
            acclist
        else
            rfloat2cfrac (1.0/ri) (qi :: acclist)
    rfloat2cfrac x []
printfn "%A" (float2cfrac 3.245)