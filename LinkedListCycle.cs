using System.Runtime.CompilerServices;

namespace AlgoritmaSoruları;

public class LinkedListCycle
{
    public static bool HasCycle(ListNode head) {
        
        if (head == null || head.next == null) {
            return false;
        }

        ListNode yavas = head;
        ListNode hizli = head;
        
        while (hizli != null && hizli.next != null) {
            yavas = yavas.next;           
            hizli = hizli.next.next;      
            
            if (yavas == hizli) {
                return true;
            }
        }
        
        return false;
    }
}

public class ListNode 
{
    public int val;
    public ListNode next;
    
    public ListNode(int x) 
    {
        val = x;
        next = null;
    }
}