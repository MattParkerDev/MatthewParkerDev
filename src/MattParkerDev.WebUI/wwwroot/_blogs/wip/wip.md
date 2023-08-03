## Expecting Professionalism: The Programmer's Oath

I recently watched a recording of a presentation given by Robert C. Martin, more affectionately known as Uncle Bob, titled `Expecting Professionalism`.

The summary on his [website](http://cleancoder.com/products) reads:

> In this talk, Uncle Bob transports you into an alternate reality where he is your new CTO. This is what he expects from you.
> As you listen, notice how reasonable these expectations are to customers and users. Notice also how impossible they appear to programmers.

This is a brilliant talk and I recommend watching it if you have time. [YouTube](https://www.youtube.com/watch?v=BSaAMQVq01E)

### 1. Dont Ship #@!%

```csharp
public void Ship()
{
    if (IsShipable())
    {
        // Ship it!
    }
}
```