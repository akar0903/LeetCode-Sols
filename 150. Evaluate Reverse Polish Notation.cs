public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach(var token in tokens){
            if(!int.TryParse(token,out int x)){
                int b = stack.Pop();
                int a = stack.Pop();
                switch(token){
                    case "+": stack.Push(a+b); break;
                    case "-": stack.Push(a-b); break;
                    case "*": stack.Push(a*b); break;
                    case "/": stack.Push(a/b); break;
                }
            }
            else{
                stack.Push(x);
            }
        }
        return stack.Pop();
    }
}
