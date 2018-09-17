<<<<<<< HEAD
﻿module LIST
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

=======
﻿module LIST
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

>>>>>>> 655411e87399c0fdbf548606111bb95b88173ba9
