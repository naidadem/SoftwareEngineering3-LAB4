// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

module TESTLIST
   open LIST

   let test = Cons(Cons(Cons(Create, 1), 2), 3)
   printfn "test = %O" test
   printfn "test has %i elements" (Length test)
   printfn "Head(test) = %O" (Head test)
   printfn "Tail(test) = %O" (Tail test)
   printfn "Cons(test, GetByIndex(test, 2)) = %O" (Cons(test, GetByIndex(test, 2)))

   // TO DO: Add some code to test Count and CircShift here

   printfn "CircShift(test, 1) = %O" (CircularShift(test, 1))
   printfn "CircShift(test, 2) = %O" (CircularShift(test, 2))
   printfn "CircShift(test, 3)  = %O" (CircularShift(test, 3))

   // Counting how many times each element repeats in the list 

   let shiftList = [ 1; 2; 2]
   printfn "list = %O" shiftList

   printfn "Count(list, 1) = %O" (Count(shiftList, 1))
   printfn "Count(list, 2) = %O" (Count(shiftList, 2))

    

   printf "Press any key to exit..."
   ignore (System.Console.ReadKey(true))