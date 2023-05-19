using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Console
{
    class Warrior : CharacterBase
    {
        public Warrior(string name)
        {
            Random ran = new Random();
            strength =  5 + ran.Next(5, 11);
            dexterity = ran.Next(3, 10);
            wisdom = ran.Next(3, 10);
            Initialize(name);
        }
        public override void Attack(CharacterBase target)
        {
            Strike(target);
            float damage = strength * 1.5f;
            target.Defence(damage);
        }
        public override void Defence(float damage)
        {
            float finalDamage = damage * strength * 0.05f;  //  /2 보다 *0.5가 더 좋은 코드이다.
            HP -= finalDamage;
        }
        public override void Skill(CharacterBase target)
        {
            Strike(target);
        }
        private void Strike(CharacterBase target)
        {
            const int cost = 10;
            if (MP < cost)
                return;

            float damage = strength * 3.5f;
            target.Defence(damage);
            MP -= cost;    
        }
    }
}
