﻿module Collections

//Arrays

//this is an array
let arr = [|1;2;3|]

//same as this
let arr2 = 
    [|
        1
        2
        3
    |]
    
//array of numb from 0 to 99
let arrOfNumb = [|0..99|]

//array with steps
let arrOfNumb2 = [|0..5..99|]

//Initialized from loop
let arrOfNumb3 = [|for i in 0..5..99 do yield i * i|]


//This is a function that returns a array 
let RandomFruits count = 
    let r = System.Random()
    let fruits = [|"apple";"orange";"pear"|]
    [|
        for i in 1..count do
        let index = r.Next(3);
        yield fruits.[index]
    |]
    
    
//This is a function that returns a array different way
//This One is not == to C# function RandomFruitsEnumerable!!!!!
let RandomFruits2 count = 
    let r = System.Random()
    let fruits = [|"apple";"orange";"pear"|]
    Array.init count (fun iteratorNo ->
        let index = r.Next(3)
        fruits.[index]
    )


//Access an element of index 0
//arr.[0]


//Array Iterating
let IteratingArray arrNumb =
    for num in arrNumb do
        printfn "i am number: %i" num

//Filtering Arrays
//What im gonna filter:
let arrNumb = [|for i in 0..5..99 do yield i * i|]

//base on condition
let IsEven n = n % 2 = 0

//filter results
let filterResults = Array.filter (fun x -> IsEven x) arrNumb

//Sorting filtering and Iterating in one go
let PrintLongWords(words: string[]) =
    words
    |> Array.filter(fun w -> w.Length > 8)
    |> Array.sort
    |> Array.iter(fun w -> printfn w)
