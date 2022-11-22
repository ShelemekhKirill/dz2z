/* // Напишите программу, которая принимает на вход трехзначное число и на выводе 
// показывае вторую цифру этого числа. Обязательная проверка на ввод чисел больше/меньше 3-х знаков.

Console.WriteLine("Введи трехзначное число: ");
string Numbers = Console.ReadLine()!;

if(Numbers.Length != 3){
    Console.WriteLine("Введено неверное число!");
}

else{
    Console.WriteLine($"Вторая цифра трехзначного числа: {Numbers[1]}");
} */



// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Берем числа до 100000.

/* Console.WriteLine("Введи число: ");
string Numbers = Console.ReadLine()!;

if(Numbers.Length > 5){
    Console.WriteLine("Введено неверное число!");
}
else if(Numbers.Length < 3){
    Console.WriteLine("У заданного числа нет третьей цифры!");
}

else{
    Console.WriteLine($"Третья цифра заданного числа: {Numbers[2]}");
} */



/* // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7.

Console.WriteLine("введите цифру от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

switch (number)
{
    case 1:{
        Console.WriteLine("будний день: ");
        break;
    }
    case 2:{
        Console.WriteLine("будний день: ");
        break;
    }
    case 3:{
        Console.WriteLine("будний день: ");
        break;
    }
    case 4:{
        Console.WriteLine("будний день: ");
        break;
    }
    case 5:{
        Console.WriteLine("будний день: ");
        break;
    }
    case 6:{
        Console.WriteLine("выходной день: ");
        break;
    }
    case 7:{
        Console.WriteLine("выходной день: ");
        break;
    }
    default:{
        Console.WriteLine("неправильная цифра: ");  
        break;
    }
} */
