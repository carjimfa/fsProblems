let sourceArray = [1;2;3;4;5;6;7;8;9;1;23;5;3;1]

let rec findMaximum2 sourceArray (max:int) =
    match sourceArray with
    | []-> max
    | first::rest -> if first > max then findMaximum2 rest first else findMaximum2 rest max


let findMaximum sourceArray=
    findMaximum2 sourceArray 0

findMaximum sourceArray