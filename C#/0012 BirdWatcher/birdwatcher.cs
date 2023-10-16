/// <summary>
/// Serie oneexcersiceperday
/// Numero: 0010
/// Lenguaje:C#
/// Fuente: https://exercism.org/tracks/csharp/exercises/bird-watcher
/// </summary>
/// 

using System;

class BirdCount
{
    
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
        
    }

    public static int[] LastWeek()
    {
        int[] lastWeek = new int[] {0,2,5,3,7,8,4};

        return lastWeek;
    }

    public int Today()
    {
        
        int x = birdsPerDay.Length;
         return birdsPerDay[x-1];
    }

    public void IncrementTodaysCount()
    {
        int x = birdsPerDay.Length;
         
         birdsPerDay[x-1] +=1;
        
        
    }

    public bool HasDayWithoutBirds()
    {
        bool x = false;
        for(int i=0; i<birdsPerDay.Length;i++ ){
            
            if(birdsPerDay[i] == 0){
                x= true;
            }
            
        }

        return x;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum =0;
        for(int i=0; i<numberOfDays; i++){
            sum+= birdsPerDay[i];
        }
    return sum;
    }

    public int BusyDays()
    {
        int busyDays =0;
        
       for(int i=0; i<birdsPerDay.Length; i++){

           if(birdsPerDay[i] > 4 ){
               busyDays += 1;
           }
        }

        return busyDays;
    }
}
