using CyberPet.Business.Logic.Household;
using CyberPet.Business.Logic.Interactions;
using CyberPet.Business.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CyberPet.UnitTests.Household
{
    public class HouseholdTests
    {
        [Fact]
        public void IsthePersonBeingAddedToTheList()
        {
            var household = new House();

            var person = new MumLikeCyberInteraction();

            household.peopleAdd(person);

            Assert.Single(household.peopleWhoLiveInTheHouse);
        }

        [Fact]
        public void HasMumBeenTalkingToThePet()
        {
            var household = new House();

            var talking = new MumLikeCyberInteraction();

            household.peopleAdd(talking);

            household.MumTalkToThePet(household.cat);

            Assert.Equal(120, household.cat.Tiredness);


        
        }

    }
}
