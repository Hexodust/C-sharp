# Project name: Fatty

# Deadline: 31/12/2024

# Assigned: 

# Description:

> The principal at your school asked you to create an online timetable for school. This project will automate 90% of
his work and allow him to fish all day at the nearest pond. You want to deny but he reminds you that all your pranks
in last 2 years have accumulated and you risk getting expelled. After a short negotiation where you mainly listen to
the principal with little words for yourself, you thank him for this opportunity and get out of his office with the
usual remark "Lose some weight you useless fat". On your way back to your class you wonder how to implement that
damned timetable, and you remember the C# classes you are taking. That's it. You decide it is a good idea to make
something practical instead of just learning theories and writing fancy one-liners. You will make a real project in C#.
Your C# teacher offers to help you define the requirements, but you will do all the implementation. He says it will
look good in your CV.

# Technical requirements:

> [!NOTE]  
> After each lesson you will be assigned 1 or more tasks to implement. Each task will continue the work from previous
tasks. Make sure to finish them in order, or deal with the after-effects.

### Task 1 - Setup and core entities

1. Create a project called "Fatty" (you are encouraged to come up with your original name). It should be a console
application.

2. Create custom types to represent people involved in a timetable: student, teacher, auxiliary personal, principal.
You are free to create types for any other individuals you identify and cannot be one of mentioned types.

3. Create a base type Person that will be inherited by all the above types. A person should have general traits: name,
age, eye color, etc. You are free to add whatever you deem necessary.

4. Add specific traits for each type you create. You are free to add whatever you deem necessary.
    
    - A teacher should have a specialization. It can be a string.
    - Auxiliary personal should have a designed area. It can be a string.
    - The principal should have an office. It can be a string.
    - A student should have a class leader. It can be a string.


| :memo:        | You can define properties as string whenever you don't know a better candidate (for this task only). |
|---------------|:-----------------------------------------------------------------------------------------------------|
