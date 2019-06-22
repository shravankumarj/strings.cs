using System;
using System.Collections.Generic;

namespace strings
{
  class Program
  {


    static void Main(string[] args)
    {
      //  test("g*ks", "geeks"); // Yes
      //   string txt = "Ourbusinessisourbusinessnoneofyourbusiness";
      //   string pat = "daisy";
      //   KMPSearch(pat, txt);
      //   // return 0;

      //  String[] keys= {"the", "a", "there", "answer", "any", 
      //                          "by", "bye", "their"}; 

      //         String[] output = {"Not present in trie", "Present in trie"}; 


      //         root = new TrieNode(); 

      //         // Construct trie 
      //         int i; 
      //         for (i = 0; i < keys.length ; i++) 
      //             insert(keys[i]); 
      //   string s="I will do it.";
      //   string res = reverse_ordering_of_words(s);
      //   System.Console.WriteLine(res);
      //       char[,] a = { { '1', '2', '3' },
      //                           { '7', '8', '9' },
      //                           { '1', '2', '3' }
      //       }; 



      // string s= spiralPrint(a);
      // System.Console.WriteLine(s);

      // string s = "geeksforgeeks";
      // string p = "for";

      // int i = SearchSubstringinStringBruteforce(s, p);
      // System.Console.WriteLine(i);
      // Console.ReadLine();
      // String[] keys = {"the", "a", "there", "answer",
      //                   "any", "by", "bye", "their"};

      // String[] output = { "Not present in trie", "Present in trie" };


      // Trie root = new Trie();

      // // Construct trie 
      // int i;
      // for (i = 0; i < keys.Length; i++)
      //   root.INSERT(keys[i]);



      // if (root.search("the") == true)
      //   Console.WriteLine("the --- " + output[1]);
      // else Console.WriteLine("the --- " + output[0]);

      // if (root.search("these") == true)
      //   Console.WriteLine("these --- " + output[1]);
      // else Console.WriteLine("these --- " + output[0]);

      // if (root.search("their") == true)
      //   Console.WriteLine("their --- " + output[1]);
      // else Console.WriteLine("their --- " + output[0]);

      // if (root.search("thaw") == true)
      //   Console.WriteLine("thaw --- " + output[1]);
      // else Console.WriteLine("thaw --- " + output[0]);

      // root.suggestionRec(null, "the");
      // Console.ReadLine();


      // string str = "forgeeksskeegfor";
      // int str1 = longestPalSubstr(str);
      // System.Console.WriteLine(str1);
      // Console.ReadLine();
      //   string text = "abcddd";
      //   string pattern = "abc*c*c*dd";

      //  bool result= RegexMatcher(text, pattern);

      //  System.Console.WriteLine(result);
      //  Console.ReadLine();
      // string s = "aabacbebebe";
      // int k = 2;
      // getLongestSubstringLengthExactly2DistinctChars(s, k);
      // Trie root = new Trie();

      // List<String> vect = new List<String>{"geekf", "geeks",
      //                       "or", "keeg", "abc", "bc"};

      // if (root.checkPalindromePair(vect) == true)
      //   System.Console.WriteLine("yes");
      // else
      //   System.Console.WriteLine("No");


      // Console.ReadLine();

      //  string str = getLongestRepeatedSubstringbruteDP("efabcdeefhabcdiefi");
      //  System.Console.WriteLine(str);
      // string[] str = neuronyms("nailed");
      // for (int i = 0; i < str.Length; i++)
      // {
      //   System.Console.WriteLine(str[i]);
      // }
      // string text = "you are very very smart";
      // List<String> words = new List<String> { "you", "are", "very", "handsome" };



      // List<List<int>> indicesofwords = find_indices_words(text, words);

      // for (int i = 0; i < indicesofwords.Count; i++)
      // {
      //   System.Console.WriteLine(indicesofwords[i]);
      // }
      // string s = "BACRDESDFBAER";
      // string t = "BAR";
      // //  result:BACR


      // string str = minimum_window(s, t);
      // System.Console.WriteLine(str);
      // string s = "Google Worked";
      // printStringSinusoidally(s);
      //       Output format:



      // Print the string in sinusoidally. Format is:

      // → There will be 3 rows

      // → Print ~ for spaces

      // → First character is printed in 1st column of 3rd row

      // → Second character is printed in 2nd column of 2nd row

      // → Third character is printed in 3rd column of 1st row

      // → Fourth character is printed in 4th column of 2nd row

      // → Fifth character is printed in 5th column of 3rd row

      // → Sixth character is printed in 6th column of 2nd row

      // → This process goes on…



      // Sample Output:



      //     o     ~         k

      //   o  g  e  W   r   e

      // G     l        o       d

      // Sample Test Case:
      // dictionary = [ “bst” , “heap” , “tree”]
      // mat = [ “bsh”  , ”tee” , ”arh” ]
      // Sample Output:
      // Function returns the list result = [ “bst” , “tree” ]
      // Explanation:
      // The input matrix is represented below:
      // bsh
      // tee
      // arh
      // Assume here top left-most corner is at (0,0) and bottom right-most corner is (2,2).
      // Presence of “bst” is marked bold in the below representation:
      // (0,0) -> (0,1) -> (1,0)
      // bsh
      // tee
      // arh
      // Presence of “tree” is marked bold in the below representation:
      // (1,0) -> (2,1) -> (1,1) -> (1,2)  
      // bsh
      // tee
      // arh
      // List<string> dictionary = new List<string> { "bst", "heap", "tree" };

      // List<string> mat = new List<string> { "bsh", "tee", "arh" };
      // List<string> str = boggle_solver(dictionary, mat);

      // string s = "I will do it.";
      // string str = reverse_ordering_of_words(s);
      // System.Console.WriteLine(str);
      string s = "0a193zbr";
      //output: azbr3zbr
      string str = move_letters_to_left_side_with_minimizing_memory_writes(s);
      System.Console.WriteLine(str);

      Console.ReadLine();

    }

