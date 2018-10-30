namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question4
    {
        public static int Answer(string[,] machineToBeFixed, int numOfConsecutiveMachines)
        {
            int lowest = int.MaxValue;
            for (int i = 0; i < machineToBeFixed.GetLength(0); i++)
            {
                int total = 0;
                int noX = 0;
                for (int j = 0; j < machineToBeFixed.GetLength(1); j++)
                {
                    bool ifX = machineToBeFixed[i, j] == "X";
                    total +=  ifX? int.Parse(machineToBeFixed[i,j]) : 0;
                    noX += ifX ? 0 : 1;
                }
                lowest = total < lowest && machineToBeFixed.GetLength(1) - noX == 0 ?
                    total:
                    lowest;
            }
            return lowest;
        }
    }
}