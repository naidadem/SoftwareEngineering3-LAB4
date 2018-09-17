<<<<<<< HEAD
﻿// Learn more about F# at http://fsharp.net

module TESTLIST
   open LIST

   let test = Cons(Cons(Cons(Create, 1), 2), 3)
   printfn "test = %O" test
   printfn "test has %i elements" (Length test)
   printfn "Head(test) = %O" (Head test)
   printfn "Tail(test) = %O" (Tail test)
   printfn "Cons(test, GetByIndex(test, 2)) = %O" (Cons(test, GetByIndex(test, 2)))

   // TO DO: Add some code to test Count and CircShift here

   printf "Press any key to exit..."
=======
﻿// Learn more about F# at http://fsharp.net

module TESTLIST
   open LIST

   let test = Cons(Cons(Cons(Create, 1), 2), 3)
   printfn "test = %O" test
   printfn "test has %i elements" (Length test)
   printfn "Head(test) = %O" (Head test)
   printfn "Tail(test) = %O" (Tail test)
   printfn "Cons(test, GetByIndex(test, 2)) = %O" (Cons(test, GetByIndex(test, 2)))

   // TO DO: Add some code to test Count and CircShift here

   printf "Press any key to exit..."
>>>>>>> 655411e87399c0fdbf548606111bb95b88173ba9
   ignore (System.Console.ReadKey(true))