using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace _01_Console
{
    internal class Program
    {
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
            CharacterBase _mike = new Warrior("mike");
            CharacterBase _Jay = new Archer("jay");


            while (true)
            {
                _mike.Attack(_Jay);
                if (_Jay.IsAlive == false)
                {
                    Console.WriteLine($"{_Jay} 가 사망하였습니다.");
                    return;
                }

                _Jay.Attack(_mike);
                if (_mike.IsAlive == false)
                {
                    Console.WriteLine($"{_mike} 가 사망하였습니다.");
                    return;
                }
 
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

        ////실습
        //1. 나이를 입력받기
        //2. 8살 미만이면 "미취학아동 출력"
        //3. 13살 미만이면 "초등학생 출력"
        //4. 16살 미만이면 "중학생 출력"
        //5. 19살 미만이면 "고등학생 출력"
        //PrintAge();
        //UsingSwitch();

        //실습 숫자를 입력받아서 *로 삼각형 그리기

        //실습 숫자를 입력받아서 구구단 출력

        //SetScore();
        //PrintScore();
        //WhilePrintStar();
        //PrintStarForLoof();

        //PrintTriangle();
        //PrintTriangleWhileLoof();

        //Print9X9(7);
        //PrintTriangle(5);
        //PrintTriangle(5);
        //PrintReverseTriangle(5);
        //static void PrintTriangle(int value)
        //{
        //    for (int i = 0; i < value; i++) //
        //    {
        //        for(int j = i; j < value; j++)
        //        {
        //            Console.Write("*");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //static void PrintReverseTriangle(int value)
        //{
        //    for (int i = 0; i < value; i++)
        //    {
        //        for (int j = 0; j < i + 1; j++)
        //        {
        //            Console.Write("*");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //static void PrintTriangleWhileLoof()
        //{
        //    string? input = Console.ReadLine();
        //    int.TryParse(input, out int value);

        //    while (value != 0)
        //    {
        //        Console.Write("*");
        //        value--;
        //    }
        //    Console.WriteLine();
        //}
        //static void Print9X9()
        //{
        //    while(true)
        //    {
        //        Print9x9();
        //    }
        //}

        //static void Print9x9() //리턴값 void 리턴값이 없을때 / 함수이름 /매개변수 : () 소괄호 안의 내용 parameter/ 함수 바디 : {} 중괄호 안의 내용 
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("출력할 단수를 입력하세요");

        //    string? input = Console.ReadLine();
        //    int.TryParse(input, out int result);

        //    for (int i = result; i < 10; i++)
        //    {
        //        for (int j = 1; j < 10; j++)
        //        {
        //            Console.Write("  " + i + "*" + j + "=" + i * j);
        //        }
        //        return;
        //    }
        //}

        //static void Print9X9(int dan)
        //{
        //    for (int i = 1; i < 10; i++)
        //    {
        //        Console.WriteLine(dan + "*" + i + "=" + dan * i);
        //    }
        //}
        //static void WhilePrintStar()
        //{
        //    Console.WriteLine("* 를 몇개 출력할까요?");
        //    string? input = Console.ReadLine();
        //    int.TryParse(input, out int result);

        //    int count = 0;
        //    while(count < result)
        //    {
        //        Console.Write("*");
        //        count++;
        //    }
        //    Console.WriteLine();
        //}

        //static void DoWhilePrintStar()
        //{
        //    Console.WriteLine("몇개를 찍을까요?");
        //    string? input = Console.ReadLine();
        //    int.TryParse(input, out int result);

        //    int count = 0;

        //    do
        //    {
        //        Console.Write("*");
        //        count++;
        //    }
        //    while (count < result);
        //}

        //static void PrintStarForLoof()
        //{
        //    Console.WriteLine("몇개를 찍을까요?");
        //    string? input = Console.ReadLine();
        //    int.TryParse(input, out int result);

        //    for(int i = 0; i < result; i++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}



        //static Grade grade;
        //public static int category;
        //static void PrintAge()
        //{
        //    Console.WriteLine("나이를 입력하세요");
        //    string? input = Console.ReadLine();
        //    int.TryParse(input, out int age);

        //    if (age < 8)
        //    {
        //        Console.WriteLine("미취학 아동입니다.");
        //        category = 1;          
        //    }
        //    else if (age <= 13)
        //    {
        //        Console.WriteLine("초등학생 입니다.");
        //        category = 2;
        //    }
        //    else if (age <= 16)
        //    {
        //        Console.WriteLine("중학생 입니다.");
        //        category = 3;
        //    }
        //    else if (age <= 19)
        //    {
        //        Console.WriteLine("고등학생 입니다.");
        //        category = 4;
        //    }
        //    else
        //    {
        //        Console.WriteLine("성인 입니다.");
        //        category = 5;
        //    }
        //}
        //static void UsingSwitch()
        //{
        //    switch (category)
        //    {
        //        case 1:
        //            Console.WriteLine("미취학 아동의 버스요금은 무료입니다.");
        //            break;
        //        case 2:
        //            Console.WriteLine("초등학생 아동의 버스요금은 500원 입니다.");
        //            break;
        //        case 3:
        //        case 4:
        //            Console.WriteLine("청소년의 버스요금은 1000원 입니다.");
        //            break;
        //        case 5:
        //            Console.WriteLine("성인 아동의 버스요금은 1500원 입니다.");
        //            break;
        //        default:
        //            Console.WriteLine("잘못된 입력입니다.");
        //            break;
        //    }
        //}
        //컴퓨터는 문자 또한 숫자로 변환한 다음 저장하기 때문에  문자열로 switch문을 이용해 비교하는 것은 권장되지 않는다. 숫자로 비교하는 것이 연산속도가 빠르다.

        //실습
        //성적입력받기 1~100
        // 범위가 벗어나면 잘못된 범위입니다 출력
        // 100~91 A 81~90, 71~80, 61~70,
        //등급은 enum 으로 변수에 저장
        //switch문 이용 출력

        //enum Grade
        //{
        //    None,
        //    GradeA,
        //    GradeB,
        //    GradeC,
        //    GradeD,
        //    GradeF
        //}
        //static void SetScore()
        //{
        //    Console.WriteLine("점수를 입력해주세요");
        //    string? input = Console.ReadLine();
        //    int.TryParse(input, out int score);
        //    if (score > 100 || score < 0)
        //    {
        //        Console.WriteLine("잘못된 입력입니다.");
        //        grade= Grade.GradeF;
        //    }
        //    else
        //    {
        //        if (score > 90)
        //        {
        //            grade = Grade.GradeA;
        //        }
        //        else if (score > 80)
        //        {
        //            grade = Grade.GradeB;
        //        }
        //        else if (score > 70)
        //        {
        //            grade = Grade.GradeD;
        //        }
        //        else if (score > 60)
        //        {
        //            grade = Grade.GradeF;
        //        }
        //        else
        //        {
        //            grade = Grade.GradeF;

        //        }
        //    }


        //}
        //static void PrintScore()
        //{
        //    switch (grade)
        //    {
        //        case Grade.GradeA:
        //            Console.WriteLine("당신의 등급은 A 입니다.");
        //            break;
        //        case Grade.GradeB:
        //            Console.WriteLine("당신의 등급은 B 입니다.");
        //            break;
        //        case Grade.GradeC:
        //            Console.WriteLine("당신의 등급은 C 입니다.");
        //            break;
        //        case Grade.GradeD:
        //            Console.WriteLine("당신의 등급은 D 입니다.");
        //            break;
        //        case Grade.GradeF:
        //            Console.WriteLine("당신의 등급은 F 입니다.");
        //            break;
        //        default:
        //            Console.WriteLine("잘못된 입력입니다.");
        //            break;
        //    }
        //}

        //연산자 Operator +-*/%
        //대입연산자 = 오른쪽의 값을 왼쪽에 복사
        //비교연산자 <,>, <=, >=, ==, != bool값 리턴 
        //논리연산자 &&(양쪽 모두 true일 때 true)  ||(한쪽이라도 true이면 true)  
        // C#기준 if문 보다 switch문이 연산속도가 빠르다
        // 증감연산자 ++, -- +=, -=, *= /= %=
        //while
        // 변수와 함수를 담아놓은 것 class , 일반적으로 파일 하나에 class 하나를 할당하는 것이 관리하기 용이하다.

    }
}



    
