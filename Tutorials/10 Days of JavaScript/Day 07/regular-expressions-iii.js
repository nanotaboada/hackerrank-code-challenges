function regexVar() {
    /*
     * Declare a RegExp object variable named 're'
     * It must match ALL occurrences of numbers in a string.
     */
    // https://regex101.com/r/NFY4ph/1
    const re = new RegExp("([0-9]+)+", "g");
    /*
     * Do not remove the return statement
     */
    return re;
}
