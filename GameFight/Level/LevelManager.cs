using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFight.Interface;

namespace GameFight.Level
{
    public class LevelManager
    {
        private IExperienceProvider experienceProvider;
        private int level;
        private int experienceToLevelUp;

        public int Level => level;
    }
}
