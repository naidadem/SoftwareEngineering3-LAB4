<<<<<<< HEAD
﻿module LIST
   type List<'Element when 'Element: equality> = Create | Cons of 'Element List * 'Element 
   val Length : 'Element List -> int
   val Head : 'Element List -> 'Element
   val Tail : 'Element List -> 'Element List
   val GetByIndex : 'Element List * int -> 'Element
// TO DO: Add signatures of Count and CircShift here

=======
﻿module LIST
   type List<'Element when 'Element: equality> = Create | Cons of 'Element List * 'Element 
   val Length : 'Element List -> int
   val Head : 'Element List -> 'Element
   val Tail : 'Element List -> 'Element List
   val GetByIndex : 'Element List * int -> 'Element
// TO DO: Add signatures of Count and CircShift here

>>>>>>> 655411e87399c0fdbf548606111bb95b88173ba9
