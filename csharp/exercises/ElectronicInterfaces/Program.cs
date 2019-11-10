using System;
using System.Collections.Generic;

namespace ElectronicInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            TestRadios aRadio = new Radio();
            aRadio anotherRadio = new aRadio();
            AllInOne anAllInOne = new AllInOne();

            List<IRadio> iradioList = new List<IRadio>)
            aRadio, anotherAllInOne,
            anotherRadio, anAllInOne   
        };

        static void TestRadios(List<IRadio> radios)
        foreach(IRadio radio in radios)
        {
            radio.TurnRadioOn();
            radio.TurnRadioOff();
        }
    }

