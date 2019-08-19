select * from Posts

insert into Posts (Content, Created, ForumId,Title,UserId)
Values
('Second Python Post ', GETDATE(),1,'Another Python Post!','9f1e0306-66eb-48b1-8694-a89422517efb'),

('More Python Post ', GETDATE(),1,'Another  Post!','9f1e0306-66eb-48b1-8694-a89422517efb'),

('More Content Post ', GETDATE(),1,'Using machine learning!','9f1e0306-66eb-48b1-8694-a89422517efb');

select * from AspNetUsers

select  p.Title as PostTitle, f.Title as ForumName,u.Email 
from Posts p 
inner join  Forums f on p.ForumId=f.Id
inner join AspNetUsers u on u.Id=p.UserId
where p.Id=1