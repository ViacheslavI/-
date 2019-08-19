Select * from Forums

insert into Forums (Created, Title, [Description],ImagesUrl)
values
(GETDATE(), 'Python', 'A popular dynamic, stronly-typed general programming language with  a focus on readability','/images/forum/py.png'),
(GETDATE(), 'JavaScript', 'Mylti-paradigm language based on he ECMAScript specification','/images/forum/js.png'),
(GETDATE(), 'c#', 'An object-orinted programming language for building applications on the .NET Framework','/images/forum/c#.png'),
(GETDATE(), 'C++', 'A popular functional programming language','/images/forum/c.png'),
(GETDATE(), 'Go', 'Open-source statically-typed programming language developed at Google','/images/forum/go.png')