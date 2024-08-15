/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    //Each list represents a 0 to positive integer where each node in the list contains one digit of the integer
    //**Each node contains only ONE DIGIT (not one number), and are stored in reverse order
    //*A leading zero should represent a number of zero, ie. no following digits
    //***Task: return the sum of the two numbers represented in the lists

    private ListNode Result;

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var firstNum = GetNumber(l1);
        var secondNum = GetNumber(l2);

        if (firstNum + secondNum == 0) 
        {
            return new ListNode(0);
        } 

        return GenerateResult(firstNum + secondNum);
    }

    private int GetNumber(ListNode ln, int number = 0, int index = 0)
    {
        if (index == 0)
        {
            if (ln.val == 0)
                return 0;

            number = ln.val;
            if (ln.next != null)
                GetNumber(ln.next, number, index++);
            else
                return ln.val;
        }

        var multiplier = Math.Pow(10, index);
        number = ln.val*multiplier + number;

        if(ln.next != null)
            GetNumber(ln.next, number. index++);

        return number;
    }

    private ListNode GenerateResult(int resultNum, ListNode ln = null)
    {
        if (resultNum < 1)
        var resultDigit = resultNum % 10;
        resultNum /= 10;        
        var resultNode = new ListNode(resultDigit);
        if (resultNum == 0)
            return resultNode;
            
        if (ln != null)
        {
            ln.next = resultNode;
            GenerateResult(resultNum, resultNode);
        }            
    }
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}