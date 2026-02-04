class Solution:
    def reformat(self, s):
        alps = []
        nums = []
        for c in s:
            if c >= '0' and c <= '9':
                nums.append(c)
            else:
                alps.append(c)
        
        if abs(len(alps) - len(nums)) >= 2:
            return ""

        g = []
        l = []
        if len(alps) >= len(nums):
            g = alps
            l = nums
        else:
            g = nums
            l = alps
        
        ret = ""
        x = 0
        for i in range(len(s)):
            if i % 2 == 0:
                ret += g[x]
            else:
                ret += l[x]
                x += 1
        
        return ret
