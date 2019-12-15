namespace ExampleAssembly
open FSharp.Data

module Say =
    type HelloType = JsonProvider<"./a.json", RootName = "Create", EmbeddedResource = "ExampleAssembly, a.json">

    let hello () =
        let helloType = HelloType.Create(foo = "baz")
        printfn "Hello %s" helloType.Foo
        helloType