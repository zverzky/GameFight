using GameFight.Experience;

namespace GameFight.Manager
{
    public class LevelManager
    {
        private ExperienceProvider experienceProvider;

        public LevelManager(ExperienceProvider experienceProvider)
        {
            this.experienceProvider = experienceProvider;
        }

        public void UpdateLevel(ref int level)
        {
            experienceProvider.LevelUp(ref level);
        }
    }
}