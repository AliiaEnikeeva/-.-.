// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись искючительно массивами.

// 32.Задать массив из 8 целых элементов и вывести их на экран

string[] arr1 = {"hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"russia", "Denmark", "Kazan"};

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


