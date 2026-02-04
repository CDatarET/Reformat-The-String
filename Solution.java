class Solution {
    public String reformat(String s) {
        int a = 0;
        char[] alps = new char[s.length()];

        int n = 0;
        char[] nums = new char[s.length()];

        for(int i = 0; i < s.length(); i++){
            char c = s.charAt(i);
            if(c >= '0' && c <= '9'){
                nums[n++] = c;
            }
            else{
                alps[a++] = c;
            }
        }

        if(Math.abs(a - n) >= 2){
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
        for(int i = 0; i < s.length(); i++){
            if(i % 2 == 0){
                ret.append(g[x]);
            }
            else{
                ret.append(l[x++]);
            }
        }

        return(ret.toString());
    }
}
