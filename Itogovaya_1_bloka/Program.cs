// Задание итоговой аттестации первого блока.
 // Массивы строк
 // Задача: Написать программу, которая из имеющегося массива строк
 // формирует новый массив из строк, длина которых меньше, либо равна
 // 3 символам. Первоначальный массив можно ввести с клавиатуры, либо
 // задать на старте выполнения алгоритма. При решении не рекомендуется
 // пользоваться коллекциями, лучше обойтись исключительно массивами.
//

// Ошибки до компиляции
 // нет - написал с ошибками
 // да/нет - написал без ошибок/с ошибками
 // 1) не поставил две ";" : 39, 48 строка - поставил вместо неё ","
 // 2) не указал "Console." : 38 строка
 // 3) "ReadInt" вместо "ReadLine" 
 //
 //
 //
// 

// Решение - код программы

using System;

public class Program{
    // Блок функций(методов) программы
        // Функция для ввода целого числа
        public static int ReadInt (string message)                
            {Console.Write(message);                
            string value = Console.ReadLine();      
            return int.Parse(value); 
        }

        // Функция создания и заполнения одномерного строкового массива данной длины
        public static string[] CreateAndFillString1xArray(int lengthMassiv){
            string[] massiv = new string[lengthMassiv];
            for (int i = 0; i < massiv.Length; i++){
                Console.Write($"Введите значение номер {i+1} : ");
                massiv[i] = Console.ReadLine();
            }
            return massiv;
        }

        // Функция проверки элементов массива на определённую длинну 
        // и генерации нового масссива из них
        public static string[] FormNewMassivStrLessX(string[] oldMassiv, int stringLengthLess){
            string[] newMassiv = new string[0];
            for (int i = 0; i < oldMassiv.Length; i++){
                if (oldMassiv[i].Length < stringLengthLess + 1){
                    int length = newMassiv.Length;
                    Array.Resize(ref newMassiv, length + 1);
                    newMassiv[length] = oldMassiv[i];
                }
            }
            return newMassiv;
        }

        // Функция вывода одномерногомассива на экран с объявлением вывода 
        public static void Print1xMassivString(string[] massivPrint, string message){
            Console.WriteLine($"\n {message}");
            for (int i = 0; i < massivPrint.Length; i++){
                Console.Write($"{massivPrint[i]}\t");
            }
            Console.WriteLine();
        }
    //

    // Главная программа
    static public void Main(string[] args){
        // Переданы ли аргументы?
        string[] oldArray;
        if (args.Length > 0){
            oldArray = new string[args.Length];
            for (int i = 0; i < args.Length; i++){
                oldArray[i] = args[i];
            }
        }else{
            int lengthStringArray = ReadInt("Вы сейчас будите вводить произвольные строковые значения,\n"
                                            + "но, для начала, введите сколько хотите ввести значений : ");
            oldArray = CreateAndFillString1xArray(lengthStringArray);                           
        }

        int lengthStringLess = 3;
        string[] receivedArray = FormNewMassivStrLessX(oldArray, lengthStringLess);
        
        Print1xMassivString(oldArray, "Это введённый нами массив строк :");
        Print1xMassivString(receivedArray, "Это полученный по условию массив строк :");

    }
}