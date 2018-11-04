let sourceArray=[1;2;3;4;5;6;7;8]

let rec sumOfSquares sourceArray=
    match sourceArray with
    | []->0
    | x::xs -> (x*x) + sumOfSquares xs

sumOfSquares sourceArray
