using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleByRef
{
    /* 參考呼叫(Call By Refencnce)
     * 方法A 呼叫方法B時，若希望將方法B，的執行結果回傳給方法A,使用[傳值呼叫]是不可行的。
     * 若能將[實引數]和[虛引數]彼此對應的引數設成佔用[相同]的記憶體位址，此時虛引數一有改變，
     * 對應的實引數亦跟著改變,便可將方法B執行的結果回傳給方法A
     * 
     * 操作方式只要將虛引數及實引數宣告為[ref],即可成為參考呼叫
     * 須注意[參考呼叫]的實引數必須是變數、陣列、物件(即參考資料型別)
     * 不可為常數或運算式，實引數必須給以初值才能用
     * 
     */
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("\n **** Call By Reference 參考呼叫 **** \n");
            int a = 10;
            int b = 12;
            Console.WriteLine("\n呼叫敘述  未進入方法前\t :a= {0}  b={1}", a, b);
            //將[呼叫敘述]的實引數及[被呼叫方法]的虛引數宣告為ref，便成為參考呼叫
            //實引數中a和b 必須給以初值才能用
            CallRef(ref a, ref b);

            Console.WriteLine("\n呼叫敘述  離開方法回原處時\t :a= {0}  b={1}", a, b);

            Console.ReadLine();
        }

        private static void CallRef(ref int x, ref int y)
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


 **** Call By Reference 參考呼叫 ****


呼叫敘述  未進入方法前   :a= 10  b=12

 方法內 交換前  :x= 20,   y=30

 方法內 交換後  :x= 30,   y=20

呼叫敘述  離開方法回原處時       :a= 30  b=20


*/
