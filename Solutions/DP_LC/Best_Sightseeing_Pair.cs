using System;

namespace Solutions.DP_LC
{
    public class Best_Sightseeing_Pair
    {
        /*
        Given an array A of positive integers, A[i] represents the value of the i-th sightseeing spot, and two sightseeing spots i and j have distance j - i between them.
        The score of a pair (i < j) of sightseeing spots is (A[i] + A[j] + i - j) : the sum of the values of the sightseeing spots, minus the distance between them.
        Return the maximum score of a pair of sightseeing spots.
        */

        //Butre force, got TLE
        public int MaxScoreSightseeingPair(int[] A)
        {
            int score = Int32.MinValue;
            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = i + 1; j < A.Length; ++j)
                {
                    score = Math.Max(score, A[i] + A[j] + i - j);
                }
            }
            return score;
        }

        public int MaxScoreSightseeingPair_DP(int[] A)
        {
            int score = Int32.MinValue;
            
            return score;
        }
    }
}
