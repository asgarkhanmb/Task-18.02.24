//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.


//string Divide(int n)
//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        return "bolunur";
//    }
//    else
//    {
//        return "bolunmur";
//    }

//}
//Console.WriteLine(Divide(21));





//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.


//int Sum(int n,int m)
//{
//    int sum = 0;
//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        sum = n + m;
//    }
//    return sum;
//}
//Console.WriteLine(Sum(6, 8));



//void Sum(int n,int m)
//{
//    if (n%2==0 && m % 2 == 0)
//    {
//        Console.WriteLine(n + m);

//    }
//    else
//    {
//        Console.WriteLine("cut deyil");
//    }


//}
//Sum(4,7);



//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.



//int Result(int n, int m)
//{
//    int count = 0;

//    for (int i = n; i<m; i++) 
//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }

//    }
//    return count;

//}   

//Console.WriteLine(Result(1, 10));



//4) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.



//int SumOfNumbers(int n,int m)
//{
//    int sum = 0;
//    for (int i =n;i<m;i++)
//    {
//        if (i%2==1)
//        {
//            sum+=i;
//        }

//    }
//    return sum;
//}
//Console.WriteLine(SumOfNumbers(1,7));



//5)Verilmish arrayin icindeki tek ededlerin cemini tapin.



//int SumOfNumbers(int[] arr)
//{
//    int sum = 0;
//    for/ (int i = 0; i < arr.Length; i++)
//    {

//        if (arr[i] % 2 == 1)
//        {
//            sum =sum+arr[i];
//        }

//    }
//    return sum;
//}
//    int[] arr = { 1,2,3,4,5};

//Console.WriteLine(SumOfNumbers(arr));




//6)Verilmish arrayin icindeki cut ededlerin sayini tapin.


//int Numbers(int[]arr)
//{
//    int count = 0;
//    for (int i = 0;i<arr.Length;i++)
//    {
//        if (arr[i] % 2 == 0)

//        {
//            count++;
//        }
//    }
//    return count;
//}
//int[] arr = { 1, 2, 3, 4, 5,6};

//Console.WriteLine(Numbers(arr));




//7) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//string Numbers(int n)
//{
//    int count = 0;

//    if (n < 2)
//    {
//        return "Ne Sade,Ne Murekkeb";

//    }
//    else
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            if (n % i == 0)
//            {
//                count++;
//            }

//        }
//    }
//    if (count == 2)
//    {
//        return "sade";
//    }
//    else
//    {
//        return "murekkeb";
//    }

//}
//Console.WriteLine(Numbers(5));




//8)n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.
//Meselen: Cavablar ola biler:2,4,8,16,32 ve s. Yeni n bele ededler olmalidir.


//string Words(int n,int i)
//{
//    if (n <= 0)
//    {
//        return "musbet ededler daxil edin";
//    }
//    else
//    {
//        while (i<n )
//        {
//            i *= 2;
//        }
//        if (n == i)
//        {
//            return "beraberdir";
//        }
//        else
//            return "beraber deyil";

//    }
//}
//Console.WriteLine(Words(4,2));





//9)Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.Mes ([1,3,55,6,33], cavab: 18).



//int Nums(int[]arr)
//{
//    int result = 1;
//    for (int i = 0; i < arr.Length; i++)
//        result *= arr[i];
//    return result;
//}
//    int[] arr = { 1, 6, 15, 18, 19 };

//Console.WriteLine(Nums(arr));   



//10)Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.



//int Nums(int[] arr)
//{
//    int sum = 0;
//    for (int i = 0; i < arr.Length; i++)
//        if (arr[i]%2== 0)

//        sum += arr[i];

//    int result = sum * sum;

//    return result;

//}
//int[] arr = { 1, 2, 4, 5, 6, 7, 8, 9 };

//Console.WriteLine(Nums(arr));






//11)temp qebul eden method yazirsiz. 
//   Return type olan method olmalidir. 
//   Method temp 20den boyukdurse isti, kicikdirse soyuq, beraberdirse mulayim mesajlarini qaytarsin.


//string Words(int temp)
//{
//    string received;
//    if (temp > 20)
//    {
//        received = "isti";
//    }
//    else
//        if (temp < 20)
//    {
//        received = "soyuq";
//    }
//    else

//    {
//        received="mulayim";
//    }
//    return received;
//}
//Console.WriteLine(Words(10));



//12)methoda a ve b ededleri gelecek, method a ve b arasindaki ededlerin sayini qaytarsin.




//int Nums(int a,int b)
//{
//    int count = 0;
//    for (int i = a; i <b; i++)
//    {
//        count++;
//    }
//        return count;

//}
//Console.WriteLine(Nums(1, 6));




//13)method reqemlerden ibaret 2 array qebul edecek, her iki arrayin elementlerinin cemini geri qaytarsin.



//int Numbers(int[]arr1,int[] arr2)
//{
//    int sum = 0;
//    for (int i = 0;i<arr1.Length;i++)
//        sum += arr1[i];
//    {
//        for (int j = 0;j<arr2.Length;j++) 
//            sum += arr2[j];
//    }
//    return sum;
//}
//int[] arr1 = { 1, 2, 3, 4 };
//int[] arr2 = { 5, 6, 7, 8, 9 };
//Console.WriteLine(Numbers(arr1, arr2));




//14)methoda eded gelir, hemin method ededin kvadratini geriye qaytarsin.


//int Num(int a)
//{
//    int result = 0;
//    result = a * a;
//     return result;

//}
//Console.WriteLine(Num(4));



//15)methoda eded gelir, hemin method 1-den gelen edede qeder olan cut ededlerin cemini geri qaytarsin.


//int Num(int n)
//{
//    int sum = 0;
//    for (int i = 0; i <n; i++)
//    {
//        if (i % 2 == 0)
//            sum += i;
//    }
//    return sum;
//}
//Console.WriteLine(Num(6));
