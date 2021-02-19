using System;

namespace AggregationTest
{
public class Artist
{  
    public string name, genre;  
    public Artist (string name, string genre)  
    {  
    this.name = name;
    this.genre = genre; 
    }  
}  
public class Record  
{
    public string name;  
    public Artist artist;//Record has an artist  
    public Record(string name, Artist artist)  
    {  
        this.name = name;
        this.artist = artist;  
    }  
    public void display()  
    {  
        Console.WriteLine("The album is " + name + " by " + artist.name);  
    }  
}  
class Program
{
    static void Main(string[] args)
        {
            Artist a = new Artist("Kanye West", "Rap");
            Record r = new Record("Graduation", a);
            r.display();
        }
}
}
