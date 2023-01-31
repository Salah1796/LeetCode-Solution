/**
 * @param {string} s
 * @return {number}
 */

/*
    Time complexity O(N)
    Space complexity O(1)
 */
var lengthOfLongestSubstring = function (s) {
    if (s.length == 0) return 0
    let substring = s[0]
    let maxLength = 1
    let newChar = ''
    let newSubstring = ""
    for (let index = 1; index < s.length; index++) {
        newChar = s[index];
        newSubstring = substring + newChar
        if (!hasRepeats(newSubstring)) {
            substring = newSubstring
            maxLength++
        }
        else {
            substring = newSubstring.slice(1)
        }
    }
    return maxLength
};

function hasRepeats(str) {
    return /(.).*\1/.test(str);
}