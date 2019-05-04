using CyberPet.Business.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPet.Business.Logic
{
    public class CatCyberPetInteractions : ICyberPetInteractions
    {
        public string Eat(CyberPetStatus petStatus)
        {
            throw new NotImplementedException();
        }

        public string Play(CyberPetStatus petStatus)
        {
            throw new NotImplementedException();
        }

        public CyberPetStatus Sleep(CyberPetStatus petStatus)
        {
            petStatus.Tiredness -= 20;
            return petStatus;

        }
    }
}
