using System;
using NUnit.Framework;
using IND.Proctorwear.Common;

namespace IND.Proctorwear.Specs.Common
{
    public class ProctorTests
    {
        [Test]
        public void StartProctoring()
        {
            //Arrange
            //Act
            using (var proctor = new Proctor())
            {
                proctor.Start();
            }
            //Assert
            Assert.IsTrue(true);
        }
    }
}
