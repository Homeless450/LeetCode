using LeetCode.Solutions;
using LeetCode.Solutions._05;
using LeetCode.Solutions._06;
using System.Diagnostics.Metrics;

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


        int[][] matrix =
{
            new int[] { 1, 1, 0, 0, 1 },
            new int[] { 1, 1, 1, 1, 0 },
            new int[] { 1, 0, 1, 0, 0 },
            new int[] { 1, 1, 0, 1, 0 },
            new int[] { 1, 1, 1, 1, 1 }
        };

        //need to rework
        /*        KWeakestRowsTask rows = new KWeakestRowsTask();

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
        ListNode list2 = new ListNode(3, list3);
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


        /*        //Ransom
                RansomNote rans = new RansomNote();
                Console.WriteLine(rans.CanConstruct("jjj", "hjibagacbhadfaefdjaeaebgi"));
        */
        //Dota2 Senate
        /*        Dota2Senate dota = new Dota2Senate();
                Console.WriteLine(dota.PredictPartyVictory("RDD"));*/

        /*        //Two Sum
                SumOf2 sumOf2 = new SumOf2();
                int[] arr = { 3, 2, 4 };
                Console.WriteLine(sumOf2.TwoSum(arr, 6)[0]);
                Console.WriteLine(sumOf2.TwoSum(arr, 6)[1]);*/

        /*        //Substring
                LongestSubstring substring = new LongestSubstring();
                Console.WriteLine(substring.LengthOfLongestSubstring("pwwkew"));*/

        //Longest Palindrom
        /*        PalindromicSubstring palindromicSubstring = new PalindromicSubstring();
                Console.WriteLine(palindromicSubstring.LongestPalindrome("jrjnbctoqgzimtoklkxcknwmhiztomaofwwzjnhrijwkgmwwuazcowskjhitejnvtblqyepxispasrgvgzqlvrmvhxusiqqzzibcyhpnruhrgbzsmlsuacwptmzxuewnjzmwxbdzqyvsjzxiecsnkdibudtvthzlizralpaowsbakzconeuwwpsqynaxqmgngzpovauxsqgypinywwtmekzhhlzaeatbzryreuttgwfqmmpeywtvpssznkwhzuqewuqtfuflttjcxrhwexvtxjihunpywerkktbvlsyomkxuwrqqmbmzjbfytdddnkasmdyukawrzrnhdmaefzltddipcrhuchvdcoegamlfifzistnplqabtazunlelslicrkuuhosoyduhootlwsbtxautewkvnvlbtixkmxhngidxecehslqjpcdrtlqswmyghmwlttjecvbueswsixoxmymcepbmuwtzanmvujmalyghzkvtoxynyusbpzpolaplsgrunpfgdbbtvtkahqmmlbxzcfznvhxsiytlsxmmtqiudyjlnbkzvtbqdsknsrknsykqzucevgmmcoanilsyyklpbxqosoquolvytefhvozwtwcrmbnyijbammlzrgalrymyfpysbqpjwzirsfknnyseiujadovngogvptphuyzkrwgjqwdhtvgxnmxuheofplizpxijfytfabx"));
        */
        /*    //Zigzag

                ZigZagConverter zig = new ZigZagConverter();
                Console.WriteLine(zig.Convert("AB", 1));*/


        /*        //Simple Number Palindrom Task
                NumbersPalindrom numbersPalindrom = new NumbersPalindrom();
                Console.WriteLine(numbersPalindrom.IsPalindrome(121));*/

        //Matrix Diagonal Sum
        MatrixDiagonalSum matrixDiagonalSum = new MatrixDiagonalSum();
        Console.WriteLine(matrixDiagonalSum.DiagonalSum(matrix));

        SumOf2ListNode sumOf2ListNode = new SumOf2ListNode();
        Console.WriteLine(sumOf2ListNode.AddTwoNumbers(list, list));

        ValidParentheses validParentheses = new ValidParentheses();
        Console.WriteLine(validParentheses.IsValid("()[]{}"));

        //Container With Most Water
        //
        int[] waterArr = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        MaxWater maxWater = new MaxWater();
        Console.WriteLine(maxWater.MaxArea(waterArr));

        //Longest Prefix
        string[] strs = { "flower", "flow", "flight" };
        LongestPrefix longestPrefix = new LongestPrefix();
        Console.WriteLine(longestPrefix.LongestCommonPrefix(strs));

        //Merge 2 sorted lists
        ListNode MergeList6 = new ListNode(6);
        ListNode MergeList5 = new ListNode(5, MergeList6);
        ListNode MergeList4 = new ListNode(4, MergeList5);
        ListNode MergeList3 = new ListNode(3, MergeList4);
        ListNode MergeList2 = new ListNode(2, MergeList3);
        ListNode mergeList1 = new ListNode(1, MergeList2);

