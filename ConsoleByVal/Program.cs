using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 引數的傳遞方式
 當使用return敘述時，一次只能傳回一個值或不傳回值返回到原呼叫處。
 若方法A 某個敘述呼叫另一個方法B時，而要一次傳兩個以上的值時，使用return就無法作到。
 就必須使用「參考呼叫」或「傳出參數」來達成。

引數的傳遞方式有三種：
1.傳值呼叫(Call By Value) 
2.參考呼叫(Call By Reference)
3.傳出參數(Output parameter)
 */

namespace ConsoleByVal
{
    /* 傳值呼叫(Call By Value)是指當呼叫方法時，此時[呼叫方法]的實引數,會複製一份給
     * [被呼叫方法的虛引數],因此實引數與虛引數兩者佔用不同的記憶體位址。
     * 當「被呼叫方法內的虛引數被修改時，結果並不會影響對應的實引數。
     * C#預設為傳值呼叫。
     * 適用於希望方法內的結果不影響方法外的變數使用。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n **** Call By Value 傳值呼叫 **** \n");
            int a = 10;
            int b = 12;
            Console.WriteLine("\n呼叫敘述  未進入方法前\t\t :a= {0}  b={1}", a, b); 
            //實引數，呼叫敘述(記憶體中分別佔不同位址)
            CallValue(a, b);
            Console.WriteLine("\n呼叫敘述  離開方法回原處時\t\t :a= {0}  b={1}", a, b);
           
            Console.ReadLine();
        }

        
        private static void CallValue(int x, int y) //被呼叫方法:傳值呼叫時虛引數必須設為變數
        {                                           //當a的值傳給x後，當x值的改變,對a並不會產生影響
            int z;
            x = 20;
            y = 30;
            Console.WriteLine("\n方法內  交換前\t\t\t:x = {0}  y={1}", x, y);
            //透過第三個變數z來做x,y值交換
            z = x;
            x = y;
            y = z;
            Console.WriteLine("\n方法內  交換後\t\t\t:x = {0}  y={1}", x, y);
        }
    }
}

/*
 
 **** Call By Value 傳值呼叫 ****


呼叫敘述  未進入方法前           :a= 10  b=12

方法內  交換前                  :x = 20  y=30

方法內  交換後                  :x = 30  y=20

呼叫敘述  離開方法回原處時               :a= 10  b=12


*/
