## Expecting Professionalism: The Programmer's Oath

I recently watched a recording of a presentation given by Robert C. Martin, more affectionately known as Uncle Bob, titled `Expecting Professionalism`.

The summary on his [website](http://cleancoder.com/products) reads:

> In this talk, Uncle Bob transports you into an alternate reality where he is your new CTO. This is what he expects from you.
> As you listen, notice how reasonable these expectations are to customers and users. Notice also how impossible they appear to programmers.

This is a brilliant talk and I recommend watching it if you have time. [YouTube](https://www.youtube.com/watch?v=BSaAMQVq01E)

Robert makes 5 very important points which every programmer should consider, which I hope to distill concisely.

### 1. Dont Ship #@!%

Robert's first point is that we will not ship shit.

```csharp
public void Ship() // TODO: Fix
{
    if (IsShipable())
    {
        // Ship it!
    }
}
```

We will not, as a matter of ethics, knowingly ship code that is defective or substandard.

This is not something you need to ask your boss - "Is it okay if I don't ship shit today?"
As software developers, we are hired as professionals in our field - we are the experts. This is not something
you need to ask permission for - it is expected of you.

We should not violate this rule to meet deadlines.

### 2. We will always be ready
// Sprint length\
// Code should always be deployable

What is your sprint size?

### 3. Stable Productivity
greenfield - no code - how fast can you go? - business asks for a feature, yeah I can do that in a week.
Week later, all done. Fast forward a year - a new feature takes 6 months.
You will produce features just as fast a year from now, as you did today.
You will not slow down based on the mess you made, because you're not going to make the mess.
We will not go fast if that will cause us to go slow later.

### 4. Inexpensive Adaptability
Simple to change
WIP

### 5. Continuous Improvement
Code gets cleaner with time
designs improve with time
every system should be getting better, not worse.
Boyscout rule: every time you check in a module, you check it in cleaner than you checked it out.

### 6. Fearless Competence
If you fear it, you cannot clean it. If you cannot clean it, it rots.
WIP 36:39
