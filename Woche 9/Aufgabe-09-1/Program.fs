module Program
open Mini

// b)
let rec queryNat (msg: String): Nat =
    putstring (msg)
    let s = getline ()
    if s <> "" && String.forall Char.IsDigit s then readNat (s)
                                               else putline ("Eingabe ist keine natürliche Zahl.")
                                                    queryNat (msg)

// c)
let main(): Unit =
    putline ("Gib drei Zahlen ein.")
    let n1 = queryNat ("Erste Zahl: ")
    let n2 = queryNat ("Zweite Zahl: ")
    let n3 = queryNat ("Dritte Zahl: ")
    putline ("Das Minimum der drei Zahlen ist " + (string (min (min n1 n2) n3) + "."))
