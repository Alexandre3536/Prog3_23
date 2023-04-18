using System;

class Program {
    static void Main (string[] args){
        int num = 9;
        Tabuada(num, 0);
    }
    static void Tabuada (int num, int i ) {
        if (i<=10) {
             Console.WriteLine("{0} x {1} = {2}", num, i, num*i);
             Tabuada(num, i+1);    
    }
}
}

