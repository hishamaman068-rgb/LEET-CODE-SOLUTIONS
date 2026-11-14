public class Solution {
    public int MostWordsFound(string[] sentences) {
        int maxWords = 0;

        foreach(var sentence in sentences)
        {
            maxWords = Math.Max(maxWords, sentence.Split(' ').Count());
        }
        return maxWords;
    }
}