def strings_xor(s, t):
    res = ""
    for i in range(len(s)):
        if s[i] == t[i]: #modified
            res += '0'; #modified
        else:
            res += '1'; #modified

    return res

s = input()
t = input()
print(strings_xor(s, t))
