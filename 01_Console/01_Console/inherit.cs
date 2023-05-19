using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Console
{
    class inherit_Parents
    {
        public int a = 10;
        private int b = 20;
        protected int d = 30; //자신과 상속받은 파생클래스에서만 접근 가능

        public virtual void Test_Func()// 오버라이드함수가 없을 경우 디폴트값은 부모클래스의 함수가 실행된다.
        {
            Console.WriteLine("부모");
        }
    }
    class inherit_Child : inherit_Parents
    {
        public int c = 30;

        public override void Test_Func()
        {
            Console.WriteLine("자식");
            a += 1;
            c += 1;
            // base.b  // private은 상속받아도 접근 불가
        }
    }
}