    private static string move_letters_to_left_side_with_minimizing_memory_writes(string s)
    {
      char[] input = s.ToCharArray();
      int dIndex = 0;
      int aIndex = 0;

      while (aIndex < s.Length)
      {
        char c = input[aIndex];
        if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
        {
          input[dIndex] = input[aIndex];
          dIndex++;
        }
        aIndex++;
      }

      return new String(input);
    }

    private static string reverse_ordering_of_words(string s)
    {
      char[] arr = s.ToCharArray();

      reverse(arr, 0, arr.Length - 1);

      int k = 0;
      while (k < arr.Length)
      {
        if (arr[k] == ' ')
        {
          k++;
          continue;
        }
        else
        {
          int start = k;
          while (k < arr.Length && arr[k] != ' ')
          {
            k++;
          }

          int end = k - 1;
          reverse(arr, start, end);
        }
      }

      return new string(arr);
    }
    static void reverse(char[] arr, int start, int end)
    {
      int i = start;
      int j = end;
      while (i < j)
      {
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;

        i++;
        j--;
      }
    }

    private static List<string> boggle_solver(List<string> dictionary, List<string> mat)
    {
      throw new NotImplementedException();
    }

    private static void printStringSinusoidally(string s)
    {
      char[][] arr = new char[3][];

      for (int r = 0; r < 3; r++)
      {
        arr[r] = new char[s.Length];

        for (int c = 0; c < s.Length; c++)
        {
          arr[r][c] = ' ';
        }
      }

      int row = 2;
      int counter = -1;
      for (int i = 0; i < s.Length; i++)
      {
        arr[row][i] = s[i] != ' ' ? s[i] : '~';
        row = row + counter;

        if (row == 0)
        {
          counter = 1;
        }
        else if (row == 2)
        {
          counter = -1;
        }
      }

      Console.WriteLine(new string(arr[0]));
      Console.WriteLine(new string(arr[1]));
      Console.WriteLine(new string(arr[2]));
    }

