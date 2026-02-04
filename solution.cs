public class Solution {
    public string Reformat(string s) {
        int a = 0;
        char[] alps = new char[s.Length];

        int n = 0;
        char[] nums = new char[s.Length];

        for(int i = 0; i < s.Length; i++){
            char c = s[i];
            if(c >= '0' && c <= '9'){
                nums[n++] = c;
            }
            else{
                alps[a++] = c;
            }
        }

        if(Math.Abs(a - n) >= 2){
            return("");
        }

        int x = 0;
        char[] g;
        char[] l;
        if(a >= n){
            g = alps;
            l = nums;
        }
        else{
            g = nums;
            l = alps;
        }
        StringBuilder ret = new StringBuilder("");
        for(int i = 0; i < s.Length; i++){
            if(i % 2 == 0){
                ret.Append(g[x]);
            }
            else{
                ret.Append(l[x++]);
            }
        }

        return(ret.ToString());
    }
}
