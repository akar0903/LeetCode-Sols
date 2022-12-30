class Solution(object):
    def romanToInt(self, s):
        """
        :type s: str
        :rtype: int
        """
        char = {"I": 1, "V": 5, "X": 10, "L": 50, "C": 100, "D": 500, "M": 1000}
        oper = []
        for i in range(len(s) - 1):
            if s[i] == "I" or s[i] == "X" or s[i] == "C":
                posi = True
                for j in range(i + 1, len(s)):
                    if char[s[j]] > char[s[i]]:
                        oper.append(-1 * char[s[i]])
                        posi = False
                        break
                if posi:
                    oper.append(char[s[i]])
            else:
                oper.append(char[s[i]])
        oper.append(char[s[-1]])
        return sum(oper)
Console
