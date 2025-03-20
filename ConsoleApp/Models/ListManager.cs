namespace MyApp.Models;


public class ListManager // Responsible for operations on the users list
{
    private List<User> UsersList = new List<User>();
    private static ListManager? _Instance = null; 
    
    
    public static ListManager GetInstance(){ // Singleton pattern, works as a factory and allows us to instanciate a single ListManager object
        if (_Instance == null){
            _Instance = new ListManager();
            
            return _Instance;
        }
        else{
            return _Instance;
        }
    }
    
    public void AddUser(User user){
        UsersList.Add(user);
    }
    
    
    public void ListAllUsers(){
        
        Console.WriteLine("All current users:");
        
        foreach(User user in UsersList){
            Console.WriteLine("{0}", user.Name);
        }
    }
    
    
    public void SearchUserByName(string? name){
        
        bool exists = false;
        
        foreach(User user in UsersList){
            
            if(user.Name == name){
                Console.WriteLine("user {0} info: age:{1}, email:{2}.", user.Name, user.Age, user.Email);
                exists = true;
                continue;
            }
        }
        
        if(exists == false){
            Console.WriteLine("No user named: {0}.", name);
        }
    }


    public int GetCount(){
        return UsersList.Count;
    }
}