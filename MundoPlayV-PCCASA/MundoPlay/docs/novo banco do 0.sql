
-- Tabela de login

CREATE TABLE login (
  idlogin int NOT NULL identity,
  nome varchar(100) NULL,
  email varchar(100) NULL,
  usuario varchar(45) NULL,
  senha varchar(100) NULL,
  imgAutor varchar(45) NULL,
  webmaster int DEFAULT '0'
  PRIMARY KEY (idlogin)
); 


-- Tabela de notícias

CREATE TABLE noticias (
  idnoticias int NOT NULL identity PRIMARY KEY,
  tituloNoticia varchar(200)NULL,
  subtitulo varchar(200)NULL,
  texto text NULL,
  dataPost date NULL,
  horaPost time NULL,
  img varchar(45)NULL,
  destaque char(3) DEFAULT 'off',
  imgDestaque varchar(45) NULL,
  relacionado int NULL,
  validar varchar(3) DEFAULT 'off'
) 


-- Tabela associativa notícias e login

CREATE TABLE noticia_login (
  noticia int,
  usuario int
  PRIMARY KEY (noticia, usuario),
  FOREIGN KEY (noticia) REFERENCES noticias(idnoticias) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (usuario) REFERENCES login(idlogin) ON DELETE CASCADE ON UPDATE CASCADE
)


-- Tabela de filmes

CREATE TABLE filmes (
	idfilmes int NOT NULL identity PRIMARY KEY,
	titulo varchar(100) NULL,
	titulo_original varchar(100) NULL,
	elenco text NULL,
	sinopse text NULL,
	duracao int NULL,
	poster varchar(45) NULL,
	trailer varchar(45) NULL,
	validar varchar(3) NULL
)


-- Tabela de series

CREATE TABLE series (
  idseries int NOT NULL identity PRIMARY KEY,
  titulo varchar(100)NULL,
  elenco text null,
  sinopse text null,
  canal int NULL,
  temporadas int NULL,
  duracao int NULL,
  poster varchar(45)NULL,
  trailer varchar(45)NULL,
  validar varchar(3) DEFAULT 'off'
) 



-- Tabela de games

CREATE TABLE games (
  idgames int NOT NULL identity PRIMARY KEY,
  titulo varchar(100)NULL,
  sinopse text NULL,
  poster varchar(45) NULL,
  trailer varchar(45)  NULL,
  validar varchar(3) DEFAULT 'off'
)


-- Tabela consoles

CREATE TABLE consoles (
  idconsoles int NOT NULL identity PRIMARY KEY,
  nomeConsole varchar(45)NULL
) 


-- Tabela de generos

CREATE TABLE generos (
  idgeneros int NOT NULL identity,
  nomegenero varchar(45) NULL
  PRIMARY KEY (idgeneros)
)



-- Tabela de desenvolvedoras e publicadoras

CREATE TABLE desenvolvedoras (
  iddesenvolvedoras int NOT NULL identity PRIMARY KEY,
  nomeDesenvolvedora varchar(100) NULL
)

CREATE TABLE publicadoras (
  idpublicadoras int NOT NULL identity PRIMARY KEY,
  nomePublicadora varchar(100)NULL
)


-- Tabela de emissoras

CREATE TABLE emissoras (
  idemissoras int NOT NULL identity PRIMARY KEY,
  nomeEmissora varchar(45) NULL
) 


-- Tabela de eventos

CREATE TABLE eventos (
  ideventos int NOT NULL identity PRIMARY KEY,
  evento varchar(45)NULL,
  lugar varchar(45) NULL,
  edicao int NULL,
  dataInicio date NULL,
  dataTermino date NULL,
  descricao text,
  img varchar(45) NULL,
  validar varchar(3) DEFAULT 'off'
)



-- Tabela de Diretores

CREATE TABLE diretores (
  iddiretores int NOT NULL identity,
  nomeDiretor varchar(45)NULL,
  sobrenomeDiretor varchar(45)NULL
  PRIMARY KEY (iddiretores)
)


-- Tabela de lançamentos

CREATE TABLE lancamentos (
  idlancamentos int NOT NULL identity PRIMARY KEY,
  dataLancamento date DEFAULT NULL
)


-- Tabela associativa filmes e lançamentos

CREATE TABLE filme_lancamento (
    filme int,
    lancamento int,
	PRIMARY KEY (filme, lancamento),
	FOREIGN KEY (filme) REFERENCES filmes(idfilmes) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (lancamento) REFERENCES lancamentos(idlancamentos) ON DELETE CASCADE ON UPDATE CASCADE
);


