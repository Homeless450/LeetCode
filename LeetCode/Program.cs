using LeetCode.Solutions;

public static class Programm
{
    static void Main(string[] args)
    
    {

/*        //Roman to integer
        var s = Console.ReadLine();
        RomToInt romToInt = new RomToInt();
        var a = romToInt.RomanToInt(s);
        Console.WriteLine(a);
        //*/

/*        int n = Int32.Parse(Console.ReadLine());
        FizzBuzzTask task = new FizzBuzzTask();
        Console.WriteLine(task.FizzBuzz(n));*/

        //need to rework
/*        KWeakestRowsTask rows = new KWeakestRowsTask();
        int[][] b =
        {
            new int[] { 1, 1, 0, 0, 0 },
            new int[] { 1, 1, 1, 1, 0 },
            new int[] { 1, 0, 0, 0, 0 },
            new int[] { 1, 1, 0, 0, 0 },
            new int[] { 1, 1, 1, 1, 1 }
        };
        int[] c = rows.KWeakestRows(b, 3);
        foreach (int row in c)
        {
            Console.Write("{0}, ", row);
        }*/

        //Midle
        MiddleOfTheLinkedList middle = new MiddleOfTheLinkedList();
        ListNode list5 = new ListNode(0);
        ListNode list4 = new ListNode(1, list5);
        ListNode list3 = new ListNode(2, list4);
        ListNode list2 = new ListNode(0);
        ListNode list1 = new ListNode(0, list2);
        ListNode list = new ListNode(1, list1);   
        
/*        var index = 0;
        while (3 != index)
        {
            list = list.next;
            Console.WriteLine(middle.MiddleNode(list).val);
            index++;
        }*/
/*
        //Paly
        PalindromeCheck paly = new PalindromeCheck();
        Console.WriteLine(paly.IsPalindrome(list));*/


        //Ransom
        RansomNote rans = new RansomNote();
        Console.WriteLine(rans.CanConstruct("jjj", "hjibagacbhadfaefdjaeaebgi"));
    }
}