# Project name: PasswordAI

# Deadline: 31/12/2024

# Assigned: 

# Description:

> Your uncle from Switzerland has come back to pay you a visit after 10 years of no contact. You used to like him 
when you were young as he often played cool magic tricks and also played your favorite songs on guitar. He was
rocking it. Now days you are mad he did not contact you for so long, but your parents make you spend some time
with him because "we are family" (in the voice of Dome Toretto from Fast&Furious franchise). You roll your eyes and
feel like vomiting for 1 second, but you agree to give a chance to your uncle. He looks a bit washed up and has a
lot less energy than the last time you saw him. He also got a lot thinner and his voice is hard to recognize. He
brings up stuff you used to do together 10 years ago, but you are not interested. After a short look around your
room, he sees a programming book on the table next to a laptop that plays some AI tutorial. His eyes start
glowing and his fake smile becomes genuine. He asks you to take part in his AI project regarding vaccines testing
software. Your attitude changes suddenly and are happy to hear about the project, but you remember that you've
read about AI for only 1 hour only and can't do much. Your uncle offers to teach you, but first you need to prove
him what you know. He asks if you can make him a  password manager. He cannot use a commercial version because of
lack of trust and he wants some custom features that nobody offers. You decide that it is an easy task and agree
in a rash. You continue to talk to your  uncle in a new light and by end of the day he also promised to send his
requirements weekly. He also wants the project to be named PasswordAI. You are surprised by the worst name a
program can have and reply that you will come back with a better one.
>
> The next day you decide you remember the C# classes you are taking and your C# teacher offers to help you define
the requirements, but you will do all the implementation. He says will make a great impression on you uncle.


# Technical requirements:

> [!NOTE]  
> After each lesson you will be assigned 1 or more tasks to implement. Each task will continue the work from previous
tasks. Make sure to finish them in order, or deal with the after-effects.


### Task 1 - Setup and core entities

1. Create a project called "PasswordAI" (you are encouraged to come up with your original name). It should be a console
application.

2. Create custom types to represent entities involved in a password manager: vault(collection of logins, credit cards,
etc.), login entry, credit card entry, tags(attribute that can be assigned to a secret), user.
3. Create a base type Secret that will be inherited by login, credit card and other secret type you wish to create. Asecret should contain a name, date created, date modified.    
4. Add specific traits for each type you create. You are free to add whatever you deem necessary.
    
    - A vault should have a name.
    - A login should have: user name, password, URI/URL
    - A tag should have a name.
    - An user should have a name and a master password.


| :memo:        | You can define properties as string whenever you don't know a better candidate (for this task only). |
|---------------|:-----------------------------------------------------------------------------------------------------|
