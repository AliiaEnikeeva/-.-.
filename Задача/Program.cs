﻿// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись искючительно массивами.


string[] arr1 = {"hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};

int max_word_length = 3;

string[] GetShortWordsArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i=0;i<length;i++)
    {
        if(array[i].Length<=max_word_length)
        {
            result[count]=array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}

void PrintArray(string[] array)
		{
			if(array.Length == 0)
			{
				Console.WriteLine("отсутствует");
			}
			else
			{
				Array.ForEach(array, (str) => Console.Write($"{str} "));
				Console.WriteLine();
			}
		}
		
		void PrintTask(string[] array)
		{
			Console.WriteLine("Введен массив:");
			PrintArray(array);
			string[] shortArray = GetShortWordsArray(array);
			Console.WriteLine($"Элементы массива содержащие {max_word_length} символа");
			PrintArray(shortArray);
			Console.WriteLine();
		}
		
		PrintTask(arr1);
		PrintTask(arr2);
		PrintTask(arr3);
	

