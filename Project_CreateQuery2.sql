CREATE TABLE Users
(
      UserID int PRIMARY KEY IDENTITY, 
      NickName varchar (50) NOT NULL,
      Birthdate date NOT NULL,
      Gender varchar(6),
      CONSTRAINT CK_MaleFemale CHECK (Gender = 'Male' or Gender = 'Female')
) 
INSERT INTO Users(NickName, Birthdate, Gender)
            Values('TestUsr', '04.23.2011', 'Male')
  
CREATE TABLE Studio
(
	  StudioID int PRIMARY KEY IDENTITY,
	  StudioName varchar (50) NOT NULL,
	  StudioPage varchar (50) NOT NULL
)
INSERT INTO Studio(StudioName, StudioPage)
            Values('TestStud', 'http://www.test-studio.jp')

CREATE TABLE Publisher
(
	  PublisherID int PRIMARY KEY IDENTITY,
	  PublisherName varchar (50) NOT NULL,
	  PublisherPage varchar (50) NOT NULL
)
INSERT INTO Publisher(PublisherName, PublisherPage)
            Values('TestPub', 'http://www.test-pub.jp')

CREATE TABLE Genres
(
	  GenreID int PRIMARY KEY IDENTITY,
	  GenreName varchar (50) NOT NULL
)
INSERT INTO Genres(GenreName)
            Values('testomedy')

CREATE TABLE AiredYet
(
      AiredID int PRIMARY KEY IDENTITY,
      AiredName varchar(50) NOT NULL
)
INSERT INTO AiredYet(AiredName)
            Values('Yes - Ongoing')
            
CREATE TABLE Manga
(
	  MangaID int PRIMARY KEY IDENTITY,
	  PublisherID int,
      MangaYear int,
	  MangaName varchar (50) NOT NULL,
      ShortDescription varchar (500) NOT NULL,
      Chapters decimal (4) NOT NULL,
      Thomes decimal (4) NOT NULL,
      AiredID int,
      GenreID int,
      CONSTRAINT FK_MaAired FOREIGN KEY (AiredID) REFERENCES AiredYet(AiredID) ON DELETE CASCADE,
      CONSTRAINT FK_MaGenre FOREIGN KEY (GenreID) REFERENCES Genres(GenreID) ON DELETE CASCADE,
      CONSTRAINT FK_MaPubID FOREIGN KEY (PublisherID) REFERENCES Publisher(PublisherID) ON DELETE CASCADE,
)
INSERT INTO Manga (PublisherID, MangaYear, MangaName, ShortDescription, Chapters, Thomes, AiredID, GenreID)
            Values(1, 2011, 'Tesuto', 'he adventures of Tesuto', 12, 2, 1, 1)

CREATE TABLE SerialType
(
      SerialTypeID int PRIMARY KEY IDENTITY,
      SerialName varchar(50) NOT NULL
)
INSERT INTO SerialType(SerialName)
            Values('OVA')
            
CREATE TABLE Anime
(
      TitleID int PRIMARY KEY IDENTITY,
	  MangaID int,
	  StudioID int,
      AniYear int,
      TitleName varchar (50) NOT NULL,
      SerialTypeID int,
      GenreID int,
      ShortDescription varchar (500) NOT NULL,
      Episodes decimal (4) NOT NULL,
      AiredID int,
      CONSTRAINT FK_AniAired FOREIGN KEY (AiredID) REFERENCES AiredYet(AiredID) ON DELETE CASCADE,
      CONSTRAINT FK_AniSType FOREIGN KEY (SerialTypeID) REFERENCES SerialType(SerialTypeID) ON DELETE CASCADE,
      CONSTRAINT FK_AnGenre FOREIGN KEY (GenreID) REFERENCES Genres(GenreID) ON DELETE CASCADE,
      CONSTRAINT FK_AnStudID FOREIGN KEY (StudioID) REFERENCES Studio(StudioID) ON DELETE CASCADE,
	  CONSTRAINT FK_AnMangaID FOREIGN KEY (MangaID) REFERENCES Manga(MangaID) ON DELETE CASCADE,
      CONSTRAINT CK_Eps CHECK (Episodes >= 0)
) 
INSERT INTO Anime(MangaID, StudioID, AniYear, TitleName, SerialTypeID, GenreID, ShortDescription, Episodes, AiredID)
            Values(1, 1, 2011, 'To aru majitsu no Tesuto', 1,1,'The adventures of Mahou-tesuto!', 3, 1 )

