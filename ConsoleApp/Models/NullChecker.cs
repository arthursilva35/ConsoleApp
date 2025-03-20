namespace MyApp.Models;

public class NullChecker{ // responsible for checking if input is empty
    
    public static bool CheckString(string? s){
        return s == String.Empty;
    }

}