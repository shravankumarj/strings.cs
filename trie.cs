using System;
using System.Collections.Generic;

public class Trie
{
  TrieNode root;
  static List<List<int>> result;

  public Trie()
  {
    root = new TrieNode();
  }

  public void INSERT(string key)
  {
    int level;
    int length = key.Length;
    int index;

    TrieNode pCrawl = root;

    for (level = 0; level < length; level++)
    {
      index = key[level] - 'a';
      if (pCrawl.children[index] == null)
        pCrawl.children[index] = new TrieNode();

      pCrawl = pCrawl.children[index];
    }
    pCrawl.isEndofWord = true;

  }

  public void suggestionRec(TrieNode root1, string currPrefix)
  {
    if (root1 == null)
      root1 = root;
    int str;
    if (root1.isEndofWord)
    {
      System.Console.WriteLine(currPrefix);
    }
    // if (isLastNode(root1))
    //   return;

    for (int i = 0; i < 25; i++)
    {
      if (root1.children[i] != null)
      {
        System.Console.WriteLine(currPrefix[i] - 'a');
        suggestionRec(root1.children[i], currPrefix);
      }

    }

  }

  private bool isLastNode(TrieNode root)
  {
    for (int i = 0; i < 25; i++)
    {
      if (root.children[i] == null)
        return true;

    }
    return false;
  }

  internal bool search(string key)
  {
    int level;
    int length = key.Length;
    int index;
    TrieNode pCrawl = root;

    for (level = 0; level < length; level++)
    {
      index = key[level] - 'a';

      if (pCrawl.children[index] == null)
        return false;

      pCrawl = pCrawl.children[index];
    }

    return (pCrawl != null && pCrawl.isEndofWord);
  }

  public bool checkPalindromePair(List<String> vect)
  {

    // Construct trie 
    TrieNode root = new TrieNode();
    for (int i = 0; i < vect.Count; i++)
      INSERT(vect[i].ToString());

    // Search for different keys 
    result = new List<List<int>>();
    for (int i = 0; i < vect.Count; i++)
    {
      search(vect[i].ToString());

      if (result.Count > 0)
        return true;
    }

    return false;
  }
}

public class TrieNode
{
  public TrieNode[] children = new TrieNode[25];

  public bool isEndofWord;
  public TrieNode()
  {
    isEndofWord = false;

    for (int i = 0; i < 25; i++)
    {
      children[i] = null;

    }

  }

}