CREATE TABLE UserStatus
(
	  StatusID int PRIMARY KEY IDENTITY,
	  StatusName varchar (50) NOT NULL
)
INSERT INTO UserStatus(StatusName)
            Values('Watching')
            
CREATE TABLE AnimeList
(
	  ListID int PRIMARY KEY IDENTITY,
	  UserID int,
	  TitleID int,
	  Score int,
	  StatusID int,
	  EpsWatched int,
	  CONSTRAINT FL_AlStatus FOREIGN KEY (StatusID) REFERENCES UserStatus(StatusID) ON DELETE CASCADE,
      CONSTRAINT FK_ALUserID FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE,
      CONSTRAINT FK_ALTitleID FOREIGN KEY (TitleID) REFERENCES Anime(TitleID) ON DELETE CASCADE
) 
INSERT INTO AnimeList(UserID, TitleID, Score, StatusID, EpsWatched)
            Values(1, 1, 9, 1, 2)

CREATE TABLE FavAnime
(
	  FavAnimeID int PRIMARY KEY IDENTITY,
	  TitleID int,
	  UserID int, 
	  CONSTRAINT FK_FATitleID FOREIGN KEY (TitleID) REFERENCES Anime(TitleID) ON DELETE CASCADE,
	  CONSTRAINT FK_FAUserID FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
)
INSERT INTO FavAnime(TitleID, UserID)
            Values(1, 1)

CREATE TABLE Staff
(
	  StaffID int PRIMARY KEY IDENTITY,
	  TitleID int,
	  MangaID int,
	  StaffName varchar(50) NOT NULL,
	  Occupation varchar(50) NOT NULL,
	  PersonalPage varchar(50) NOT NULL,
	  CONSTRAINT FK_StTitleID FOREIGN KEY (TitleID) REFERENCES Anime(TitleID) ON DELETE CASCADE,	  
	  CONSTRAINT FK_StMangaID FOREIGN KEY (MangaID) REFERENCES Manga(MangaID) ON DELETE CASCADE
)
INSERT INTO Staff(TitleID, MangaID, StaffName, Occupation, PersonalPage)
            Values(1, 1, 'Tesuto Tesutonaki', 'Voice Tester', 'http://tesuto.ameblo.jp')

CREATE TABLE MangaList
(
	  MangaListID int PRIMARY KEY IDENTITY,
	  UserID int,
	  MangaID int,
	  Score int,
	  ChaptersRead int,
	  ThomesRead int,
	  StatusID int,
	  CONSTRAINT FL_MalStatus FOREIGN KEY (StatusID) REFERENCES UserStatus(StatusID) ON DELETE CASCADE,
      CONSTRAINT FK_MLUserID FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE,
      CONSTRAINT FK_MLMangaID FOREIGN KEY (MangaID) REFERENCES Manga(MangaID) ON DELETE CASCADE
)
INSERT INTO MangaList(UserID, MangaID, Score, ChaptersRead, ThomesRead, StatusID)
            Values(1, 1, 7, 3, 1, 1)

CREATE TABLE FavManga
(
	  FavMangaID int PRIMARY KEY IDENTITY,
	  MangaID int,
	  UserID int, 
	  CONSTRAINT FK_FMMangaID FOREIGN KEY (MangaID) REFERENCES Manga(MangaID) ON DELETE CASCADE,
	  CONSTRAINT FK_FMUserID FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
)
INSERT INTO FavManga(MangaID, UserID)
            Values(1,1)

CREATE TABLE FavStaff
(
	  FavStaffID int PRIMARY KEY IDENTITY,
	  UserID int,
	  StaffID int,
	  CONSTRAINT FK_FSUserID FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE,
	  CONSTRAINT FK_FSStaffID FOREIGN KEY (StaffID) REFERENCES Staff(StaffID) ON DELETE CASCADE
)
INSERT INTO FavStaff(UserID, StaffID)
            Values(1,1)
            
CREATE TABLE UserLog
(
      UserLogID int PRIMARY KEY IDENTITY,
      UserID int,
      CONSTRAINT FK_ULogUserID FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE,
)
INSERT INTO UserLog(UserID)
            Values(1)