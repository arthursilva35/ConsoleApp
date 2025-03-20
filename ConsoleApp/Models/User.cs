



namespace MyApp.Models;


public class User 
{
	public string? Name { get; }
	public int Age  { get; }
	public string? Email  { get; }



	public User(string? name, int age, string? email) {
		Name = name;
		Age = age;
		Email = email;

	}

}