-- Tabela associativa séries e lançamentos

CREATE TABLE serie_lancamento (
    serie int,
    lancamento int,
	PRIMARY KEY (serie, lancamento),
	FOREIGN KEY (serie) REFERENCES series(idseries) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (lancamento) REFERENCES lancamentos(idlancamentos) ON DELETE CASCADE ON UPDATE CASCADE
);


-- Tabela associativa games e lançamentos

CREATE TABLE game_lancamento (
    game int,
    lancamento int,
	PRIMARY KEY (game, lancamento),
	FOREIGN KEY (game) REFERENCES games(idgames) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (lancamento) REFERENCES lancamentos(idlancamentos) ON DELETE CASCADE ON UPDATE CASCADE
);


-- Tabela associativa games e consoles

CREATE TABLE game_console (
  game int,
  console int
  PRIMARY KEY (game, console),
  FOREIGN KEY (game) REFERENCES games(idgames) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (console) REFERENCES consoles(idconsoles) ON DELETE CASCADE ON UPDATE CASCADE
)


-- Tabela associativa games e diretores

CREATE TABLE game_diretor (
  game int,
  diretor int
  PRIMARY KEY (game, diretor),
  FOREIGN KEY (game) REFERENCES games(idgames) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (diretor) REFERENCES diretores(iddiretores) ON DELETE CASCADE ON UPDATE CASCADE
)


-- Tabela associativa games e generos

CREATE TABLE game_genero (
  game int,
  genero int
  PRIMARY KEY (game, genero),
  FOREIGN KEY (game) REFERENCES games(idgames) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (genero) REFERENCES generos(idgeneros) ON DELETE CASCADE ON UPDATE CASCADE
)


-- Tabela associativa games e desenvolvedoras

CREATE TABLE game_desenvolvedora (
  game int,
  desenvolvedora int
  PRIMARY KEY (game, desenvolvedora),
  FOREIGN KEY (game) REFERENCES games(idgames) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (desenvolvedora) REFERENCES desenvolvedoras(iddesenvolvedoras) ON DELETE CASCADE ON UPDATE CASCADE
) 


-- Tabela associativa games e desenvolvedoras

CREATE TABLE game_publicadora (
  game int,
  publicadora int
  PRIMARY KEY (game, publicadora),
  FOREIGN KEY (game) REFERENCES games(idgames) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (publicadora) REFERENCES publicadoras(idpublicadoras) ON DELETE CASCADE ON UPDATE CASCADE
) 



-- Tabela associativa filmes e generos

CREATE TABLE filme_genero (
    filme int,
    genero int,
	PRIMARY KEY (filme, genero),
	FOREIGN KEY (filme) REFERENCES filmes(idfilmes) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (genero) REFERENCES generos(idgeneros) ON DELETE CASCADE ON UPDATE CASCADE
); 


-- Tabela associativa séries e generos

CREATE TABLE serie_genero (
    serie int,
    genero int,
	PRIMARY KEY (serie, genero),
	FOREIGN KEY (serie) REFERENCES series(idseries) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (genero) REFERENCES generos(idgeneros) ON DELETE CASCADE ON UPDATE CASCADE
); 



-- Tabela associativa filmes e diretores

CREATE TABLE filme_diretor (
    filme int,
    diretor int,
	PRIMARY KEY (filme, diretor),
	FOREIGN KEY (filme) REFERENCES filmes(idfilmes) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (diretor) REFERENCES diretores(iddiretores) ON DELETE CASCADE ON UPDATE CASCADE
); 


-- Tabela de midias

CREATE TABLE midias (
  idmidias int NOT NULL identity,
  nomeMidia varchar(45) NULL,
  diretorio varchar(45)NULL
  PRIMARY KEY (idmidias),
)

-- Tabela associativa filmes e midias

CREATE TABLE filme_midia (
  filme int,
  midia int
  PRIMARY KEY (filme, midia),
  FOREIGN KEY (filme) REFERENCES filmes(idfilmes) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (midia) REFERENCES midias(idmidias) ON DELETE CASCADE ON UPDATE CASCADE
)


-- Tabela associativa filmes e midias

CREATE TABLE game_midia (
  game int,
  midia int
  PRIMARY KEY (game, midia),
  FOREIGN KEY (game) REFERENCES games(idgames) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (midia) REFERENCES midias(idmidias) ON DELETE CASCADE ON UPDATE CASCADE
)


