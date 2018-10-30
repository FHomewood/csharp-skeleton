namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question6
    {
        public static int Answer(int numOfServers, int targetServer, int[,] connectionTimeMatrix)
        {
            int shortestPath = connectionTimeMatrix[targetServer,0];
            return shortestPath;
        }
    }
}