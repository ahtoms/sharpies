# Array Select

You are to construct a method that will be able to return
a value from an array given as an argument. However, there
is a quirk with this function. Instead of simply accepting
or expecting indexes which are within the bounds of the array
( >= 0 or < array.Count() ), index must loop around.

Example:

Given an array with the following numbers { 10, 20, 25, 34, 40, 55 }
    and we access the array with the following indexes:
    * 0 -> 10
    * 5 -> 55
    * 7 -> 20
    * -1 -> 55

You will need to implement the following method to ensure
that it can handle this quirk.

```
public static int? Select(int[] array, int index)
```

The main except case to handle is when the array size is 0. You will
need to return a null value.



## How to run?

Make sure you run your application with `dotnet test` to
test your solution against the suite of test cases.



