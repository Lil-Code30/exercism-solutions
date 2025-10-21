class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
       return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
       return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        int currentIndex = birdsPerDay.Length - 1;
        birdsPerDay[currentIndex] += 1;
        
    }

    public bool HasDayWithoutBirds()
    {
        for(int i = 0; i < birdsPerDay.Length ; i++){
            if(birdsPerDay[i] == 0){
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for(int i = 0; i < numberOfDays; i++){
            sum +=birdsPerDay[i];
        }

        return sum;
    }

    public int BusyDays()
    {
        int count = 0;
        for(int i = 0; i < birdsPerDay.Length; i++){
            if(birdsPerDay[i] >= 5){
                count++;
            }
        }
        return count;
    }
}
