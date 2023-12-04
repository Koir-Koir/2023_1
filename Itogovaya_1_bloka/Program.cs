// Задание итоговой аттестации первого блока.
 // Массивы строк
 // Задача: Написать программу, которая из имеющегося массива строк
 // формирует новый массив из строк, длина которых меньше, либо равна
 // 3 символам. Первоначальный массив можно ввести с клавиатуры, либо
 // задать на старте выполнения алгоритма. При решении не рекомендуется
 // пользоваться коллекциями, лучше обойтись исключительно массивами.
//

// Ошибки до компиляции
 // 
 // да/нет - написал без ошибок/с ошибками
 // 
// 

// Решение - код программы

using System;

class Program{
    static public void Main(string[] args){

            // Функция для ввода целого числа
        int ReadInt (string message)                
            {Console.Write(message);                
            string value = Console.ReadLine();      
            return int.Parse(value); 
        }

            // Функция проверки элементов массива на определённую длинну 
            // и генерации нового масссива из них
        string[] FormNewMassivStrLessX(string[] oldMassiv, int stringLengthLess){
            string[] newMassiv = new string[0];
            for (int i = 0; i < oldMassiv.Length, i++){
                if (oldMassiv[i].Length < stringLengthLess){
                    int length = newMassiv.Length;
                    Array.Resize(ref newMassiv, length + 1);
                    newMassiv[length] = oldMassiv[i];
                }
            }
            return newMassiv;
        }

            // Функция вывода одномерногомассива на экран с объявлением вывода 
        void Print1xMassivString(string[] massivPrint, string message){
            Console.WriteLine($"\n {message}");
            for (int i = 0; i < massivPrint.Length; i++){
                Console.Write($"{massivPrint[i]}\t");
            }
            Console.WriteLine();
        }

    }
}