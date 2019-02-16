using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; 
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for(int i=0; i<n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int cnt = 0;
            bool flag = false;        //falg=можно представить что сейчас каждый член массива держит свой флаг(false)
                                      // и если он не prime то его флаг станет true , и мы выведем те члены массива
                                      //у кторых флаг false
            for(int i=0; i <n; i++)
            {
                flag = false;
                if (a[i] <= 1) continue;    //если член массива меньше или равен еднице то их не расматриваем
                else
                for(int j=2; j< Math.sqrt(a[i]); j++)
                       if (a[i] % j == 0) flag = true;     //если член массива не prime то вот тут он станет true
                    if (flag==false) cnt++;                    //считаем сколько у нас prime-ов
            }

            Console.WriteLine(cnt);

            for(int i=0; i<n; i++)
            {
                flag= false;
                if (a[i] <= 1) continue;
                else
                 for(int j=2; j<Math.sqrt(a[i]); j++)
                         if (a[i] % j == 0) flag = true;
                     if (flag==false) Console.Write(a[i] + " ");     //выводим все prime цифры
             }
            
        }  
    }
}
