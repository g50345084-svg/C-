//create a class that stores 3 names of the city using indexer and print them 
class Cities{
    private string[] cities=new string[3];
    public string this[int index]{                    
        get { return cities[index]; }
        set { cities[index] = value; }
    }                                                                                                                                                                                               
}
class Program{
    static void Main(string[] args){
        Cities c=new Cities();
        c[0]="New York";
        c[1]="Los Angeles";
        c[2]="Chicago";
        for(int i=0;i<3;i++){
            Console.WriteLine(c[i]);
        }
    }
}
