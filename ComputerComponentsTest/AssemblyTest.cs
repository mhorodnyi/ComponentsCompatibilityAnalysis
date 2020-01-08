using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CumputerComponentsUI.ViewModel;
using ComputerComponents.Models;

namespace ComputerComponentsTest
{
    [TestClass]
    public class AssemblyTest
    {
        [TestMethod]
        public void AssemblyCompatibilityMessage_NullComponents()
        {
            Assembly assembly = new Assembly();

            string message = assembly.AssemblyCompatibilityMessage();

            Assert.AreEqual(message, "All components will work fine");
        }

        [TestMethod]
        public void AssemblyCompatibilityMessage_GPUAndPSBad()
        {
            Assembly assembly = new Assembly
            {
                GraphicalCard = new GraphicalCard("", "", "", 650, 0),
                PowerSupply = new PowerSupply("", "", 500, 0)
            };

            string message = assembly.AssemblyCompatibilityMessage();

            Assert.AreEqual(message, "Please, choose Power Supply with more power");
        }

        [TestMethod]
        public void AssemblyCompatibilityMessage_CPUAndGPU()
        {
            Assembly assembly = new Assembly
            {
                Processor = new Processor("", "", 0, 0, "", "-", 0, 0)
            };


            string message = assembly.AssemblyCompatibilityMessage();

            Assert.AreEqual(message, "Please, choose CPU with graphical core OR select GPU");
        }

        [TestMethod]
        public void AssemblyCompatibilityMessage_CPUAndMotherboard()
        {
            Assembly assembly = new Assembly
            {
                Processor = new Processor("", "", 0, 0, "AM4", "", 0, 0),
                Motherboard = new Motherboard("", "", "", "LGA 1151", 0)
            };


            string message = assembly.AssemblyCompatibilityMessage();

            Assert.AreEqual(message, "Please, select CPU and Motherboard with the same socket");
        }

        [TestMethod]
        public void AssemblyCompatibilityMessage_FanAndCPUSocket()
        {
            Assembly assembly = new Assembly
            {
                Processor = new Processor("", "", 0, 0, "AM4", "", 0, 0),
                Fan = new Fan("", "", 0, "LGA 1151", 0)
            };


            string message = assembly.AssemblyCompatibilityMessage();

            Assert.AreEqual(message, "Please choose Fan with the same socket as CPU");
        }

        [TestMethod]
        public void AssemblyCompatibilityMessage_FanAndCpuTdp()
        {
            Assembly assembly = new Assembly
            {
                Processor = new Processor("", "", 0, 0, "", "", 90, 0),
                Fan = new Fan("", "", 50, "", 0)
            };


            string message = assembly.AssemblyCompatibilityMessage();

            Assert.AreEqual(message, "It will be better if you choose Fan with bigger TDP then CPUs");
        }
    }
}