    private static string minimum_window(string s, string t)
    {
      String result = "";

      if (t.Length > s.Length)
      {
        return "-1";
      }
      int n = s.Length, m = t.Length;
      int[] freq1 = new int[128]; /*creating a frequency array to store the 
                                    frequencies of the characters in string t*/
      int[] freq2 = new int[128]; /*creating a frequency array to store the 
                                    frequencies of the characters in string s*/
      foreach (char c in t.ToCharArray())
      {
        freq1[c]++;
      }
      int l = 0, len = n + 1;
      int cnt = 0;
      /*This part uses "2 pointer method." You can find a link 
      for the same in the editorial of this problem.*/
      for (int i = 0; i < n; i++)
      {
        char temp = s[i];
        freq2[temp]++;
        //if a character is present in string t we increment the count of cnt variable.
        if (freq1[temp] != 0 && freq2[temp] <= freq1[temp])
        {
          cnt++;
        }
        /*if we match all the characters present in string t, 
        we try to find the minimum window possible*/
        if (cnt == m)
        {
          /*if any character is occuring more than the required times, we try to remove it
          from the starting and also try to remove the unwanted characters that are 
          not a part of string t from the starting. We check the remainder string if it 
          can become the smallest window.*/
          while (freq2[s[l]] > freq1[s[l]] || freq1[s[l]] == 0)
          {
            if (freq2[s[l]] > freq1[s[l]])
            {
              freq2[s[l]]--;
            }
            l++;
          }
          //check if this can become the smallest window and update the result accordingly.
          if (len > i - l + 1)
          {
            len = i - l + 1;
            result = s.Substring(l, l + len);
          }
        }
      }
      return result.Length == 0 ? "-1" : result;
    }


    private static List<List<int>> find_indices_words(string text, List<string> words)
    {
      Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();
      int s = 0;
      int e = 0;

      while (e < text.Length)
      {
        while (e < text.Length && text[e] != ' ')
          e++;

        string word = text.Substring(s, e - 1 - s + 1);

        if (!map.ContainsKey(word))
        {
          map[word] = new List<int>();
        }

        map[word].Add(s);

        e++;
        s = e;
      }

      List<List<int>> result = new List<List<int>>();
      for (int i = 0; i < words.Count; i++)
      {
        if (map.ContainsKey(words[i]))
        {
          result.Add(map[words[i]]);
        }
        else
        {
          result.Add(new List<int> { -1 });
        }
      }

      return result;

    }

    private static string[] neuronyms(string word)
    {
      var result = new List<string>();
      if (word.Length <= 3)
        return result.ToArray();

      for (int i = 1; i < word.Length - 2; i++)
      {
        for (int j = i + 1; j < word.Length - 1; j++)
        {
          result.Add(word.Substring(0, i) + (j - i + 1) + word.Substring(j + 1));
        }
      }
      return result.ToArray();
      // List<string> result = new List<string>();
      // if (string.IsNullOrEmpty(word))
      // {
      //   return result.ToArray();
      // }
      // int start = 0;
      // int end = word.Length - 1;
      // while (start < word.Length - 3)
      // {
      //   while (end > start + 2)
      //   {
      //     result.Add(word.Substring(0, start + 1) + (end - start - 1) + word.Substring(end, word.Length - end));
      //     end--;
      //   }
      //   start++;
      //   end = word.Length - 1;
      // }
      // return result.ToArray();
    }

    private static string getLongestRepeatedSubstringbruteDP(string inputStr)
    {
      int n = inputStr.Length;
      int[][] lcp = new int[n][];
      for (int i = 0; i < n; i++)
      {
        lcp[i] = new int[n];
      }
      // lcp[i][j] = k means length of longest common prefix between suffix starting at i and suffix
      // starting at j is k

      for (int i = 0; i < n; i++)
      {
        lcp[i][n - 1] = (inputStr[i] == inputStr[n - 1] ? 1 : 0);
      }

      for (int i = 0; i < n; i++)
      {
        lcp[n - 1][i] = (inputStr[n - 1] == inputStr[i] ? 1 : 0);
      }

      int lrsLen = 0, lrsIndex = -1;
      for (int i = n - 2; i >= 0; i--)
      {
        for (int j = n - 2; j >= 0; j--)
        {
          if (inputStr[i] == inputStr[j])
          {
            lcp[i][j] = 1 + lcp[i + 1][j + 1];
          }
          else
          {
            lcp[i][j] = 0;
          }
        }
      }

      for (int i = 0; i < n; i++)
      {
        for (int j = i + 1; j < n; j++)
        {
          if (lcp[i][j] > lrsLen)
          {
            lrsIndex = i;
            lrsLen = lcp[i][j];
          }
        }
      }

      String lrs = "";
      if (lrsIndex > -1)
      {
        lrs = inputStr.Substring(lrsIndex, lrsIndex + lrsLen);
      }

      return lrs;
    }

