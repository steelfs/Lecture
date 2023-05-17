namespace _01_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 변수 : 변하는 값;
            //float 177.5 => 1775 10^-1  정밀도 이슈 > or <  fine issue != or ==  
            // bit = 0 or 1 을 저장하는 타입
            // 정수 integer : 소숫점이 없는 숫자;
            // 실수 realNumber - 소숫점이 있는 숫자;
            // boolean
            // 문자열 string - 
            // C++ 메모리 집접 할당, 관리
            // C# garbage Collector 
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine($"나는 {age} 살 입니다.");
            //Console.WriteLine($"키는 {height:f2} 입니다.");

            //if (wannaGoHome)
            //{
            //    Console.WriteLine($"나는 {address}에 삽니다.");
            //}
            string a = "a";
            a = "b"; //a 는 메모리에 그대로 남아있다. 반면 int 타입은 그렇지 않다.
            Console.Write("이름을 입력하세요 : ");
            string? name = Console.ReadLine();
            Console.WriteLine($" {name}");

            Console.Write("나이를 입력하세요 : ");
            string? age = Console.ReadLine();
            int.TryParse(age, out int agenum); //문자를 숫자로 바꿀수 없는 상황이면 0
            Console.WriteLine($" {agenum}");

            Console.Write("키를 입력하세요 :");
            string? height1 = Console.ReadLine();
            float.TryParse(height1, out float realHeight);
            //float height = float.Parse(height1);
            Console.WriteLine($" {realHeight}");

            Console.Write("주소를 입력하세요 :");
            string address = Console.ReadLine();
            Console.WriteLine($" {address}");





        }
    }
}