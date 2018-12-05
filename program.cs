using System;
delegate double function(double x);
delegate void message(string s);
class Multiplier{
     double factor;
    public Multiplier(double factor){
        this.factor = factor;

    } 
    public double Mutiplily(double x){
        return x * factor;
    }
}

class Program{
    private const string S = "jane";

    static double Square(double x){
        return x * x;
    }
    
    static double[] Apply(double[] a,function f){
        double[] result = new double[a.Length];
        for(int i = 0; i<result.Length; i++){
              result[i] = f(a[i]);
        }
        return result;
    }

    static void showMessage(string s){
          Console.WriteLine(s);
    }

    static void MessageWithArgment(string mess,message m){
           m(mess);
    }

    static void Main(string[] args){
         Console.WriteLine("hellow world");
         
         message handle = showMessage;
         handle(S);

        MessageWithArgment(S,showMessage);

         
    }
}