/*        MergeChainedList mergeChainedList = new MergeChainedList();
        Console.WriteLine(mergeChainedList.MergeTwoLists(MergeList3, MergeList2).val);
*/
        //Convert string to int
/*        StringToInteger stringToInteger = new StringToInteger();
        Console.WriteLine(stringToInteger.MyAtoi("-91283472332"));
*/
        //Remove Value By Index In Node List
/*        RemoveByIndexInNodeList removeByIndexInNodeList = new RemoveByIndexInNodeList();
        Console.WriteLine(DisplayNodeList(removeByIndexInNodeList.RemoveNthFromEnd(mergeList1, 4)));
*/
        //int[] nums = { 1, 2, 3, 4 , 5 };
        int[] nums = { 1, 3, 5, 6 };
        //Remove duplicates
        /*        RemoveDuplicatesFromSortedArray removeDuplicatesFromSortedArray = new RemoveDuplicatesFromSortedArray();
                Console.WriteLine("////");
                Console.WriteLine(removeDuplicatesFromSortedArray.RemoveDuplicates(nums));
        */
        //Remove From array

/*        RemoveFromArray removeFromArray = new RemoveFromArray();
        Console.WriteLine(removeFromArray.RemoveElement(nums, 2));
*/

/*        //Letter_Combinations_of_a_Phone_Number
        Letter_Combinations_of_a_Phone_Number letter_comb = new Letter_Combinations_of_a_Phone_Number();
        Console.WriteLine(letter_comb.LetterCombinations("234"));


        //Find the index
        Find_the_Index_of_the_First_Occurrence_in_a_String indexFinder = new Find_the_Index_of_the_First_Occurrence_in_a_String();
        Console.WriteLine(indexFinder.StrStr("mississippi", "pi"));

        //Rotate array
        Rotate_Array rotate_Array = new Rotate_Array();
        rotate_Array.Rotate(nums, 5);
        foreach (int i in nums)
        {
            Console.WriteLine(i);
        }

        //First Bad Version
        First_Bad_Version first_Bad_Version = new First_Bad_Version();
        Console.WriteLine(first_Bad_Version.FirstBadVersion(3));

        //Search insert Pos
        int[] nums1 = { 8, -19, 5, -4, 20 };
        Search_Insert_Position search_Insert_Position = new Search_Insert_Position();
        Console.WriteLine(search_Insert_Position.SearchInsert(nums1, 4));

        //Max SubArray
        Maximum_Subarray maximum_Subarray = new Maximum_Subarray();
        Console.WriteLine(maximum_Subarray.MaxSubArray(nums1));

        //Two Sums II
        int[] sumsNumbers = { 5, 25, 75 };
        Two_Sum_II___Input_Array_Is_Sorted two_Sum_II___Input_Array_Is_Sorted = new Two_Sum_II___Input_Array_Is_Sorted();
        Console.WriteLine(two_Sum_II___Input_Array_Is_Sorted.TwoSum(sumsNumbers, 100));


        //Reverse string
        char[] stringa = { 'h', 'e', 'l', 'l', 'o' };
        Reverse_String reverse_String = new Reverse_String();
        reverse_String.ReverseString(stringa);


        //Two Sum
        int[] numberTwoSum = { 2, 7, 11, 15 };
        Two_Sum two_Sum = new Two_Sum();
        two_Sum.TwoSum(numberTwoSum, 9);
*/
        //Reshape Matrix
        int[][] matrixForReshape = new int[2][];
        matrixForReshape[0] = new int[] { 1, 2 };
        matrixForReshape[1] = new int[] { 3, 4 };
        Reshape_the_Matrix reshape_The_Matrix   = new Reshape_the_Matrix();
        reshape_The_Matrix.MatrixReshape(matrixForReshape, 4, 1);


        //Pascal's Triangle
        Pascal_s_Triangle pascal_S_Triangle = new Pascal_s_Triangle();
        pascal_S_Triangle.Generate(5);















        //help Methods

        string DisplayNodeList (ListNode list)
        {
            string result = string.Empty;
            while (list != null)
            {
                result += list.val.ToString();
                list = list.next;
            }
            return result;
        }
    }
}