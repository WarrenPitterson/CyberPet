using CyberPet.Business.Logic;
using CyberPet.Business.Logic.Models;
using System;
using Xunit;

namespace CyberPet.UnitTests
{
    public class CatCyberPetTests
    {
        [Fact]
        public void WhenCatIsSleepingDoesTirednessGoDown()
        {
            var cat = new CyberPetStatus();

            var interaction = new CatCyberPetInteractions();

            interaction.Sleep(cat);

            Assert.Equal(80, cat.Tiredness);
            

        }
    }
}
