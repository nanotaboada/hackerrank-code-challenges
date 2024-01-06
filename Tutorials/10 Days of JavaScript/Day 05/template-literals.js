function sides(literals, ...expressions) {
    /*
        The provided "s = P ± √(P² - 16A) / 4" is a variation of the more widely known
        "x = -b ± √(b² - 4ac) / 2a" to find the solutions (roots) of a quadratic equation,
        which is an equation of the form "ax² + bx + c = 0"
        
        The expression "(b² - 4ac)" is known as the discriminant.
    
        - If the discriminant is positive, the equation has two distinct real roots.
        - If the discriminant is zero, the equation has one repeated real root.
        - If the discriminant is negative, the equation has two complex roots
        (no real solutions).
    */
    
    let A = expressions[0];
    let P = expressions[1];
    
    let s1 = (P + discriminant(P, A)) / 4;
    let s2 = (P - discriminant(P, A)) / 4;
    
    return [s2, s1];
}

// √(P² - 16A)
function discriminant(perimeter, area) {

    return Math.sqrt(Math.pow(perimeter, 2) - 16 * area);

}