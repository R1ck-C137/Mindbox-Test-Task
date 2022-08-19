create table Products
(
Id bigint identity(1,1) not null primary key,
NameProduct varchar(50) not null,
IdCategory bigint
)

create table Categories
(
Id bigint identity(1,1) not null primary key,
NameCategory varchar(50) not null
)
select prod.NameProduct [Имя продукта], cat.NameCategory [Имя категории]
from Products prod
join Categories cat on prod.IdCategory = cat.id
order by cat.NameCategory

