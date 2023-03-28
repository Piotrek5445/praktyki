using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Fabryka_batonow
{
    class Maszyna_Bat
    {
        IsolatingCoolingSystem isolatingCoolingSystem = new IsolatingCoolingSystem();
        Maker maker = new Maker();
        public void DoMaintanceTests()
        {
            if (NoughtToHot() == true) { DoCICSVentProcedure(); }
            else { Console.WriteLine("Wszystko w porządku\n"); }



        }
        public void DoCICSVentProcedure()
        {
            Turbina kontrolerTurbiny = new Turbina();
            kontrolerTurbiny.CloseValveTrip(2);
            isolatingCoolingSystem.Fill();
            isolatingCoolingSystem.Vent();
            maker.CheckAirSystem();
            Console.WriteLine("Batony zbyt gorące\n");
        }
        public bool NoughtToHot() { int temp = maker.CheckNaughtTemperature(); if (temp > 160) return true; else return false;  } 
        
    }
}