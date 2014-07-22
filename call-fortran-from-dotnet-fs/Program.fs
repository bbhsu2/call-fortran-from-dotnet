open System.Runtime.InteropServices

module FortranInterop =
    
    [<DllImport ("funcs.dll", CallingConvention=CallingConvention.Cdecl)>]
    extern double __mod_funcs_MOD_secs2mins(double& seconds)

    [<DllImport ("funcs.dll", CallingConvention=CallingConvention.Cdecl)>]
    extern double __mod_funcs_MOD_mins2secs(double& minutes)

[<EntryPoint>]
let main argv = 

    //example 1
    let mins2secs (x:float) = 
        let mutable y = x
        FortranInterop.__mod_funcs_MOD_mins2secs(&y)

    let minutes = 55.5
    let seconds = mins2secs minutes
    printfn "%A" seconds 


    //example 2
    let secs2mins (x:float) = 
        let mutable y = x
        FortranInterop.__mod_funcs_MOD_secs2mins(&y)

    let seconds = 1800.0
    let minutes = secs2mins seconds
    printfn "%A" minutes 
    

    //loop example
    let rnd = new System.Random()
    let bernard (x: float) = 
        let mutable y = x
        FortranInterop.__mod_funcs_MOD_secs2mins(&y)
    let rec fortran x=
        if x < 1 then 1
        else
            printfn "%A" (bernard (double(rnd.Next())))
            fortran (x-1)
    fortran 1000 

    System.Console.ReadLine() |> ignore
    0