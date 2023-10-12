/// <summary>
/// Serie oneexcersiceperday
/// Numero: 0008
/// Lenguaje:C#
/// Fuente: https://exercism.org/tracks/csharp/exercises/interest-is-interesting
/// </summary>
/// 
using System;

public static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float interestRate=0.0f;
        
        if(balance <0)
        {
            interestRate=3.213f;
        }
        else if(balance <1000)
        {
            interestRate = 0.5f;
        }
        else if(balance >= 1000 && balance <5000)
        {
            interestRate=1.621f;
        }
        else if(balance>=5000)
        {
            interestRate =2.475f;
        }
    
        return interestRate;
    }

    public static decimal Interest(decimal balance)
    {
        float rate = InterestRate(balance);
        
        decimal interest = balance * (decimal)(rate/100.0f);
        
        return interest;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        decimal interest = Interest(balance);
        decimal annualBalance = balance + interest;
        
        return annualBalance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int count = 0;
        decimal currentBalance = balance;

        while (currentBalance < targetBalance)
        {
            currentBalance = AnnualBalanceUpdate(currentBalance);
            count += 1;
        }
        return count;
    }
}
