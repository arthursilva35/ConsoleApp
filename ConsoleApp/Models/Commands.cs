
namespace MyApp.Models;

public interface ICommand // Command pattern interface, used to avoid excessive if's and switch/case's and to keep main function simpler
{
	void Execute();
}


public class CreateUser : ICommand // Controls user creation logic
{

	public void Execute() {
        string? name;
        string? email;
        string? age_input;
		
        do
        {
            Console.WriteLine("Input user's name:");
            name = Console.ReadLine();

        } while (NullChecker.CheckString(name)); //Guarantees name field is not empty


        do
        {
            Console.WriteLine("Input user's age:");
            age_input = Console.ReadLine();

        } while (NullChecker.CheckString(age_input)); //Guarantees age field is not empty

        int age = Convert.ToInt32(age_input);
    
        
		do
        {
            Console.WriteLine("Input user's email:");
            email = Console.ReadLine();

        } while (NullChecker.CheckString(email)); //Guarantees email field is not empty
        
        
        User cur_user = new User(name, age, email); // Create new object from User class


		Console.WriteLine("Created user {0}!", cur_user.Name);

		
		ListManager users_list = ListManager.GetInstance();
		users_list.AddUser(cur_user); // Adds users to users list
	}
}


public class ListUsers: ICommand // Controls user listing logic
{
    public void Execute(){
        ListManager users_list = ListManager.GetInstance();

        
        if(users_list.GetCount() == 0){
            Console.WriteLine("No users were created yet.");
            
        }else{
            users_list.ListAllUsers();
        }
        
    }
}

public class SearchUser: ICommand  // Controls user search logic
{
    public void Execute(){
        string? name;

        do
        {
            Console.WriteLine("Input user's name:");
            name = Console.ReadLine();

        } while (NullChecker.CheckString(name)); //Guarantees name field is not empty
        
        ListManager users_list = ListManager.GetInstance();
        users_list.SearchUserByName(name);
    }
}