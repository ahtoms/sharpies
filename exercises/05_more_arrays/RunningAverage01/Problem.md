# Running Average

You are writing a class that will maintain the current total and count
of data that has been inputted. You will need to implement the following
properties and methods.

* `double Total` - Total is able to be accessed publicly but only settable
    via `Add`, this holds onto the sum.

* `int Count` - Count is able to accessed publicly but only settable via
    `Add`, this holds onto how many elements have been added.

* `void Add(double amt)` - Adds `amt` to `Total` and adds 1 to `Count`.

* `double Average()` - Returns the average, using `Total` and `Count`.

These properties and methods are associated with the class `RunningAverage`.

## How to test

You are able to run this against a set of test cases using `dotnet test`.
