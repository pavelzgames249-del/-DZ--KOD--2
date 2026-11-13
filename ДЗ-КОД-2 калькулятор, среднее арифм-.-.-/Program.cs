// температура
using System.Xml;

double a = 1.8;
double b = 32;

Console.WriteLine("напиши температуру в градусах цельсия плиз :(");
double grad = Convert.ToInt32(Console.ReadLine());
double grad_1 = (grad * a) + b;
Console.Write($"если {grad} умножить на {a} и потом просто прибавить к результату {b} то у вас получиться температура в градусах ференгейта: ");
Console.WriteLine(grad_1);

Console.WriteLine(" ");
Console.WriteLine(" ");
// среднее арифмитическое 3 чисел

Console.WriteLine("среднее арифмитическое 3 чисел:");
Console.Write("введи 1 число: ");
double a_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введи 2 число: ");
double a_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введи 3 число: ");
double a_3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");

double srz = (a_1 + a_2 + a_3) / 3.0;
Console.WriteLine($"среднее арифмитическое ваших 3 чисел: {a_1} {a_2} {a_3} ровняется {srz}");
Console.WriteLine($"так как ваши 3 числа: {a_1} {a_2} {a_3} нужно сложить а затем поделить на 3. поделить на 3 потому что вы написали 3 числа и по этому 3 и получилось у вас {srz}. тоесть если бы вы написали 4 числа то делить пришлось бы на 4");

Console.WriteLine(" ");
Console.WriteLine(" ");
// колькулятор 

Console.WriteLine("это калькулятор напиши число какое действие хочешь сделать с 2 числами:");
Console.WriteLine("сложение: 1");
Console.WriteLine("вычитание: 2");
Console.WriteLine("умножение: 3");
Console.WriteLine("делениe: 4");
int vibor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");

Console.WriteLine("напиши те 2 числа с которыми хочешь провернуть выбранную функцию: ");
Console.Write("первое число: ");
int df_1 = int.Parse(Console.ReadLine());
Console.Write("второе число: ");
int df_2 = int.Parse(Console.ReadLine());

if(vibor == 1)
{
    double otv_1 = df_1 + df_2;
    Console.WriteLine($"{df_1} + {df_2} = {otv_1}");
}
else if (vibor == 2)
{
    double otv_1 = df_1 - df_2;
    Console.WriteLine($"{df_1} - {df_2} = {otv_1}");
}
else if (vibor == 3)
{
    double otv_1 = df_1 * df_2;
    Console.WriteLine($"{df_1} * {df_2} = {otv_1}");
}
else if (vibor == 4)
{
    double otv_1 = df_1 / df_2;
    Console.WriteLine($"{df_1} / {df_2} = {otv_1}");
}
else { Console.WriteLine("ты без грамотный! там нет такого выбора!"); }