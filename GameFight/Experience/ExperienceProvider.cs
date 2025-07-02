using System;
using System.ComponentModel;
using GameFight.Interface;

namespace GameFight.Experience
{
    public class ExperienceProvider: IExperienceProvider
    {
        private double experience;
        private int currentExperience;

        public double Experience => experience;

        public int CurrentExperience => currentExperience;

        public void GainExperience(int amount)
        {
            experience += amount;

        }
        public void ResetExperience()
        {
            experience = 0;
        }

        public bool CheckLevelUp(int currentLevel)
        {
            return experience >= 50; 
        }

        public void LevelUp(ref int level)
        {
            if (CheckLevelUp(level))
            {
                level += 1;
                experience -= 50; 
            }
        }
    }
}