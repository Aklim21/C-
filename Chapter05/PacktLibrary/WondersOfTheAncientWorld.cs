using System;
using static System.Console;

namespace Packt.Shared 
{
    [System.Flags]
    public enum WondersOfTheWorld : byte
    {
        None                        = 0b_0000_0000, //0
        GreatPyramidOfGiza          = 0b_0000_0001, //1
        HangingGardensofBabylon     = 0b_0000_0010, //2
        StatueofZeusAtOlympia       = 0b_0000_0100, //4
        TempleOfArtemisAtEphesus    = 0b_0000_1000, //8
        MausoleumAtHalicarnassus    = 0b_0001_0000, //16
        ColossusOfRhodes            = 0b_0010_0000, //32
        LighthouseOfAlexandria      = 0b_0100_0000 //64
    }
}