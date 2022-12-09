// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
void OutputArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while(index<length)
    {
        array[index] = new Random().Next();
        Console.WriteLine(array[index]);
        index ++;
    }
}
OutputArray(array);

//Random a = new Random(); 
//string OutputArray(Random b)   
//{
//        int [] array = new int [8];       
//    for(int i=0; i<array.Length; i++) 
//    {
//        array[i]= a.Next();  
//    }     
//    string output;                    
//    return output = string.Join(",",array);  
//}      
//Console.WriteLine(OutputArray(a));