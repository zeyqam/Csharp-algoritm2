//Task 1
//n-ededinin faktorialini hesablayin.
//int n = 9;
//int fac = 1;
//for (int i = 1; i <=n; i++)
//{
//    fac *= i;
//}
//Console.WriteLine(fac);

//task 2
//Verilmis arrayin icerisinde cut ededlerin ceminin kvadratini hesablayin.
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 9 };
//int cem=0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 ==0)
//    {
//        cem += arr[i];
//    }
//}
//int kvadrat = cem * cem;
//Console.WriteLine(kvadrat);
//Task 3
//n ededi gelir. n - ededinin 2-ni hansisa quvvete yukseltdikde alinan edede beraber olub-olmadigini tapin. Meselen : n ededi 4,8,16 ve s. gelirse yazilsin ki, 2-nin quvettidir. Eks halda quvveti deil yazilsin.

int n = 16;
int power = 1;
while (power < n)
{
    
    
        power *= 2;
    continue;
    
    
}

if (power==n && n!=1)
{
    Console.WriteLine(n + " 2 nin quvvetidir");
}
else
{
    Console.WriteLine("deyil");
}