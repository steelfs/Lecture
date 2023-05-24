using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace _01_Console
{
    class Program
    {
        static bool Clear0524_01 = false;
        bool Clear0524_02 = false;
        bool Clear0524_03 = false;
        bool Clear0524_04 = false;

        static void Main(string[] args)
        {
            //int i = 0;
            //Character mike = new Character("마이크", 1, 100);//Character 클래스의 주소값 할당 //new : 변수를 새로 만들어라, 최대한 적게 사용해야 한다. 
            //Character Jack = new Character("Mike",200, 5);
            //Character Jay = new Character("Jay", 200, 5);

            //inherit_Parents parent = new inherit_Parents(); //같은 함수가 있을 경우 선언된 클래스의 함수를 실행한다.
            //parent.Test_Func();


            //CharacterBase _mike = new Warrior("mike");
            //CharacterBase _Jack = new Warrior("jack");
            //CharacterBase _mike = new Warrior("mike");
            //CharacterBase _Jay = new Archer("jay");


            //while (true)
            //{
            //    _mike.Attack(_Jay);
            //    if (_Jay.IsAlive == false)
            //    {
            //        Console.WriteLine($"{_Jay} 가 사망하였습니다.");
            //        return;
            //    }

            //    _Jay.Attack(_mike);
            //    if (_mike.IsAlive == false)
            //    {
            //        Console.WriteLine($"{_mike} 가 사망하였습니다.");
            //        return;
            //    }
 
            //}
            while (Clear0524_01 == false)
            {
                Console.WriteLine("");
            }
        }


        /* 5월 19일 --------------------------------------
         * Disk - Memory(RAM)에 올라간 데이터를 CPU가 처리한다,
         * 
         *C#의 메모리 Heap, stack 
         
         *Heap : 상대적으로 느리지만 용량이 크다.(전역으로 사용하는 값들, 참조타입)class
         *heap - stack 값 이동시 unboxing, boxing 필요
         *stack - 함수를 호출시 스택메모리가 생성된다. 빠르다, 용량이 작다.(지역변수, 값타입 저장) struct
         *
         *값타입 - 원본 값을 갖고있고 값을 복사한다.Deep Copy 깊은복사,
         *복사시 값이 따로 존재하기때문에 개별적으로 값을 변경해도 다른곳에 영향을 주지 않는다.
         *
         *참조타입 - 값의 참조(주소)를 갖고있다. 실제 값을 변경한다.reference type
         *복사시 참조(주소)만 복사한다. 얕은복사.  하나의 값을 변경시 여러개의 class에 영향을 줄 수 있다.
         *
         *static / dynamic
         *정적,  /  동적
         *프로그램이 실행되기 전 메모리의 위치가 정해지는가 혹은 동적으로
         *
         *하드디스크 ->  ram 메모리에 업로드 -> CPU 에서 실행 /// 메모리에 업로드 되지 않은 것을 CPU에서 엑세스 하려고할 때 터짐;
         *static 이란 프로그램이 실행 되기 전 메모리의 위치가 고정됨
         */

        

    }
}



    
