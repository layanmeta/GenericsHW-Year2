
// See https://aka.ms/new-console-template for more information

struct Bag 
{
    public List<int> startingList;
    public List<int> backupList;

    public Bag(int top)
    {
        startingList = new List<int>();
        for (int i = 0; i < top; i++)
        {
            startingList.Add(i);
        }
        backupList = new List<int>();
    }

    int ChooseNum()
    {
        int result = Random.Shared.Next(0, startingList.Count);
        int chosenNum = startingList[result];

        backupList.Add(chosenNum);
        startingList.Remove(result);

        if (startingList.Count <= 0)
        {
            Shuffle();
        }
        return chosenNum;
    }

    public int RandomRangedGenerator()
    {
        return ChooseNum();
    }

    public void Shuffle()
    {
        startingList = backupList;
        backupList.Clear();
    }
}


