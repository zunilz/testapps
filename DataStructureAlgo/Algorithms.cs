namespace DataStructureAlgo
{
    public class Algorithms
    {

        private int[] itemList = new int[10];

        public Algorithms()
        {
            itemList = new int[10] { 2, 4, 6, 7, 14, 44, 88, 155, 753, 4436 };
        }

        public Algorithms(int[] ints)
        {
            itemList = ints;
        }

        public int? binarySearch(int searchQ, out int numberOfTries)
        {
            int? foundIndex = null;
            int tries = 0;

            int lowIndex = 0;
            int highIndex = itemList.Length - 1;
            int midIndex = (lowIndex + highIndex) / 2;

            while (lowIndex <= highIndex)
            {
                ++tries;
                if (searchQ == itemList[midIndex])
                {
                    foundIndex = midIndex;
                    break;
                }
                else if (searchQ < itemList[midIndex])
                    highIndex = midIndex - 1;
                else if (searchQ > itemList[midIndex])
                    lowIndex = midIndex + 1;

                midIndex = (lowIndex + highIndex) / 2;
            }

            numberOfTries = tries;

            return foundIndex;

        }

    }
}