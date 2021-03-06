// 16.1
let notDivisible = function
 | (0,m) -> false
 | (n,m) -> m % n = 0

// 16.2
let prime = function
 | 0 | 1 -> false
 | n -> 
   let rec check i =
       i > n/2 || (n % i <> 0 && check (i + 1))
   check 2
