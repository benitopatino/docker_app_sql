create database DockerSqlTest

use DockerSqlTest
go

create table [TRANSACTION] (
    TransactionId uniqueidentifier not null PRIMARY key DEFAULT (NEWID()),
    Merchant varchar(50),
    Price money not null,
    TransactionDate datetime not null
)