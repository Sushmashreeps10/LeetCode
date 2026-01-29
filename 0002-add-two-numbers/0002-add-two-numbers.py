# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution(object):
    def addTwoNumbers(self, l1, l2):
        """
        :type l1: Optional[ListNode]
        :type l2: Optional[ListNode]
        :rtype: Optional[ListNode]
        """
        # Create a dummy head to simplify list construction
        dummy = ListNode(0)
        curr = dummy
        carry = 0
        
        # Continue while there are nodes to process or a carry remains
        while l1 or l2 or carry:
            # Get values from nodes, or 0 if the list has ended
            val1 = l1.val if l1 else 0
            val2 = l2.val if l2 else 0
            
            # Calculate total and new carry
            total = val1 + val2 + carry
            carry = total // 10
            new_val = total % 10
            
            # Add new node to the result list
            curr.next = ListNode(new_val)
            
            # Move pointers forward
            curr = curr.next
            if l1: l1 = l1.next
            if l2: l2 = l2.next
            
        return dummy.next