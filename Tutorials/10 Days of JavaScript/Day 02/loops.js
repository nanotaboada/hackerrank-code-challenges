/*
 * Complete the vowelsAndConsonants function.
 * Print your output using 'console.log()'.
 */
function vowelsAndConsonants(s) {
    
    const vowels = [];
    const consonants = [];

    for (const letter of s) {
        // vowels
        if ("aeiou".includes(letter)) {
            vowels.push(letter);
        // consonants
        } else {
            consonants.push(letter);
        }
    }

    vowels.forEach((letter) => {
        console.log(letter);
    });
    
    consonants.forEach((letter) => {
        console.log(letter);
    });
}
