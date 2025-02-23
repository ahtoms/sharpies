# Roller Coaster

You have to implement the function that will test to see if the
someone can ride the roller coaster. The method you need to implement has two
parameters. `height` and `threshold`.

* `height` - Indicates the height of the individual that wants to ride the roller coaster
* `threshold` - Indiciates the height limit that can be accepted, if the `height` is greater
    than the `threshold`, the rider can be allowed on, otherwise, they can't.

```
public static bool CheckHeight(int height, int threshold)
```

The method `CheckHeight` will return true if the height is greater than the threshold, otherwise
it will return false.

## How to test

You can test your program against a set of units test by running `dotnet test`.
