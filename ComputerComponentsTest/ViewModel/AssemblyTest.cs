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
            string message = Assembly.AssemblyCompatibilityMessage();

            Assert.AreEqual(message, "All components will work fine");
        }

        [TestMethod]
        public void AssemblyCompatibilityMessage_GPUAndPSBad()
        {
            Assembly.GPU = new GraphicalCard("", "", "", 650, 0);
            Assembly.PowerSupply = new PowerSupply("", "", 500, 0);

            string message = Assembly.AssemblyCompatibilityMessage();

            Assert.AreEqual(message, "Please, choose Power Supply with more power");
            Assembly.Clear();
        }

        [TestMethod]
        public void AssemblyCompatibilityMessage_CPUAndGPU()
        {
            Assembly.CPU = new Processor("", "", 0, 0, "", "-", 0, 0);


            string message = Assembly.AssemblyCompatibilityMessage();

            Assert.AreEqual(message, "Please, choose CPU with graphical core OR select GPU");
            Assembly.Clear();
        }

        [TestMethod]
        public void AssemblyCompatibilityMessage_CPUAndMotherboard()
        {
            Assembly.CPU = new Processor("", "", 0, 0, "AM4", "", 0, 0);
            Assembly.Motherboard = new Motherboard("", "", "", "LGA 1151", 0);


            string message = Assembly.AssemblyCompatibilityMessage();

            Assert.AreEqual(message, "Please, select CPU and Motherboard with the same socket");
            Assembly.Clear();
        }

        [TestMethod]
        public void AssemblyCompatibilityMessage_FanAndCPUSocket()
        {
            Assembly.CPU = new Processor("", "", 0, 0, "AM4", "", 0, 0);
            Assembly.Fan = new Fan("", "", 0, "LGA 1151", 0);

            string message = Assembly.AssemblyCompatibilityMessage();

            Assert.AreEqual(message, "Please choose Fan with the same socket as CPU");
            Assembly.Clear();
        }

        [TestMethod]
        public void AssemblyCompatibilityMessage_FanAndCpuTdp()
        {
            Assembly.CPU = new Processor("", "", 0, 0, "", "", 90, 0);
           Assembly.Fan = new Fan("", "", 50, "", 0);


            string message = Assembly.AssemblyCompatibilityMessage();

            Assert.AreEqual(message, "It will be better if you choose Fan with bigger TDP then CPUs");
            Assembly.Clear();
        }
    }
}
