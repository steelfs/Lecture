using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Console
{
    class CharacterBase
    {
        string name = string.Empty;

        //스탯
       protected int strength = 3;
       protected int dexterity = 3;
       protected int wisdom = 3;
        protected float defencePower;

        //체력, 마나
       protected float hp = 100.0f; //현재 체력
       protected float hpMax = 100.0f;// 최대 체력

       protected float mp = 100.0f;
       protected float mpMax = 100.0f;
        public bool IsAlive => hp < 0; //코드가독성을 위한 것. 직관적인 의미전달 // 생존여부 판단

        public float HP  //hp를 확인할 수 있는 프로퍼티
        {
            get => hp;
            protected set
            {
                hp = value;
                if (hp > hpMax)// hp 가 최대 HP를 넘어가는 것을 방지
                    hp = hpMax;
                 if(hp < 0)
                 {
                    Die();
                 }
            }
        }
        public float MP  
        {
            get => hp;
            protected set
            {
                hp = value;
                if (hp > mpMax)
                    hp = mpMax;
                if(mp < 0)
                {
                    mp = 0;
                }
            }
        }

        protected void Initialize(string name) // 초기화함수 생성자에서 호출 예정
        {
            this.name = name;
            hpMax = 100.0f + strength * 10.0f; //힘에 비례 HP 증가
            mpMax = 100.0f + wisdom * 10.0f; // 
            defencePower = 10 + strength * 0.02f;
        }

        public virtual void Attack(CharacterBase target) 
        {

        }
        public virtual void Defence(float damage)
        {

        }

        public virtual void Skill(CharacterBase target)
        {

        }
        void Die()// 사망처리
        {
            if (IsAlive) //살아있을때만 죽는다. 여러번 죽는것 방지
            {
                Console.WriteLine($"{this.name} 가 사망했습니다.");
            }
        }

    }
}
