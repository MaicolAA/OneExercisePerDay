
/// <summary>
/// Serie oneexcersiceperday
/// Numero: 0002
/// Lenguaje:C#
/// Fuente: https://exercism.org/tracks/csharp/exercises/annalyns-infiltration
/// </summary>
/// 

using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if(knightIsAwake == false){
            return true;
        }
    else{
        return false;
        }
        
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(knightIsAwake == false && archerIsAwake == false && prisonerIsAwake == false ){
            return false;
        }
    else{
        return true;
    }
        
        
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(archerIsAwake == false && prisonerIsAwake == true ){
            return true;
        }
    else{
        return false;
    }
        
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        
        if(archerIsAwake == false && petDogIsPresent == true){
            return true;
        }
        if(petDogIsPresent ==  false && prisonerIsAwake == true && knightIsAwake== false && archerIsAwake == false ){
            return true;
        }
    
        else{
           return false;
        }
        
    }
}