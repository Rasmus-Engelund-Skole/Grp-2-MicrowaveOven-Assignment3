using System;
using System.Collections.Generic;
using System.Text;
using Microwave.Classes.Boundary;
using NUnit.Framework;

namespace Microwave.Test.Unit
{
    [TestFixture]
    public class BuzzerTest
    {
        private Buzzer uut;

        [SetUp]
        public void Setup()
        {
            uut = new Buzzer();
        }

        [Test]
        public void BuzzerSound()
        {
            uut.BuzzerSound();
        }

      

    }
}
