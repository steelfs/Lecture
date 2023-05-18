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

        public void Attack()
        {
            Console.WriteLine("공격!");
        }
        public void Defence()
        {
            Console.WriteLine("방어");
        }
        private void Die()
        {
            Console.WriteLine("죽음");
        }
    }
}
