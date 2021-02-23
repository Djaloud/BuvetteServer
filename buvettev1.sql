
create table Produit (
	ref_produit varchar(30) not null primary key ,
    nom_produit varchar(50)
    );
	

create table Sous_Produit(
	id_sous_produit int PRIMARY KEY NOT NULL IDENTITY(1,1),
    nom_sous_produit varchar(50),
    prix_unitaire float,
    ref_produit varchar(30), /*references Produit(ref_produit)*/
	qte int
    );
    
create table Vente(
	id_vente int not null primary key IDENTITY(1,1),
	date_vente date,
    nom_produit_vendu varchar(50),
    qte int,
    prix_unitaire float,
	id_sous_produit int,/*NOT NULL references Sous_Produit(id_sous_produit)*/
	Heure_Vente time,
	EtatCommande varchar(40) default 'EN ATTENTE' NOT NULL
	);


ALTER TABLE Vente
ADD Heure_Vente TIME;
ALTER TABLE Sous_Produit
   ADD CONSTRAINT FK_T1_T2_Cascade_Produit
   FOREIGN KEY (ref_produit) REFERENCES Produit(ref_produit) ON DELETE CASCADE
ALTER TABLE Vente
   ADD CONSTRAINT FK_T1_T2_Cascade_sous_produit
   FOREIGN KEY (id_sous_produit) REFERENCES Sous_Produit(id_sous_produit) ON DELETE CASCADE
   
/* les insertions des [Produit]s */
insert into [Produit] values ('ref0','Boisson froid');
insert into [Produit] values ('ref1','Boisson chaud');
insert into [Produit] values ('ref2','Venoiserie');
insert into [Produit] values ('ref3','snack');
insert into [Produit] values ('ref4','Petit dejeuner');
insert into [Produit] values ('ref5','dejeuner');
select *from [Produit];


insert into [Sous_Produit] values('soda',4,20,'ref0');
insert into [Sous_Produit] values('Hawai',4,2,'ref0');
insert into [Sous_Produit] values('Sprite',4,10,'ref0');
insert into [Sous_Produit] values('cafe',12,5,'ref1');
insert into [Sous_Produit] values('the',12,1.5,'ref1');
insert into [Sous_Produit] values('petit pain',2,5,'ref2');
insert into [Sous_Produit] values('schneck',3,3,'ref2');
insert into [Sous_Produit] values('baguette',1.5,10,'ref2');
insert into [Sous_Produit] values('bimo',1,20,'ref3');
insert into [Sous_Produit] values('chocolat',2,10,'ref3');
insert into [Sous_Produit] values('ftoor beldi',15,2,'ref4');
insert into [Sous_Produit] values('tajine',20,5,'ref5');
insert into [Sous_Produit] values('poulet frite',20,5,'ref5');



