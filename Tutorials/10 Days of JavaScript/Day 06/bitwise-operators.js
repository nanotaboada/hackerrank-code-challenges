function getMaxLessThanK(n, k) {
    let maximum = 0;
    for (let a=n; a>1; a--){
        for (let b=a-1; b>0; b--) {
            // Note: The  symbol represents the bitwise AND operator.
            if (a & b < k 
                && a & b > maximum) {
                maximum = a & b;
            }
        }
    }
    return maximum;
}
