### Task 1 - Setup and core entities

1. Create a project called "PasswordAI" (you are encouraged to come up with your original name). It should be a console
application.

2. Create custom types to represent entities involved in a password manager: vault(collection of logins, credit cards,
etc.), login entry, credit card entry, tags(attribute that can be assigned to a secret), user.

3. Create a base type Secret that will be inherited by login, credit card and other secret type you wish to create. A
secret should contain a name, date created, date modified.
    
4. Add specific traits for each type you create. You are free to add whatever you deem necessary.
    
    - A vault should have a name.
    - A login should have: user name, password, URI/URL
    - A tag should have a name.
    - An user should have a name and a master password.


| :memo:        | You can define properties as string whenever you don't know a better candidate (for this task only). |
|---------------|:-----------------------------------------------------------------------------------------------------|
