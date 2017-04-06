# `OperatorList<T>` for .NET Framework

An implementation of Python-like lists for .NET Framework.

## Compatible .NET versions:

The library is compatible with following versions of .NET Framework:

* .NET Framework 4.5
* .NET Framework 4.6+
* .NET Standard 1.0 (See [here](https://blogs.msdn.microsoft.com/dotnet/2016/09/26/introducing-net-standard/) for details)

## Installation

Install [`Emzi0767.OperatorList`](https://www.nuget.org/packages/Emzi0767.OperatorList) from NuGet.

## Usage

Usage is fairly simple. First, you have to start. You can do that by installing the package (see installation above), and then adding `using Emzi0767;` to your code.

Up next, you want to create an instance of the list. You can do so by doing `var list = new OperatorList<T>();`. Then the fun begins.

### Basics

Ok, so let's say we want to make a list of `int`s, and play around with it. How?

```csharp
var list = new OperatorList<int>();
```

Hooray, our list exists now.

### Addition and subtraction

Ok, so we have a list. Buuuuut... it does nothing! What's so special about it? It doesn't even have any data!

Let's remedy that!

So let's add 1, 2, and 3 to the list.

```csharp
list.Add(1);
list.Add(2);
list.Add(3);
```

"But that's boring! You promised operators!"

Fine, here, let's add more numbers.

```csharp
list = list + 4;
list += 5;
list = list + 6 + 7;
```

"Whoa, this is fun!" I know! But there's even more!

Suppose you want to add multiple numbers like above. The above way for that would be slow, because the collection has to be copied and created for each addition.

Can we change it? Hell no, but we can work around it.

Suppose you have an array of ints.

```csharp
var array = new[] { 8, 9, 10 };
```

Let's add it to our list. "But you said it's slow!" I know what I said. I also know what I made.

```csharp
list = list + array;
```

"Whoa, this is so cool!" If you inspect your list now, you will see that it holds numbers 1, 2, 3, 4, 5, 6, 7, 8, 9, and 10.

"But wait! I only wanted numbers up to 9!" Well then remove 10, you dip. "But... that's boring!" No, it's not!

```csharp
list -= 10;
```

Tada! List no longer holds 10! "Whoa, this is so cool! But can I take it a step further?" Why, of course you can!

Say, you want to remove numbers 6, 7, 8, and 9. Let's do it the Cool Way™.

```csharp
var seq = Enumerable.Range(6, 4);
list = list - seq;
```

Check the list now! It holds 1, 2, 3, 4, and 5! "OMG this is the best thing ever!"

### Multiplication

Hang on! Our journey is not over yet! So our list holds numbers 1, 2, 3, 4, and 5. What if I want to make the list repeat that sequence exactly 3 times?

"Uh, create a new one and just copy it several times?" I guess that's one way, but I have a better way!

```csharp
list = list * 3;
```

"Wait, so what's that do?" Well, if you check the list now, it will look like this:

1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5

"That's awesome!"

### Comparison

Ok. Let's reset our list real quick, and create two additional ones.

```csharp
var list = new OperatorList<int>(new[] { 1, 2, 3 });
var list2 = new OperatorList<int>(new[] { 1, 2, 3 });
var list3 = new OperatorList<int>(new[] { 4, 5, 6 });
```

"What's this for?" Well, now you can also compare lists fairly easily! "But how?" Here's how.

```csharp
var eq1 = list == list2 // true
var eq2 = list == list3 // false
var eq3 = list != list3 // true
```

"Cool! What else can I do?" For that, I am going to need 2 more lists.

```csharp
var list4 = new OperatorList<int>(new[] { 1, 2 });
var list5 = new OperatorList<int>(new[] { 6, 7, 8, 9 });
```

"Ok, what's all that for?" Length comparisons! You can easily check which list is longer now!

```csharp
var eq4 = list > list4; // true
var eq5 = list < list4; // false
var eq6 = list >= list4; // true
var eq7 = list4 < list5; // true
```

### Logic

"So you've got all this, but is there maybe a quick way to check if a list is not null and contains items?" Why, yes, there is!

```csharp
if (list)
{
    // code here...
}
```

"Whoa..."

### Bitwise operations

Stay with me for a bit yet! We're not done!

This is the last chapter, I promise!

Ok, so during the course of your programming adventures, you prolly stumbled upon bitwise operators, namely AND (`&`), OR (`|`), and XOR (`&`).

You also probably heard about sets in maths. Say, you have sets A, and B. If you haven't, let's bring you up to speed. Let's define A = { 1, 2, 3 }, and B = { 3, 4, 5 }

Union of A and B equals contents of A and B sans their common part. In our case, this means that `Union(A, B) = { 1, 2, 3 } + { 3, 4, 5 } - { 3 } = { 1, 2, 3, 3, 4, 5, 6 } - { 3 } = { 1, 2, 3, 4, 5 }`

Intersection part of A and B equals contents of A and B sans their sum. In our case, this means that `Intersect(A, B) = { 1, 2, 3 } + { 3, 4, 5 } - { 1, 2, 3, 4, 5 } = { 1, 2, 3, 3, 4, 5 } - { 1, 2, 3, 4, 5 } = { 3 }`

Symmetric difference of A and B equals their union sans their intersection. In our case, this means that `SymmetricDiff(A, B) = Union(A, B) - Intersect(A, B) = { 1, 2, 3, 4, 5 } - { 3 } = { 1, 2, 4, 5 }`

I made that logic apply to these collections too!

How? Think of these bitwise operations in these terms:

* OR (`A | B`) is the same as `Union(A, B)`
* AND (`A & B`) is the same as `Intersect(A, B)`
* XOR (`A ^ B`) is the same as `SymmetricDiff(A, B)`

Let's redefine a couple things first.

```csharp
list = new OperatorList<int>(new[] { 1, 2, 3 });
list2 = new OperatorList<int>(new[] { 3, 4, 5 });
var int1 = 0;
```

Ok, now that stage is set, we can proceed to the show.

```csharp
list3 = list | list2; // { 1, 2, 3, 4, 5 }
list4 = list & list2; // { 3 }
list5 = list ^ list2; // { 1, 2, 4, 5 }
```

There's actually a bit more to that. These operators can be applied to collections and individual items as well. Let me show you.

```csharp
list3 = list | 3; // { 1, 2, 3 }
list3 = list | 4; // { 1, 2, 3, 4 }
int1 = list & 3; // 3
int1 = list & 4; // 4
list4 = list ^ 3; // { 1, 2 }
list4 = list ^ 4; // { 1, 2, 3, 4 }
```

"What's that AND behaviour? And how does it apply to nullables?" Well, you probably noticed that AND returns an item rather than list in this case. And if an item is not found, it returns `null` (or default value for types that are not nullable). Let's demonstrate on something nullable, like a string.

```csharp
var list6 = new OperatorList<string>(new[] { "one", "two", "three" });
var list7 = list6;
var str1 = null;

list7 = list6 | "four"; // { "one", "two", "three", "four" }
list7 = list6 | "three"; // { "one", "two", "three" }
str1 = list6 & "four"; // null
str1 = list6 & "three"; // "three"
list7 = list6 ^ "four"; // { "one", "two", "three", "four" }
list7 = list6 ^ "three"; // { "one", "two" }
```

That's about it. If you have any questions, issues, suggestions, you can always open an issue or submit a PR.

## License

The project is licensed under Apache License 2.0.