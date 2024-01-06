function regexVar() {
    /*
     * Declare a RegExp object variable named 're'
     * It must match a string that starts and ends with the same vowel (i.e., {a, e, i, o, u})
     */
    // https://regex101.com/r/VASS7y/2
    const re = new RegExp("^([aeiou]).*\\1$");
    /*
     * Do not remove the return statement
     */
    return re;
}
