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

select top (1) [Name] + ' ' + [Value] as TestValue from dbo.Test;

select * from Tasks where CompleteDate is null;