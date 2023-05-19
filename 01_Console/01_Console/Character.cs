using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Console
{
    // Character 클래스 선언 변수필드 , 함수필드 ;여러곳에서 쉽게 가져다 쓸 수 있도록 캡슐화가 지켜지지 않으면 객체지향의 의미가 퇴색된다. 
    class Character 
    {
        int level = 0;
        float hp = 100.0f;
        float exp = 0.0f;
        int defence = 10;
        float attackPower;
        private string name;



        //property 변수처람생긴 함수? 접근 불가능한 것을 접근 가능하게 해준다.


        public Character(string name, float hp, int defence)
        {
            this.hp = hp;
            level = 0;
            this.name = name;
            this.defence = defence;
        }
        public float HP // 호출시  ex > mike.HP 
        {
            get //가져오는 것은 public으로 열어두고
            {
                return hp;
            }
            private set // 읽을수는 있지만 바꿀수는 없다.  이렇게 하면 읽기전용 프로퍼티
            {
                hp = value;
                if (hp < 0)
                {
                    Die();
                }
            }
        }
        public string _name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }
        //위코드의 축약법
        public string _Name
        {
            get
            {
                return name;
            }
        }
        public string NAME => name;//가장 짧은 읽기전용 축약법
        

        public void Attack(Character target) //target 공격대상
        {
            Console.WriteLine($"{this.name} 가 {target.name} 을 공격한다.");
            target.Defence(1000);          
        }
        public void Defence(float damage)
        {
            float final = attackPower - defence;
            hp -= (damage - this.defence);        
            Console.WriteLine($"{damage} 의 데미지를 받고 {this.defence} 만큼 방어했다.");
        }
        private void Die()
        {
            Console.WriteLine("죽음");
        }
 
    }
}
