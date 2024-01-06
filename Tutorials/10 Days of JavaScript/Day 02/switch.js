function getLetter(s) {
    let letter;
    // Write your code here
    if ("aeiou".includes(s[0])) letter = "A";
    if ("bcdfg".includes(s[0])) letter = "B";
    if ("hjklm".includes(s[0])) letter = "C";
    if ("npqrstuvwxyz".includes(s[0])) letter = "D";

    return letter;
}
