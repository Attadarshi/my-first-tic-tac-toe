using System.Collections.Generic;
using System.Timers;

class Program
{
    public static void Main(){
        List<string> list = new List<string>();
        string a1 = "   ";
        string a2 = "   ";
        string a3 = "   ";
        string b1 = "   ";
        string b2 = "   ";
        string b3 = "   ";
        string c1 = "   ";
        string c2 = "   ";
        string c3 = "   ";
        int n = 0;
        string XO =" ";
        while(true){
            if(n%2==0) XO = "X";
            else XO= "O";   
            Console.WriteLine("   1  | 2 |  3 ") ;
            Console.WriteLine("a  "+ a1 + "|" + a2 + "|" + a3);
            Console.WriteLine("   ---+---+---");
            Console.WriteLine("b  "+ b1 + "|" + b2 + "|" + b3);
            Console.WriteLine("   ---+---+---");
            Console.WriteLine("c  "+ c1 + "|" + c2 + "|" + c3);
            Console.WriteLine("enter block pos and input(example a1=X/O):");
            string temp = Console.ReadLine();
            foreach (char item in temp)
            {
                list.Add(item.ToString());
            }
            if (list[0]== "a")
            {
                if (list[1] == "1"){
                    a1 = " "+XO+" ";
                }
                if (list[1] == "2"){
                    a2 = " "+XO+" ";
                }
                if (list[1] == "3"){
                    a3 = " "+XO+" ";
                }
            }
            if (list[0]== "b")
            {
                if (list[1] == "1"){
                    b1 = " "+XO+" ";
                }
                if (list[1] == "2"){
                    b2 = " "+XO+" ";
                }
                if (list[1] == "3"){
                    b3 = " "+XO+" ";
                }
            }
            if (list[0]== "c")
            {
                if (list[1] == "1"){
                    c1 = " "+XO+" ";
                }
                if (list[1] == "2"){
                    c2 = " "+XO+" ";
                }
                if (list[1] == "3"){
                    c3 = " "+XO+" ";
                }
            }
            list.Clear();
            n++;
            if (n == 9)
            {
                Console.WriteLine("game over!, who won? you decide");
                break;
            }
        }
    }
    public static string AIplayer(string input){
        
        List<string> list = new List<string>();
        list.Add("a1");//0
        list.Add("b1");//1
        list.Add("b1");//2
        list.Add("a2");//3
        list.Add("b2");//4
        list.Add("c2");//5
        list.Add("a3");//6
        list.Add("b3");//7
        list.Add("c3");//8

        if (input != "b2")
        {
            return "b2";
        }

        return "0";
    }
}