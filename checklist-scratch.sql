use Checklist;
go

create table dbo.Test(
	TestId int not null primary key identity,
	[Name] varchar(100) not null,
	[Value] varchar(100) not null
);
go

insert dbo.Test([Name],[Value])
values('Hello', 'World');

select * from dbo.Test;