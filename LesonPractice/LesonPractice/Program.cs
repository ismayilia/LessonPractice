//static string ReverseStr(string str)
//{
//    string result = "";
//	for (int i = str.Length-1 ; i >=0; i--)
//	{
//		result+= str[i];
//	}
//	return result;
//}

//Console.WriteLine(ReverseStr("Cavid"));

//static void StrToUpper(string str)
//{
//    var firstChar = str[0].ToString().ToUpper();

//    var charArray = str.ToCharArray();

//    charArray[0] = Convert.ToChar(firstChar);

//    string result = "";

//    foreach (var item in charArray)
//    {
//        result += item;
//    }


//    Console.WriteLine(result);
//}

//StrToUpper("ismayil");



//string name = "Fidan";

//Console.WriteLine(name.Contains("i"));

//Console.WriteLine(name.Equals("Fidan"));

//Console.WriteLine(name.EndsWith("n"));


//var result = name.Substring(1, 2);

//Console.WriteLine(name.LastIndexOf(n));

//Console.WriteLine(name.GetType());


//static bool Search(string str, string searchText)
//{
//	return str.Trim().ToLower().Contains(searchText.Trim().ToLower());



//}



//if (Search("salam", "can"))
//{
//    Console.WriteLine("Found");

//}
//else
//{
//    Console.WriteLine("Notfound");
//}


//int[] arr1 = new int[2];
//int[] arr2 = new int[2] { 1, 5 };

//int[] numbers = {1, 2, 3, 4, 5};


//Array.Reverse(numbers);

//foreach (int item in numbers)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(numbers.FirstOrDefault());

//Array.Sort(numbers);

//var data = numbers.OrderBy(x => x).ToArray();

//foreach (int item in numbers)
//{
//    Console.WriteLine(item);
//}


//**** Ici bosh oludr default value 0 olur. Netice 0 verir.

//int[] nums = new int[3] ;

//nums[0] = 20;
//nums[1] = 30;
//nums[2] = 22;


//foreach (int item in nums)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(nums.Rank);

//Console.WriteLine(nums.Count());



//static void Search(string searchText)
//{
//    string[] people = { "Kubra", "Fidan", "Samir", "Ismayil" };

//    foreach (string item in people)
//    {
//        if (item.Trim().ToLower()==searchText.Trim().ToLower())
//        {
//            Console.WriteLine(item);
//            return;
//        }
//    }


//}

//Search("fidan");



//string name1 = "Ismayil";
//string surname1 = "Efendizade";
//int age1 = 29;

//string name2 = "Xeyyam";
//string surname2 = "Isgenderov";
//int age2 = 29;

//string name3 = "Cahangir";
//string surname3 = "Axundov";
//int age3 = 20;



//using LesonPractice;

//var stu1 = new
//{
//    name = "Ismayil",
//    surname = "Efendizade",
//    age = 19
//};

//var stu2 = new
//{
//    name = "Xeyyam",
//    surname = "Isgenderov",
//    age = 29
//};


//var stu3 = new
//{
//    name = "Cahangir",
//    surname = "Axundov",
//    age = 20
//};






//string result1 = $"{stu1.name} {stu1.surname} {stu1.age}";
//string result2 = $"{stu2.name} {stu2.surname} {stu2.age}";


//Console.WriteLine(result1);
//Console.WriteLine(result2);

//object[] students = {stu1,stu2 ,stu3 };


//foreach (var item in students)
//{
//    Console.WriteLine(item);
//}

//using LesonPractice;

//Student stu1 = new Student();

//stu1.name = "Ismayil";
//stu1.surname = "Efendizade";
//stu1.age = 29;
//stu1.address = "Yasamal";



//Student stu2 = new Student();

//stu2.name = "Xeyyam";
//stu2.surname = "Isgenderov";
//stu2.age = 29;
//stu2.address = "Yasamal";

//Console.WriteLine(stu1.GetFullName());
//Console.WriteLine(stu2.GetFullName());


//Console.WriteLine("Add name: ");
//string  name = Console.ReadLine();

//Console.WriteLine("Add surname: ");
//string surname = Console.ReadLine();

//Console.WriteLine("Add age: ");
//int age = int.Parse(Console.ReadLine());

//Console.WriteLine("Add address: ");
//string address = Console.ReadLine();






//Student stu3 = new()
//{
//    name= name,
//    surname = surname,
//    age = age,
//    address = address
//};

//Console.WriteLine(stu3.name + " " + stu3.surname);




//Student[] students = { stu1, stu2, stu3 };

//foreach (var item in students)
//{
//    Console.WriteLine(item.name+ " " + item.surname);
//}





//Book book1 = new()
//{
//    name = "Xosrov ve Shirin",
//    author = "Nizami"
//};


//Console.WriteLine(book1.name + " " + book1.author);


















