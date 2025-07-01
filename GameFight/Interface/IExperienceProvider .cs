using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFight.Interface
{
    public interface IExperienceProvider
    {
        int CurrentExperience { get; }
        void GainExperience(int amount);
    }
}
