/*
 * Create the function factorial here
 */
function factorial(n) {

    let factorial = 1;

    for(let i = n; i >= 1; i--) {
        factorial = factorial * i;
    }
    
    return factorial;
}
