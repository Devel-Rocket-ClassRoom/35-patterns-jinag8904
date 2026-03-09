using System;

// 1-1.
{
    object o = "Hello";
    if (o is string s) Console.WriteLine(s.Length);
}
Console.WriteLine();

// 1-2.
{
    object o = 42;
    if (o is int number)
    {
        Console.WriteLine($"정수값: {number}");
        Console.WriteLine($"제곱: {number * number}");
    }
    else
    {
        Console.WriteLine("정수가 아님");
    }
}
Console.WriteLine();

// 1-3.
{
    PrintInfo(100);
    PrintInfo(3.14);
    PrintInfo("Hello");
    PrintInfo(true);
    PrintInfo(DateTime.Now);

    void PrintInfo(object obj)
    {
        switch (obj)
        {
            case int i:
                Console.WriteLine($"정수: {i}, 2배: {2 * i}");
                break;
            case double d:
                Console.WriteLine($"실수: {d}");
                break;
            case string s:
                Console.WriteLine($"문자열: {s}, 길이: {s.Length}");
                break;
            case bool b:
                Console.WriteLine($"불리언: {b}");
                break;
            default:
                Console.WriteLine($"기타 타입: {obj.GetType().Name}");
                break;
        }   
    }
}
Console.WriteLine();

// 2.
{
    CheckValue(0);
    CheckValue("Hello");
    CheckValue(null);
    CheckValue(42);

    void CheckValue(object obj)
    {
        if (obj is 0)
        {
            Console.WriteLine("값이 0임");
        }

        else if(obj is "Hello")
        {
            Console.WriteLine("값이 Hello임");
        }

        else if (obj is null)
        {
            Console.WriteLine("값이 null임");
        }

        else
        {
            Console.WriteLine($"다른 값: {obj}");
        }
    }
}
Console.WriteLine();

// 3-1.
{
    Console.WriteLine(GetDayType(DayOfWeek.Monday));
    Console.WriteLine(GetDayType(DayOfWeek.Sunday));

    string GetDayType(DayOfWeek day) => day switch
    {
        DayOfWeek.Saturday => "주말",
        DayOfWeek.Sunday => "주말",
        _ => "평일"
    };
       
}
Console.WriteLine();

// 3-2.
{
    Console.WriteLine(DescribeValue(42));
    Console.WriteLine(DescribeValue(3.14));
    Console.WriteLine(DescribeValue("Hello"));
    Console.WriteLine(DescribeValue(null));
    Console.WriteLine(DescribeValue(true));

    string DescribeValue(object obj) => obj switch
    {
        int i => $"정수 {i}",
        double d => $"실수 {d}",
        string s => $"문자열 {s}",
        null => $"null 값",
        _ => $"알 수 없는 타입 ({obj.GetType().Name})"
    };
}
Console.WriteLine();

// 4-1.
{
    Console.WriteLine($"95점: {GetGrade(95)}");
    Console.WriteLine($"85점: {GetGrade(85)}");
    Console.WriteLine($"75점: {GetGrade(75)}");
    Console.WriteLine($"65점: {GetGrade(65)}");
    Console.WriteLine($"55점: {GetGrade(55)}");

    char GetGrade(int score) => score switch
    {
        >= 90 => 'A',
        >= 80 => 'B',
        >= 70 => 'C',
        >= 60 => 'D',
        _ => 'F'
    };
}
Console.WriteLine();

// 4-2.
{
    Console.WriteLine($"-5도: {-5}");
    Console.WriteLine($"5도: {5}");
    Console.WriteLine($"15도: {15}");
    Console.WriteLine($"25도: {25}");
    Console.WriteLine($"35도: {35}");

    string ClassifyTemperature(int celsius) => celsius switch
    {
        < 0 => "영하",
        < 10 => "추움",
        < 20 => "선선함",
        < 30 => "따뜻함",
        _ => "더움",
    };
}
Console.WriteLine();

