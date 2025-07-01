using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFight.Interface;

namespace GameFight.Experience
{
    public class ExperienceProvider : IExperienceProvider
    {
        private int currentExperience;
        public int CurrentExperience => currentExperience;

        public void GainExperience(int amount)
        {
            currentExperience += amount;
        }
    }
}
