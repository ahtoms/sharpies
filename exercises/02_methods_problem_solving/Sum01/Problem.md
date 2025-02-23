# Running Sum

You are to construct a program that will retrieve input from the user,
convert it to a integer numbers and continue to add it to the current
running total.

When the user enters in nothing or an EOF signal is sent, the program should
stop asking the user.


Example:

```
This program will maintain a running sum until there is no more data.

Enter a number: 200
Enter a number: 260
Enter a number: 100
Enter a number:

The total is: 560
```

## How to test?

You can test your program but running `dotnet test` against a suite of unit
tests.

