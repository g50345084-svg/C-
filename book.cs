//create a class that stores 3 names of the city using indexer and print them 
class Cities{
    `private string[] cities=new string[3];
    public string this[int index]{                    
        get { return cities[index]; }
        set { cities[index] = value; }
    }                                                                                                                                                                                               


}