    private static string getLongestRepeatedSubstringbruteforce(string inputStr)
    {
      int n = inputStr.Length;
      int j;
      String curr;
      // Iterate over all possible substrings in descending order of their length
      for (int len = n - 1; len > 0; len--)
      {
        for (int i = 0; i + len - 1 < n; i++)
        {
          j = i + len - 1;
          curr = inputStr.Substring(i, j + 1);
          // Check if substring inputStr.substring(i, j + 1) occurs anywhere other than at index i
          // or not
          if (isSubstring(inputStr.Substring(i + 1), curr))
          {
            // Found at least one occurrence of inputStr.substring(i, j + 1) at some index ind >= i+1
            return curr;
          }
          if (isSubstring(inputStr.Substring(0, j), curr))
          {
            // Found at least one occurrence of inputStr.substring(i, j + 1) at some index ind <= i-1
            return curr;
          }
        }
      }
      return "";
    }
    public static bool isSubstring(String text, String pattern)
    {
      return text.Contains(pattern);
    }

    private static void getLongestSubstringLengthExactly2DistinctChars(string s, int k)
    {
      int MAX_CHARS = 26;
      int u = 0; // number of unique characters 
      int n = s.Length;

      // Associative array to store the count of characters 
      int[] count = new int[MAX_CHARS];
      Array.Fill(count, 0);
      // Traverse the string, Fills the associative array 
      // count[] and count number of unique characters 
      for (int i = 0; i < n; i++)
      {
        if (count[s[i] - 'a'] == 0)
        {
          u++;
        }
        count[s[i] - 'a']++;
      }

      // If there are not enough unique characters, show 
      // an error message. 
      if (u < k)
      {
        Console.Write("Not enough unique characters");
        return;
      }

      // Otherwise take a window with first element in it. 
      // start and end variables. 
      int curr_start = 0, curr_end = 0;

      // Also initialize values for result longest window 
      int max_window_size = 1, max_window_start = 0;

      // Initialize associative array count[] with zero 
      Array.Fill(count, 0);

      count[s[0] - 'a']++;  // put the first character 

      // Start from the second character and add 
      // characters in window according to above 
      // explanation 
      for (int i = 1; i < n; i++)
      {
        // Add the character 's[i]' to current window 
        count[s[i] - 'a']++;
        curr_end++;

        // If there are more than k unique characters in 
        // current window, remove from left side 
        while (!isValid(count, k))
        {
          count[s[curr_start] - 'a']--;
          curr_start++;
        }

        // Update the max window size if required 
        if (curr_end - curr_start + 1 > max_window_size)
        {
          max_window_size = curr_end - curr_start + 1;
          max_window_start = curr_start;
        }
      }

      Console.Write("Max sustring is : "
              + s.Substring(max_window_start, max_window_size)
              + " with length " + max_window_size);

      Console.ReadLine();

    }

    private static bool isValid(int[] count, int k)
    {
      int MAX_CHARS = 26;

      int val = 0;
      for (int i = 0; i < MAX_CHARS; i++)
      {
        if (count[i] > 0)
        {
          val++;
        }
      }

      // Return true if k is greater than or equal to val 
      return (k >= val);
    }

    private static bool RegexMatcher(string text, string pattern)
    {
      int pLen = pattern.Length;

      //This will store true at location i, if simplifiedPattern has "*" character at location i
      bool[] isStarChar = new bool[pLen];
      String simplifiedPattern = simplifyPattern(pattern, isStarChar, pLen);
      return matcher(simplifiedPattern, text, isStarChar);
    }

