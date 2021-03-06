type F = 
  | AM
  | PM

type TimeOfDay = { hours : int; minutes : int; f: F }

let (.>.) x y =
 match (x,y) with
  | (x,y) when x.f= PM && y.f= AM -> true
  | (x,y) when x.f= AM && y.f= PM -> false
  | (x,y)                         -> x > y
  | _                             -> false