// 5-1.
{
    Console.WriteLine($"25살 유효한 나이: {IsValidAge(25)}");
    Console.WriteLine($"-5살 유효한 나이: {IsValidAge(-5)}");
    Console.WriteLine($"15살 청소년: {IsTeenager(15)}");
    Console.WriteLine($"25살 청소년: {IsTeenager(25)}");

    bool IsValidAge(int age) => age is >= 0 and <= 150;

    bool IsTeenager(int age) => age is >= 13 and <= 19;
}
Console.WriteLine();

// 5-2.
{
    Console.WriteLine($"토요일 주말: {IsWeekend(DayOfWeek.Saturday)}");
    Console.WriteLine($"월요일 주말: {IsWeekend(DayOfWeek.Monday)}");
    Console.WriteLine($"'a' 모음: {IsVowel('a')}");
    Console.WriteLine($"'b' 모음: {IsVowel('b')}");

    bool IsWeekend(DayOfWeek day) => day is DayOfWeek.Sunday or DayOfWeek.Saturday;
    bool IsVowel(char c) => char.ToLower(c) is 'a' or 'e' or 'i' or 'o' or 'u';
}
Console.WriteLine();

// 5-3.
{
    Console.WriteLine($"\"Hello\" not null: {IsNotNull("Hello")}");
    Console.WriteLine($"null not null: {IsNotNull(null)}");
    Console.WriteLine($"\"Hi\" not empty: {IsNotEmpty("Hi")}");
    Console.WriteLine($"\"\" not empty: {IsNotEmpty("")}");

    bool IsNotNull(object obj) => obj is not null;
    bool IsNotEmpty(string s) => s is not (null or "");
}
Console.WriteLine();

// 5-4.
{
    Console.WriteLine($"0: {ClassifyNumber(0)}");
    Console.WriteLine($"5: {ClassifyNumber(5)}");
    Console.WriteLine($"42: {ClassifyNumber(42)}");
    Console.WriteLine($"-3: {ClassifyNumber(-3)}");
    Console.WriteLine($"100: {ClassifyNumber(100)}");
    Console.WriteLine($"-50: {ClassifyNumber(-50)}");

    string ClassifyNumber(int n) => n switch
    {
        0 => "영",
        >= 1 and <= 9 => "한 자리 양수",
        >= 10 and 99 => "두 자리 양수",
        <= -1 and >= -9 => "한 자리 음수",
        _ => "그 외"
    };
}
Console.WriteLine();

// 6.
{
    Console.WriteLine($"Janet: {IsJanetOrJohn("Janet")}");
    Console.WriteLine($"john: {IsJanetOrJohn("john")}");
    Console.WriteLine($"Mike: {IsJanetOrJohn("Mike")}");

    bool IsJanetOrJohn(string name) =>
        name.ToUpper() is var upper && (upper == "JANET" || upper == "JOHN");
}
Console.WriteLine();

// 7-1.
{
    Person p1 = new Person { Name = "철수", Age = 15 };
    Person p2 = new Person { Name = "영희", Age = 30 };
    Person p3 = new Person { Name = "할머니", Age = 70 };

    Console.WriteLine($"{p1.Name}({p1.Age}세): {DescribePerson(p1)}");
    Console.WriteLine($"{p2.Name}({p2.Age}세): {DescribePerson(p2)}");
    Console.WriteLine($"{p3.Name}({p3.Age}세): {DescribePerson(p3)}");

    string DescribePerson(Person p) => p switch
    {
        { Age: < 18 } => "미성년자",
        { Age: < 65 } => "성인",
        _ => "노인",
    };
}
Console.WriteLine();

// 7-2.
{
    Person p1 = new Person { Name = "철수", Age = 15 };
    Person p2 = new Person { Name = "영희", Age = 30 };

    Console.WriteLine(Greet(p1));
    Console.WriteLine(Greet(p2));

    string Greet(Person p) => p switch
    {
        { Name: var name, Age: <18 } => $"안녕, {name}!",
        { Name: var name } => $"안녕하세요, {name} 님"    
    };
}
Console.WriteLine();