    private static bool matcher(string pattern, string text, bool[] isStarChar)
    {
      int pLen = pattern.Length, tLen = text.Length;

      // If both strings are null, then return true.

      if (pLen == 0 && tLen == 0)
      {
        return true;
      }

      // If pattern is null but text is not, then return false.

      if (pLen == 0)
      {
        return false;
      }

      // dp[i][j] is true, if first i characters in given string matches the first j characters of pattern.

      bool[][] dp = new bool[tLen + 1][];
      for (int i = 0; i < dp.Length; i++)
      {
        dp[i] = new bool[dp.Length];
      }
      dp[0][0] = true;
      if (isStarChar[0])
      {
        dp[0][1] = true;
      }

      // If the given text is null, 
      // then it will be true till the all the characters in simplified string have "*".

      for (int pInd = 1; pInd < pLen; pInd++)
      {

        if (dp[0][pInd] && isStarChar[pInd])
        {
          dp[0][pInd + 1] = true;
          continue;
        }

        break;
      }

      for (int tInd = 0; tInd < tLen; tInd++)
      {

        for (int pInd = 0; pInd < pLen; pInd++)
        {

          /* Note : First i character of text string means substring of text string 
           *        with [0,i-1] positions.
           *        same for pattern string.
           */

          // Case 1, explained in editorial

          if (dp[tInd + 1][pInd] && isStarChar[pInd])
          {
            dp[tInd + 1][pInd + 1] = true;
            continue;
          }

          // Case 2, explained in editorial

          if (
             dp[tInd][pInd]
                 && (pattern[pInd] == '.' || pattern[pInd] == text[tInd])
                     )
          {
            dp[tInd + 1][pInd + 1] = true;
            continue;
          }

          // Case 3, explained in editorial

          if (dp[tInd][pInd + 1] && isStarChar[pInd] &&
                  (pattern[pInd] == '.' || pattern[pInd] == text[tInd]))
          {
            dp[tInd + 1][pInd + 1] = true;
            continue;
          }
        }
      }

      return dp[tLen][pLen];
    }


    private static string simplifyPattern(string pattern, bool[] isStarChar, int pLen)
    {
      int ind = 0;
      char[] simplifiedChars = new char[pattern.Length];

      for (int i = 0; i < pLen;)
      {

        simplifiedChars[ind] = pattern[i];

        // If i'th character is followed by '*', then mark isStartChar[i] true.
        if (i + 1 < pLen && pattern[i + 1] == '*')
        {

          /* Below 'if' condition is to handle Duplicate character.
           * e.g. [a*a*bc*dd*] = [a*bc*dd*], 
           *      because you can write [a*a*] = [a*] which meaning is same.
           */

          if (ind - 1 >= 0 && isStarChar[ind - 1] && simplifiedChars[ind - 1] == simplifiedChars[ind])
          {
            ind--;
          }
          else
          {
            isStarChar[ind] = true;
          }

          // i+1'th character is "*". So, i increases by 2.

          i = i + 2;
        }
        else
        {
          i++;
        }
        ind++;
      }

      // Converting character array to string for simplicity.

      return new String(simplifiedChars, 0, ind);
    }

    public static void printSubStr(string str,
                                   int low, int high)
    {
      Console.WriteLine(str.Substring(low,
                       (high + 1) - low));
    }
    private static int longestPalSubstr(string str)
    {

      int maxLength = 1; // The result (length of LPS) 

      int start = 0;
      int len = str.Length;

      int low, high;

      // One by one consider every  
      // character as center point 
      // of even and length palindromes  
      for (int i = 1; i < len; ++i)
      {
        // Find the longest even length  
        // palindrome with center points  
        // as i-1 and i.  
        low = i - 1;
        high = i;
        while (low >= 0 && high < len &&
               str[low] == str[high])
        {
          if (high - low + 1 > maxLength)
          {
            start = low;
            maxLength = high - low + 1;
          }
          --low;
          ++high;
        }

        // Find the longest odd length  
        // palindrome with center point as i  
        low = i - 1;
        high = i + 1;
        while (low >= 0 && high < len &&
               str[low] == str[high])
        {
          if (high - low + 1 > maxLength)
          {
            start = low;
            maxLength = high - low + 1;
          }
          --low;
          ++high;
        }
      }

      Console.Write("Longest palindrome substring is: ");
      printSubStr(str, start, start + maxLength - 1);

      return maxLength;

    }