-- Tabela associativa séries e midias

CREATE TABLE serie_midia (
  serie int,
  midia int
  PRIMARY KEY (serie, midia),
  FOREIGN KEY (serie) REFERENCES series(idseries) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (midia) REFERENCES midias(idmidias) ON DELETE CASCADE ON UPDATE CASCADE
)


-- Tabela de paises

CREATE TABLE paises (
  idpaises int NOT NULL identity,
  nomePais varchar(45)NULL
  PRIMARY KEY (idpaises),
)



-- Tabela de tags

CREATE TABLE tags (
  idtags int NOT NULL identity,
  tag varchar(45)NULL
  PRIMARY KEY (idtags),
)


-- Tabela associativa tags e notícias

CREATE TABLE noticia_tag (
  noticia int,
  tag int
  PRIMARY KEY (noticia, tag),
  FOREIGN KEY (noticia) REFERENCES noticias(idnoticias) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (tag) REFERENCES tags(idtags) ON DELETE CASCADE ON UPDATE CASCADE
)



-- Tabela associativa filmes e paises

CREATE TABLE filme_pais (
  filme int,
  pais int
  PRIMARY KEY (filme, pais),
  FOREIGN KEY (filme) REFERENCES filmes(idfilmes) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (pais) REFERENCES paises(idpaises) ON DELETE CASCADE ON UPDATE CASCADE
)


-- Tabela associativa séries e paises

CREATE TABLE serie_pais (
  serie int,
  pais int
  PRIMARY KEY (serie, pais),
  FOREIGN KEY (serie) REFERENCES series(idseries) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (pais) REFERENCES paises(idpaises) ON DELETE CASCADE ON UPDATE CASCADE
)


-- Tabela associativa séries e paises

CREATE TABLE game_pais (
  game int,
  pais int
  PRIMARY KEY (game, pais),
  FOREIGN KEY (game) REFERENCES games(idgames) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (pais) REFERENCES paises(idpaises) ON DELETE CASCADE ON UPDATE CASCADE
)


-- Tabela associativa eventos e notícias

CREATE TABLE noticia_evento (
  noticia int,
  evento int
  PRIMARY KEY (noticia, evento),
  FOREIGN KEY (noticia) REFERENCES noticias(idnoticias) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (evento) REFERENCES eventos(ideventos) ON DELETE CASCADE ON UPDATE CASCADE
)



-- INSERTS

INSERT INTO diretores (nomeDiretor, sobrenomeDiretor) VALUES
('Steven', 'Spilberg'),
('Jon', 'Turteltaub'),
('David', 'Leitch');

INSERT INTO generos (nomegenero) VALUES
('Terror'),
('Ação'),
('Aventura'),
('Drama'),
('Suspense'),
('FPS'),
('RPG'),
('MMORPG'),
('Infantil'),
('Plataforma 2D'),
('Plataforma 3D'),
('Documentário'),
('Comédia');

INSERT INTO login (nome, email, usuario, senha, imgAutor, webmaster) VALUES
('Thiago Silva', 'stornwild@yahoo.com', 'thiago', '123', 'thiago.jpg', 1),
('Maria Silva', 'stornwild@yahoo.com', 'maria', '123', 'maria.jpg', 0);

INSERT INTO midias (nomeMidia, diretorio) VALUES
('Cinema', 'cinema'),
('SÃ©ries', 'series'),
('Games', 'games');

INSERT INTO paises (nomePais) VALUES
('Estados Unidos'),
('Brasil'),
('FranÃ§a'),
('Reino Unido');

INSERT INTO consoles (nomeConsole) VALUES
('PlayStation 4'),
('Xbox One'),
('Switch'),
('PC'),
('3DS'),
('WiiU'),
('PlayStation 3'),
('Xbox 360'),
('Wii');

INSERT INTO desenvolvedoras (nomeDesenvolvedora) VALUES
('Ubisoft'),
('Capcom'),
('Naughty Dog'),
('From Software');

INSERT INTO emissoras (nomeEmissora) VALUES
('HBO'),
('CBS'),
('Netflix'),
('Hulu'),
('CW'),
('ABC'),
('Amazon Prime');

INSERT INTO publicadoras (nomePublicadora) VALUES
('Electronic Arts'),
('Nintendo'),
('Warner Bros. Interactive Entertainment');

INSERT INTO tags (tag) VALUES
('Cinema'),
('Série'),
('Games'),
('Bilheteria'),
('Lañçamentos');