// 7-3.
{
    Person[] people =
    {
        new Student {Name = "철수", Age = 17, School = "서울고"},
        new Employee {Name = "영희", Age = 28, Company = "삼성"},
        new Person {Name = "민수", Age = 17}
    };

    foreach (Person person in people)
    {
        Console.WriteLine(DescribeDetailed(person));
    }

    string DescribeDetailed(Person p) => p switch
    {
        Student { Name: var name, Age: var age, School: var school } => $"{name}: {age}세 학생, {school} 재학",
        Employee { Name: var name, Age: var age, Company: var company } => $"{name}: {age}세 직장인, {company} 근무",
        { Name: var name, Age: var age } => $"{name}: {age}세 일반인"
    };
}
Console.WriteLine();

// 8. 튜플 건너 뜀

// 9-1.
{
    Console.WriteLine(DescribeNumber(0));
    Console.WriteLine(DescribeNumber(4));
    Console.WriteLine(DescribeNumber(7));
    Console.WriteLine(DescribeNumber(-6));
    Console.WriteLine(DescribeNumber(-3));

    string DescribeNumber(int n) => n switch
    {
        0 => $"0: 영",
        > 0 when n % 2 == 0 => $"{n}: 양의 짝수",
        > 0 when n % 2 != 0 => $"{n}: 양의 홀수",
        < 0 when n % 2 == 0 => $"{n}: 음의 짝수",
        < 0 when n % 2 != 0 => $"{n}: 음의 홀수"
    };
}
Console.WriteLine();

// 9-2.
{
    Product[] products =
    {
        new Product { Name = "마우스", Price = 25000, Stock = 0 },
        new Product { Name = "키보드", Price = 80000, Stock = 5 },
        new Product { Name = "모니터", Price = 300000, Stock = 20 },
        new Product { Name = "USB", Price = 5000, Stock = 100 }
    };

    foreach (Product product in products)
    {
        Console.WriteLine(GetProductStatus(product));
    }

    string GetProductStatus(Product p) => p switch
    {
        { Name: var name, Stock: 0 } => $"{name}: 품절",
        { Name: var name, Stock: < 10 } when p.Price > 10000 => $"{name}: 재고 부족 (고가 상품)",
        { Name: var name, Stock: < 10 } => $"{name}: 재고 부족",
        { Name: var name, Price: > 50000 } => $"{name}: 프리미엄 상품",
        { Name: var name } => $"{name}: 일반 상품"
    };
}
Console.WriteLine();

// 10.
{
    Character[] characters =
    {
        new Character { Health = 0, Mana = 50 },
        new Character { Health = 15, Mana = 30 },
        new Character { Health = 50, Mana = 0 },
        new Character { Health = 90, Mana = 85 },
        new Character { Health = 60, Mana = 40, IsInCombat = true },
    };

    int count = 1;

    foreach (Character character in characters)
    {
        Console.WriteLine($"캐릭터{count++} (HP:{character.Health}, MP:{character.Mana}): {GetCharacterStatus(character)}");
    }

    string GetCharacterStatus(Character c) => c switch
    {
        { Health: 0 } => "사망",
        { Health: <= 20 } => "위험! 즉시 회복 필요",
        { Mana: 0 } => "마나 고갈 - 물리 공격만 가능",
        { Health: >= 80, Mana: >= 80 } => "최상의 상태",
        { IsInCombat: true } => "전투 중"
    };
}

// 10.
class Character
{
    public int Health { get; set; }
    public int Mana {  get; set; }
    public bool IsInCombat { get; set; }
}

// 9-2.
class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Stock { get; set; }
}

// 7-3.
class Student : Person
{
    public string School { get; set; }
}

class Employee : Person
{
    public string Company { get; set; }
}

// 7-1, 7-2.
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}