create table Heroes (
	ID integer not null primary key autoincrement,
	Name text not null,
	HeroName text not null,
	Power text not null,
	Age integer not null,
	unique(HeroName)
);
