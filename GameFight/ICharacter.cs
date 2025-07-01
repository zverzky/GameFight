using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFight
{ 
    public interface ICharacter
    {
        string Name { get; }
        double PowerAttack { get; }
        double Health { get; }
        double Deffirence { get; }
        int Level { get; }
        double Expirience { get; }
        void Attack(ICharacter target);
        void TakeDamage(double damage);
        void SpecialSkill(ICharacter target);
    }
}
