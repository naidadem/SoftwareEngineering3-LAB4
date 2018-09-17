
module LIST
   type List<'Element when 'Element: equality> = 
   | Create 
   | Cons of 'Element List * 'Element
      override l.ToString() = "[" + l._ToString() + "]"
      member private l._ToString() =
         match l with 
         | Create -> "" 
         | Cons (Create, e) -> e.ToString()
         | Cons (l1, e) -> l1._ToString() + ", " + e.ToString()

   let rec Length l =
      match l with Create -> 0 | Cons (l', v) -> 1 + Length l'

   let rec Head l =
      match l with 
      | Create -> failwith "Head of empty list" 
      | Cons (Create, e) -> e 
      | Cons (l', e) -> Head l'

   let rec Tail l =
      match l with 
      | Create -> Create 
      | Cons (Create, e) -> Create
      | Cons (l', e) -> if l' = Create then Create else Cons (Tail l', e)

   let rec _GetByIndex (l, n) =
      match n with
      |  1 -> Head l
      |  _ -> _GetByIndex (Tail l, n - 1)

   let GetByIndex (l, n) =      // What happens if l = Create?
      if n < 1 || n > Length l then 
         failwith "Index out of bounds"
      else
         _GetByIndex (l, n)

        
// TO DO: Add implementation of Count and CircShift here

// old code

   //let rec rotate l n =
   //     match l, n with
   //     |[],_-> []
   //     |l, 0 -> l
   //     |z::l, n -> rotate (l @ [z]) (n-1)

   //let rec CircShift (l,n) =         
   //     let rec shiftList l n =
   //         match l,n with
   //         |l, 0 -> []
   //         |l, n-> (rotate l ((List.length l)-n))
   //     shiftList l n

   // for correction of Lab 4.1 we used recursion 

   let rec CircularShift(list,n) =
        if (n-1) >= 0 then
            CircularShift((Cons (Tail list, Head list)), (n-1))
        else
            list

    // We changed our function CircularShift in a way that now it is working in recursive way.
    // It takes two arguments list - that should be shifted  and n - number of the shifting times

   let El b = 
        Seq.filter b >> Seq.length

   let Count(list, m) =
        let counter = list |> El ( fun n -> n = m )
        counter

    // We didn't change function Count
    // This function returns number of times when some number, that is sent as parameter m, is repeated in the list