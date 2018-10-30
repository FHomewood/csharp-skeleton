namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question6
    {
        public static int Answer(int numOfServers, int targetServer, int[,] connectionTimeMatrix)
        {
            int shortestPath = connectionTimeMatrix[targetServer,0];
            for (int i = 0; i < numOfServers; i++)
            {
                int n = connectionTimeMatrix[i, 0] + connectionTimeMatrix[targetServer, i];
                if (n < shortestPath) shortestPath = n;
            }
            return shortestPath;
        }
    }
}
