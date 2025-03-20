// See https://aka.ms/new-console-template for more information

namespace  MyApp.Models;


class App
{
	static void Main() {
        Console.WriteLine("Commands:\n - 'create' to create a new user.\n - 'list' to list all current user.\n - 'search' to search a specific user by name.");
        
		Dictionary<string, ICommand> commands = new Dictionary<string, ICommand> // Maps console commands to command pattern classes
		{
			{ "create", new CreateUser() },
			{ "list", new ListUsers() },
			{ "search", new SearchUser() }
		};
		
		
		ListManager list_man = ListManager.GetInstance();

		while(true) {
            Console.WriteLine("Type a Command or 'exit' to leave:");
			
			
			string? comm = Console.ReadLine(); // Read console input
			
            if (comm == "exit") {
				break;
			}

			else if (comm == null || !commands.ContainsKey(comm)) {
				Console.WriteLine("Please, type a valid command.");
			}

			else{
				commands[comm].Execute(); // Executes current command
			}
		}

		Console.WriteLine("Bye!");
	}
}
