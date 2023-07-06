using System;
using System.Linq;
namespace GetSet{
    class GetandSet{
        private string name;
        private string Email;
        public void setName(string name){
    if(!name.Any(char.IsDigit)){
       this.name=name;
    }else{
        this.name = "no name";  
 Console.WriteLine("Name can't contain numbers");
            }

        }
        public string GetName(){
            return name;
        }

public string email{

    get{ return Email; }
    set{
        if(value.Length>15){
 
          Email="no email";
           Console.WriteLine("email is too long");
        }
        else{
           Console.WriteLine( Email=value);
        }
    }

}

public int number{ get; set;} = 0;
public string Name { get; set;} = "no name";

    }
public class Test{
    public static void Main(string[]args){
        GetandSet getandSet=new GetandSet();
        getandSet.setName("bharu");
        Console.WriteLine(getandSet.GetName());
        getandSet.email="b.k@gmail.com";
            }
}

}