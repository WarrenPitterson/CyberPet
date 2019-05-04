using CyberPet.Business.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPet.Business.Logic
{
    public interface ICyberPetInteractions
    {
        string Play(CyberPetStatus petStatus);
        CyberPetStatus Sleep(CyberPetStatus petStatus);
        string Eat(CyberPetStatus petStatus);
    }
}
