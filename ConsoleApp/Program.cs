//Mathew Olsen, September 4th, 2024, Lab 1 Vigenere Cipher.

//Hello this program will accept any lowercase message and key and apply a Vigenere Cipher to encrypt them then read the encypted message back to you.


//Asks the user for a message and key and stores them in strings
Console.WriteLine("This program encrypts the characters of a message using the Vigenere method.\nPlease enter the message: ");
string message = Console.ReadLine();
Console.WriteLine("Please enter an encryption key: ");
string key = Console.ReadLine();

//Tests using the IsValidInput and IsLowercaseLetter methods to determine if the program can continue because all characters are lowercase. Then exits if this is not true.
if (cipher.IsValidInput(cipher.IsLowercaseLetter(message, key)) == false){
    Environment.Exit(7);
}

//Sends the message and key into the method ShiftMessage to be encrypted then stores it in encrypted string
string encrypted = cipher.ShiftMessage(message, key);
Console.WriteLine($"Here is the encrypted message: \n{encrypted}"); //Writes encrypted message to the console




public static class cipher {

//Tests if IsLowercase Letter returned true. If not will tell the user it was not accepted and return false.
public static bool IsValidInput(bool IsLower){
    if (IsLower == true){
        return true;
    }
    Console.WriteLine("Sorry, we only support lower-case letters.");
    return false;
}

// Returns true if the given character is a lowercase letter and false otherwise
public static bool IsLowercaseLetter(string message, string key) {
    if (key.All(char.IsLower) & message.All(char.IsLower)){ //finds if all characters in key and message are lowercase
        return true;
    }
    return false;
}

//encrypts a character by using the key and the message character given to return an encrypted character
public static char ShiftLetter(char message, char key){
    int encrypted = ((message-96) + (key-96)); //makes sure the number doesnt become incorrect by reducing each term by 97
        encrypted %= 26;   //modulo is used to wrap around maintaining lowercase letters
        encrypted += 96;   //97 is added back in to bring it back to the correct ascii table location for lowercase letters
    return (char)encrypted;
}

public static string ShiftMessage(string message, string key){
    string temp = "";
    int count = 0;
    foreach (char letter in message){
        temp += ShiftLetter(letter, key[count%key.Length]);
        count++;
    }
    return temp;
}
}