    private static int SearchSubstringinStringBruteforce(string s, string p)
    {
      int N = s.Length;
      int M = p.Length;

      for (int i = 0; i < N - M; i++)
      {
        int j;
        for (j = 0; j < M; j++)
        {
          if (s[i + j] != p[j])
            break;

        }
        if (j == M)
          return i;

      }
      return -1;

    }

    // private static string spiralPrint(char[][] a)
    // {
    //   int m = a.GetUpperBound(1) + 1;
    //   int n = a.GetUpperBound(1) + 1;

    //   int k = 0;
    //   int l = 0;
    //   int i = 0;
    //   System.Text.StringBuilder sb = new System.Text.StringBuilder();
    //   while (k < m && l < n)
    //   {
    //     // Print the first row from the remaining rows 
    //     for (i = l; i < n; ++i)
    //     {
    //       sb.Append(a[k, i]).Append(" ");
    //     }
    //     k++;

    //     // Print the last column from the remaining columns  
    //     for (i = k; i < m; ++i)
    //     {
    //       sb.Append(a[i, n - 1]).Append(" ");
    //     }
    //     n--;

    //     // Print the last row from the remaining rows */ 
    //     if (k < m)
    //     {
    //       for (i = n - 1; i >= l; --i)
    //       {
    //         sb.Append(a[m - 1, i]).Append(" ");
    //       }
    //       m--;
    //     }

    //     // Print the first column from the remaining columns */ 
    //     if (l < n)
    //     {
    //       for (i = m - 1; i >= k; --i)
    //       {
    //         sb.Append(a[i, l]).Append(" ");
    //       }
    //       l++;
    //     }
    //   }
    //   return sb.ToString();
    // }

    // private static string reverse_ordering_of_words(string s)
    // {
    //   // string[] str=s.Split(" ");
    //   // System.Text.StringBuilder sb=new       System.Text.StringBuilder();
    //   // for (int i = str.Length-1; i >=1; i--)
    //   // { 

    //   //   sb.Append(str[i]).Append(" ");


    //   // }
    //   // sb.Append(str[0]);
    //   // return sb.ToString();


    // }
  }
}
//     private static void test(string v1, string v2)
//     {
//       char[] ch1 = v1.ToCharArray();

//       char[] ch2 = v2.ToCharArray();


//       bool t = match(ch1, ch2);
//     }

//     private static bool match(char[] first, char[] second)
//     {

//       int n = char.Length;
//       int m


//     }
//   }
// }
// // }

// //     private static int[] KMPSearch(string pat, string txt)
// //     {
// //       int m = pat.Length;
// //       int n = txt.Length;
// //      // System.Console.WriteLine(m);
// //       //System.Console.WriteLine(n);
// //       int[] lps = new int[m];
// //       //int[] result =new int[m];
// //       System.Collections.Generic.List<int> result =new System.Collections.Generic.List<int>();
// //       GenerateLPS(pat, m, lps);
// //       int k=0;

// // int j=0;
// //       int i=0;
// //       while(i<n){
// //           if(pat[j]==txt[i]){
// //               i++;
// //               j++;
// //           }
// //           if(j==m)
// //           {
// //              // System.Console.WriteLine("patter found " + (i-j));
// //              result.Add(i-j);
// //              k++;
// //               j=lps[j-1];
// //           }
// //           else if(i<n && pat[j]!=txt[i]){
// //               if(j!=0){
// //                   j=lps[j-1];
// //               }
// //               else{
// //                   i=i+1;
// //               }
// //           }
// //       }
// //       if(result.Count<=0){
// //           result.Add(-1);
// //       }

// //   return result.ToArray();
// //     }

// // private static void GenerateLPS(string pat, int m, int[] lps)
// // {
// //   int i = 1;
// //   int j = 0;

// //   while (i < m)
// //   {
// //     if (pat[i] == pat[j])
// //     {
// //                   j++;
// //       lps[i] = j;
// //       i++;

// //     }
// //     else
// //     {
// //       if (j != 0)
// //       {
// //         j = lps[j - 1];
// //       }
// //       else
// //       {
// //         lps[i] = j;
// //         i++;
// //       }
// //     }
// //   }


// // }
// // }
// // }
