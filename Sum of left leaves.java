class Solution {
    public int sumOfLeftLeaves(TreeNode root) {
        if(root==null)
        {
            return 0;
        }
        int sum_of_left_leaves=0;
        if(root.left!=null)
        {
            if(root.left.left == null && root.left.right == null)
            {
                sum_of_left_leaves += root.left.val;
            }
            else
            {
                sum_of_left_leaves += sumOfLeftLeaves(root.left);
            }
        }
        if(root.right!=null)
        {
            if(root.right.left != null || root.right.right != null)
            {
                sum_of_left_leaves += sumOfLeftLeaves(root.right);
            }
        }
        return sum_of_left_leaves;
    }
}
