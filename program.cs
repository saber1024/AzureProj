using System;
delegate double function(double x);

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
    static void Main(string[] args){
         Console.WriteLine("hellow world");
         
         double[] a = {1,2,3,4,5,6};
         double[] square = {2.3,4.2,4.1,5.2,3.5};
         double[] slice = Apply(a,Math.Sin);
         Multiplier m = new Multiplier(2.0);
         double[] alice = Apply(a,m.Mutiplily);

         Console.WriteLine(alice);
         
    }
}