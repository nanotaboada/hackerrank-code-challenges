// The days of the week are: "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
function getDayName(dateString) {
    let dayName;
    // Write your code here
    const day = dateString.split('/')[1];
    // Months in JavaScript are 0-based,
    const month = dateString.split('/')[0] - 1;
    const year = dateString.split('/')[2];
    
    // https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/Date
    const date = new Date(year, month, day);
    
    // https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toLocaleDateString
        dayName = date.toLocaleDateString(undefined, { weekday: 'long' });
        
    return dayName;
}
