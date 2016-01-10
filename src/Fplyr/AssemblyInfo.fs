namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Fplyr")>]
[<assembly: AssemblyProductAttribute("Fplyr")>]
[<assembly: AssemblyDescriptionAttribute("Fsharp data manipulation inspired by dplyr")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
