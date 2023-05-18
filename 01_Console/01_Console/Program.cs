using System.Security.Cryptography.X509Certificates;

namespace _01_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////실습
            //1. 나이를 입력받기
            //2. 8살 미만이면 "미취학아동 출력"
            //3. 13살 미만이면 "초등학생 출력"
            //4. 16살 미만이면 "중학생 출력"
            //5. 19살 미만이면 "고등학생 출력"
            //PrintAge();
            //UsingSwitch();

            //SetScore();
            //PrintScore();
        }
   
        static Grade grade;
        public static int category;
        static void PrintAge()
        {
            Console.WriteLine("나이를 입력하세요");
            string? input = Console.ReadLine();
            int.TryParse(input, out int age);

            if (age < 8)
            {
                Console.WriteLine("미취학 아동입니다.");
                category = 1;          
            }
            else if (age <= 13)
            {
                Console.WriteLine("초등학생 입니다.");
                category = 2;
            }
            else if (age <= 16)
            {
                Console.WriteLine("중학생 입니다.");
                category = 3;
            }
            else if (age <= 19)
            {
                Console.WriteLine("고등학생 입니다.");
                category = 4;
            }
            else
            {
                Console.WriteLine("성인 입니다.");
                category = 5;
            }
        }
        static void UsingSwitch()
        {
            switch (category)
            {
                case 1:
                    Console.WriteLine("미취학 아동의 버스요금은 무료입니다.");
                    break;
                case 2:
                    Console.WriteLine("초등학생 아동의 버스요금은 500원 입니다.");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("청소년의 버스요금은 1000원 입니다.");
                    break;
                case 5:
                    Console.WriteLine("성인 아동의 버스요금은 1500원 입니다.");
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
        //컴퓨터는 문자 또한 숫자로 변환한 다음 저장하기 때문에  문자열로 switch문을 이용해 비교하는 것은 권장되지 않는다. 숫자로 비교하는 것이 연산속도가 빠르다.

        //실습
        //성적입력받기 1~100
        // 범위가 벗어나면 잘못된 범위입니다 출력
        // 100~91 A 81~90, 71~80, 61~70,
        //등급은 enum 으로 변수에 저장
        //switch문 이용 출력

        enum Grade
        {
            None,
            GradeA,
            GradeB,
            GradeC,
            GradeD,
            GradeF
        }
        static void SetScore()
        {
            Console.WriteLine("점수를 입력해주세요");
            string? input = Console.ReadLine();
            int.TryParse(input, out int score);
            if (score > 89 && score < 101)
            {
                grade = Grade.GradeA;
            }
            else if(score > 79 && score < 90)
            {
                grade = Grade.GradeB;
            }
            else if (score > 69 && score < 80)
            {
                grade = Grade.GradeC;
            }
            else if (score > 59 && score < 70)
            {
                grade = Grade.GradeD;
            }
            else if (score < 60 && score < 70)
            {
                grade = Grade.GradeF;
            }
            else 
            {
                Console.WriteLine("잘못된 입력입니다.");
            }

        }
        static void PrintScore()
        {
            switch (grade)
            {
                case Grade.GradeA:
                    Console.WriteLine("당신의 등급은 A 입니다.");
                    break;
                case Grade.GradeB:
                    Console.WriteLine("당신의 등급은 B 입니다.");
                    break;
                case Grade.GradeC:
                    Console.WriteLine("당신의 등급은 C 입니다.");
                    break;
                case Grade.GradeD:
                    Console.WriteLine("당신의 등급은 D 입니다.");
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }



    }  
}



    
