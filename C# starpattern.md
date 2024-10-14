# C#

## **Creating Star Patterns**

```csharp
for (int i=1; i<=5; i++)
{
	for (int j=1; j<=i; j++)
	{
		Console.Write("*");
	}
Console.WriteLine();
}
```

```csharp
for (int i = 5; i>= 1; i--)
{
	for (int j=1; j<=i; j++)
	{
	Console.Write("*");
	}
Console.WriteLine();
}
```

```csharp
*
**
***
****
*****
```

For each iteration of `i`, the inner loop prints `i` number of asterisks

```csharp
*****
****
***
**
*
```

For each iteration of `i`, the inner loop prints `i` number of asterisks

```csharp
for ( int i=1; i<=5; i++)
{
	for (int j=1; j<=i; j++)
	{
	Console.Write("*");
	}
Console.WriteLine();
}

for ( int k=4; k>=1; k--)
{
	for (int t=1; t<=k; t++)
	{
	Console.Write("*");
}
Console.WriteLine();
} 
```

```csharp
*
**
***
****
*****
****
***
**
*
```

```csharp
int n = 5;
for (int i=1; i<=n; i++)
{
// j is for spaces
	for (int j=n-i; j>0; j--)
	{
		Console.Write(" ");
	}
	// k is for stars
	for (int k=1; k<=2*i-1; k++)
	{
	Console.Write("*");
	}
Console.WriteLine();
}

// Print the inverted bottom pyramid
for (int i = n - 1; i >= 1; i--)
{
   for (int j = n - i; j > 0; j--)
   {
       Console.Write(" ");
    }
 for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }
   Console.WriteLine();
}
```

```csharp
    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *
```

1. **Top Pyramid**:
    - This part is exactly what you already have, printing a pyramid with a height of `n = 5`.
2. **Inverted Bottom Pyramid**:
    - The additional set of loops prints the inverted pyramid starting from `n-1` down to 1.
    - The number of spaces (`n - i`) and the number of stars (`2 * i - 1`) are calculated similarly to the top pyramid, but in reverse.

Breakdown for the Inverted Pyramid:

- **First inverted row**: `i = 4`, so `n - i = 1` space and `2 * i - 1 = 7` stars.
- **Second inverted row**: `i = 3`, so `n - i = 2` spaces and `2 * i - 1 = 5` stars.
- **Third inverted row**: `i = 2`, so `n - i = 3` spaces and `2 * i - 1 = 3` stars.
- **Fourth inverted row**: `i = 1`, so `n - i = 4` spaces and `2 * i - 1 = 1` star.

This produces a symmetric pattern that looks like a diamond or hourglass shape.