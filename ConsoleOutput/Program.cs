using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 傳出參數(Output parameter)與[參考呼叫]的實引數和虛引數都是共同佔用相同的記憶位址。
 * 兩者間主要差異在於[傳出參數]的實引數變數不必設初值即可作參數傳遞。
 * 若在[呼叫敘述]及[被呼叫方法]的引數串列參數前面加上out，即變為傳出參數。
 * 
 */

namespace ConsoleOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n **** Call Out 傳出參數 **** \n");
            int a, b;
            Console.WriteLine("\n 呼叫敘述 未進入方法前 a 和 b 未設定初值");
            //在[呼叫敘述]及[被呼叫方法]的引數串列參數前面加上out，即變為傳出參數
            CallOut(out a, out b);
            Console.WriteLine("\n 呼叫敘述 離開方法回主程式\t: a= {0}  b={1}", a, b);
            Console.Read();
        }

        private static void CallOut(out int x, out int y) //在[呼叫敘述]及[被呼叫方法]的引數串列參數前面加上out，即變為傳出參數
        {
            int z;
            x = 20;
            y = 30;
            Console.WriteLine("\n 方法內 交換前\t:x= {0},   y={1}", x, y);
            //將x, y兩數值作交換
            z = x;
            x = y;
            y = z;
            Console.WriteLine("\n 方法內 交換後\t:x= {0},   y={1}", x, y);
        }
    }
}

/*
 * 
 **** Call Out 傳出參數 ****


 呼叫敘述 未進入方法前 a 和 b 未設定初值

 方法內 交換前  :x= 20,   y=30

 方法內 交換後  :x= 30,   y=20

 呼叫敘述 離開方法回主程式      : a= 30  b=20


 */
