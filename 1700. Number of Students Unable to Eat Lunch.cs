public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> queue = new Queue<int>(students);
        int sandwichIndex = 0;
        int attempts = 0;
        while(queue.Count > 0 && attempts < queue.Count){
            if(queue.Peek() == sandwiches[sandwichIndex]){
                queue.Dequeue();
                sandwichIndex++;
                attempts = 0;
            }
            else{
                queue.Enqueue(queue.Dequeue());
                attempts++;
            }
        }
        return queue.Count;
    }
}
