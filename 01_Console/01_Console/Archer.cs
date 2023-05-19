using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Console
{
    class Archer : CharacterBase
    {
        public Archer(string name)
        {
            Random ran = new Random();
            Initialize(name);
            strength = ran.Next(3, 10);
            dexterity = 5 + ran.Next(5, 11);
            wisdom = ran.Next(3, 10);
        }

        public override void Attack(CharacterBase target)
        {
            TripleShot(target);
            float damage = dexterity * 1.7f;
            target.Defence(damage);
        }
        public override void Defence(float damage)
        {
            float finalDamage = damage -= defencePower;
            HP -= finalDamage;
        }
        //public override void Skill(CharacterBase target)
        //{
        //    TripleShot(target);
        //}

        private void TripleShot(CharacterBase target)
        {
            int cost = 10;
            if (MP < cost)
                return;
            float damage = dexterity * 5.0f;

                target.Defence(damage);
                MP -= cost;
        }
    }
}
