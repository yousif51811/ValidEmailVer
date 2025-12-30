# Valid Email Verifier

Check if an email is valid using a simple C# script.
A great begginer-friendly project to help understand and work with strings better

## How to run
### 1. Make sure you have the .NET sdk installed
### 2. Clone the repository
```
> git clone https://github.com/yousif51811/ValidEmailVer.git
```
### 3. Run the project
```
> dotnet run
```
### 4. Enjoy

## How to use
Simply enter an email address and it will check wether or not it is valid and list the email username and domain
```
Enter you email address: yousif@example.com

Username: yousif
Domain: example.com
Valid Email
```

## How it works
### 1. Check the location of "@"
```
int atlocation = email.IndexOf("@");
```
### 2. Get domain and username using the @'s index
```
string? Domain = email.Substring((atlocation + 1)); // Added 1 To Not include the @ in the output
string? Username = email.Substring(0,atlocation);
```
### 3. Check the domain validity
Checks the domain validity by making sure it contains a "."
```
int dotlocation = Domain.IndexOf(".");

if (dotlocation <= 0 )
{
    throw new Exception("Invalid Domain!");                   
}
```
### 4. Output username and domain
```
Console.WriteLine($"\nUsername: {Username}");
Console.WriteLine($"Domain: {Domain}");
Console.ForegroundColor = ConsoleColor.Green;
break;
```
### 5. Catch errors for invalid emails
Using a try catch statement to prevent any invalid emails
```
try {
    // Program Code here
}
catch (Exception)
{
    Console.WriteLine("Invalid email!");
}
```

-----
### Made with ❤️ by yousif51811