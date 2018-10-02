
/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `cinema_v7`
--

CREATE DATABASE mundoPlay


-- --------------------------------------------------------

--
-- Estrutura para tabela `consoles`
--

CREATE TABLE consoles (
  [idconsoles] int NOT NULL,
  [nomeConsole] varchar(45) DEFAULT NULL
)  ;

--
-- Fazendo dump de dados para tabela `consoles`
--

INSERT INTO consoles ([idconsoles], [nomeConsole]) VALUES
(1, 'PlayStation 4'),
(2, 'Xbox One'),
(3, 'Switch'),
(4, 'PC'),
(5, '3DS'),
(6, 'WiiU'),
(7, 'PlayStation 3'),
(8, 'Xbox 360'),
(9, 'Wii');

-- --------------------------------------------------------

--
-- Estrutura para tabela `desenvolvedoras`
--

CREATE TABLE desenvolvedoras (
  [iddesenvolvedoras] int NOT NULL,
  [nomeDesenvolvedora] varchar(100) DEFAULT NULL
)  ;

--
-- Fazendo dump de dados para tabela `desenvolvedoras`
--

INSERT INTO desenvolvedoras ([iddesenvolvedoras], [nomeDesenvolvedora]) VALUES
(1, 'Ubisoft'),
(2, 'Capcom'),
(3, 'Naughty Dog'),
(4, 'From Software');

-- --------------------------------------------------------

--
-- Estrutura para tabela `desenvolvedoras_has_games`
--

CREATE TABLE desenvolvedoras_has_games (
  [desenvolvedoras_iddesenvolvedoras] int NOT NULL,
  [games_idgames] int NOT NULL
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `diretores`
--

CREATE TABLE diretores (
  [iddiretores] int NOT NULL,
  [nomeDiretor] varchar(45) DEFAULT NULL,
  [sobrenomeDiretor] varchar(45) DEFAULT NULL
)  ;

--
-- Fazendo dump de dados para tabela `diretores`
--

INSERT INTO diretores ([iddiretores], [nomeDiretor], [sobrenomeDiretor]) VALUES
(1, 'Steven', 'Spilberg'),
(2, 'Jon', 'Turteltaub'),
(3, 'David', 'Leitch');

-- --------------------------------------------------------

--
-- Estrutura para tabela `emissoras`
--

CREATE TABLE emissoras (
  [idemissoras] int NOT NULL,
  [nomeEmissora] varchar(45) DEFAULT NULL
)  ;

--
-- Fazendo dump de dados para tabela `emissoras`
--

INSERT INTO emissoras ([idemissoras], [nomeEmissora]) VALUES
(1, 'HBO'),
(2, 'CBS'),
(3, 'Netflix'),
(4, 'Hulu'),
(5, 'CW'),
(6, 'ABC'),
(7, 'Amazon Prime');

-- --------------------------------------------------------

--
-- Estrutura para tabela `eventos`
--

CREATE TABLE eventos (
  [ideventos] int NOT NULL,
  [evento] varchar(45) DEFAULT NULL,
  [local] varchar(45) DEFAULT NULL,
  [edicao] int DEFAULT NULL,
  [dataInicio] date DEFAULT NULL,
  [dataTermino] date DEFAULT NULL,
  [descricao] varchar(max),
  [img] varchar(45) DEFAULT NULL,
  [validar] varchar(3) DEFAULT 'off'
)  ;

--
-- Fazendo dump de dados para tabela `eventos`
--

INSERT INTO eventos ([ideventos], [evento], [local], [edicao], [dataInicio], [dataTermino], [descricao], [img], [validar]) VALUES
(1, 'BGS', 'Expo Center Norte', 8, '2018-10-10', '2020-10-20', 'asasADad', 'adssadads', 'off');

-- --------------------------------------------------------

--
-- Estrutura para tabela `eventos_has_noticias`
--

CREATE TABLE eventos_has_noticias (
  [eventos_ideventos] int NOT NULL,
  [noticias_idnoticias] int NOT NULL
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `filmes`
--

CREATE TABLE filmes (
  [idfilmes] int NOT NULL,
  [titulo] varchar(100) DEFAULT NULL,
  [titulo_original] varchar(100) DEFAULT NULL,
  [elenco] varchar(max),
  [sinopse] varchar(max),
  [duracao] int DEFAULT NULL,
  [poster] varchar(45) DEFAULT NULL,
  [trailer] varchar(45) DEFAULT NULL,
  [validar] varchar(3) DEFAULT 'off'
)  ;

--
-- Fazendo dump de dados para tabela `filmes`
--

INSERT INTO filmes ([idfilmes], [titulo], [titulo_original], [elenco], [sinopse], [duracao], [poster], [trailer], [validar]) VALUES
(1, 'Deadpool 2', 'Deadpool 2', ' Ryan Reynolds, Josh Brolin, Morena Baccarin', 'Quando o super soldado Cable (Josh Brolin) chega em uma missÃ£o para assassinar o jovem mutante Russel (Julian Dennison), o mercenÃ¡rio Deadpool (Ryan Reynolds) precisa aprender o que Ã© ser herÃ³i de verdade para salvÃ¡-lo. Para isso, ele recruta seu velho amigo Colossus e forma o novo grupo X-Force, sempre com o apoio do fiel escudeiro Dopinder (Karan Soni).', 120, 'deadpool2.jpg', 'sdsdsds', 'off'),
(2, 'dfgdfg', 'dfgdf', '<p>fgvhbfg</p>rn', '<p>fghfgt</p>rn', 123, '5ba96f5a6a6fa.jpg', '', 'off');

-- --------------------------------------------------------

--
-- Estrutura para tabela `filmes_has_diretores`
--

CREATE TABLE filmes_has_diretores (
  [filmes_idfilmes] int NOT NULL,
  [diretores_iddiretores] int NOT NULL
)  ;

--
-- Fazendo dump de dados para tabela `filmes_has_diretores`
--

INSERT INTO filmes_has_diretores ([filmes_idfilmes], [diretores_iddiretores]) VALUES
(2, 1),
(1, 3);

-- --------------------------------------------------------

--
-- Estrutura para tabela `filmes_has_generos`
--

CREATE TABLE filmes_has_generos (
  [filmes_idfilmes] int NOT NULL,
  [generos_idgeneros] int NOT NULL
)  ;

--
-- Fazendo dump de dados para tabela `filmes_has_generos`
--

INSERT INTO filmes_has_generos ([filmes_idfilmes], [generos_idgeneros]) VALUES
(2, 1),
(1, 2),
(1, 3),
(1, 12);

-- --------------------------------------------------------

--
-- Estrutura para tabela `games`
--

CREATE TABLE games (
  [idgames] int NOT NULL,
  [titulo] varchar(100) DEFAULT NULL,
  [sinopse] varchar(max),
  [poster] varchar(45) DEFAULT NULL,
  [trailer] varchar(45) DEFAULT NULL,
  [validar] varchar(3) DEFAULT 'off'
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `games_has_consoles`
--

CREATE TABLE games_has_consoles (
  [games_idgames] int NOT NULL,
  [consoles_idconsoles] int NOT NULL
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `games_has_diretores`
--

CREATE TABLE games_has_diretores (
  [games_idgames] int NOT NULL,
  [diretores_iddiretores] int NOT NULL
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `games_has_generos`
--

CREATE TABLE games_has_generos (
  [games_idgames] int NOT NULL,
  [generos_idgeneros] int NOT NULL
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `generos`
--

CREATE TABLE generos (
  [idgeneros] int NOT NULL,
  [nomegenero] varchar(45) DEFAULT NULL
)  ;

--
-- Fazendo dump de dados para tabela `generos`
--

INSERT INTO generos ([idgeneros], [nomegenero]) VALUES
(1, 'Terror'),
(2, 'AÃ§Ã£o'),
(3, 'Aventura'),
(4, 'Drama'),
(5, 'Suspense'),
(6, 'FPS'),
(7, 'RPG'),
(8, 'MMORPG'),
(9, 'Infantil'),
(10, 'Plataforma 2D'),
(11, 'Plataforma 3D'),
(12, 'DocumentÃ¡rio'),
(13, 'ComÃ©dia');

-- --------------------------------------------------------

--
-- Estrutura para tabela `lancamentos`
--

CREATE TABLE lancamentos (
  [idlancamentos] int NOT NULL,
  [dataLancamento] date DEFAULT NULL
)  ;

--
-- Fazendo dump de dados para tabela `lancamentos`
--

INSERT INTO lancamentos ([idlancamentos], [dataLancamento]) VALUES
(1, '2018-05-17'),
(2, '2010-10-10');

-- --------------------------------------------------------

--
-- Estrutura para tabela `lancamentos_has_filmes`
--

CREATE TABLE lancamentos_has_filmes (
  [lancamentos_idlancamentos] int NOT NULL,
  [filmes_idfilmes] int NOT NULL
)  ;

--
-- Fazendo dump de dados para tabela `lancamentos_has_filmes`
--

INSERT INTO lancamentos_has_filmes ([lancamentos_idlancamentos], [filmes_idfilmes]) VALUES
(1, 1),
(2, 2);

-- --------------------------------------------------------

--
-- Estrutura para tabela `lancamentos_has_games`
--

CREATE TABLE lancamentos_has_games (
  [lancamentos_idlancamentos] int NOT NULL,
  [games_idgames] int NOT NULL
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `login`
--

CREATE TABLE login (
  [idlogin] int NOT NULL,
  [nome] varchar(100) DEFAULT NULL,
  [email] varchar(100) DEFAULT NULL,
  [usuario] varchar(45) DEFAULT NULL,
  [senha] varchar(100) DEFAULT NULL,
  [imgAutor] varchar(45) DEFAULT NULL,
  [webmaster] int DEFAULT '0'
)  ;

--
-- Fazendo dump de dados para tabela `login`
--

INSERT INTO login ([idlogin], [nome], [email], [usuario], [senha], [imgAutor], [webmaster]) VALUES
(1, 'Thiago Silva', 'stornwild@yahoo.com', 'thiago', '$2y$10$LZGGLN.ZoKKVOOdmEYN4V.DrAiJGUVN7.gDKYNDc3HAgVATyKwIFy', 'thiago_silva.jpg', 1),
(2, 'Maria Silva', 'stornwild@yahoo.com', 'maria', '$2y$10$LZGGLN.ZoKKVOOdmEYN4V.DrAiJGUVN7.gDKYNDc3HAgVATyKwIFy', 'maria.jpg', 0);

-- --------------------------------------------------------

--
-- Estrutura para tabela `midias`
--

CREATE TABLE midias (
  [idmidias] int NOT NULL,
  [nomeMidia] varchar(45) DEFAULT NULL,
  [diretorio] varchar(45) DEFAULT NULL
)  ;

--
-- Fazendo dump de dados para tabela `midias`
--

INSERT INTO midias ([idmidias], [nomeMidia], [diretorio]) VALUES
(1, 'Cinema', 'cinema'),
(2, 'SÃ©ries', 'series'),
(3, 'Games', 'games');

-- --------------------------------------------------------

--
-- Estrutura para tabela `midias_has_eventos`
--

CREATE TABLE midias_has_eventos (
  [midias_idmidias] int NOT NULL,
  [eventos_ideventos] int NOT NULL
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `midias_has_filmes`
--

CREATE TABLE midias_has_filmes (
  [midias_idmidias] int NOT NULL,
  [filmes_idfilmes] int NOT NULL
)  ;

--
-- Fazendo dump de dados para tabela `midias_has_filmes`
--

INSERT INTO midias_has_filmes ([midias_idmidias], [filmes_idfilmes]) VALUES
(1, 1),
(1, 2);

-- --------------------------------------------------------

--
-- Estrutura para tabela `midias_has_games`
--

CREATE TABLE midias_has_games (
  [midias_idmidias] int NOT NULL,
  [games_idgames] int NOT NULL
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `midias_has_noticias`
--

CREATE TABLE midias_has_noticias (
  [midias_idmidias] int NOT NULL,
  [noticias_idnoticias] int NOT NULL
)  ;

--
-- Fazendo dump de dados para tabela `midias_has_noticias`
--

INSERT INTO midias_has_noticias ([midias_idmidias], [noticias_idnoticias]) VALUES
(1, 1),
(2, 2);

-- --------------------------------------------------------

--
-- Estrutura para tabela `midias_has_series`
--

CREATE TABLE midias_has_series (
  [midias_idmidias] int NOT NULL,
  [series_idseries] int NOT NULL
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `noticias`
--

CREATE TABLE noticias (
  [idnoticias] int NOT NULL,
  [tituloNoticia] varchar(200) DEFAULT NULL,
  [subtitulo] varchar(200) DEFAULT NULL,
  [texto] varchar(max),
  [dataPost] date DEFAULT NULL,
  [horaPost] time(0) DEFAULT NULL,
  [img] varchar(45) DEFAULT NULL,
  [destaque] char(3) DEFAULT 'off',
  [imgDestaque] varchar(45) DEFAULT NULL,
  [relacionado] int DEFAULT NULL,
  [validar] varchar(3) DEFAULT 'off'
)  ;

--
-- Fazendo dump de dados para tabela `noticias`
--

INSERT INTO noticias ([idnoticias], [tituloNoticia], [subtitulo], [texto], [dataPost], [horaPost], [img], [destaque], [imgDestaque], [relacionado], [validar]) VALUES
(1, 'Superman | Henry Cavill posta vÃ­deo divertido sobre sua saÃ­da', 'Ator entrou na brincadeira', 'Henry Cavill divulgou um vÃ­deo divertido apÃ³s as informaÃ§Ãµes sobre sua saÃ­da do papel de Superman. Na legenda, o ator escreveu "Hoje foi empolgante #superman":', NULL, NULL, '5b99b186d031c.jpg', NULL, NULL, 1, NULL),
(2, 'Insatiable Ã© renovada para a 2Âª temporada na Netflix', 'Debby Ryan estrela a atraÃ§Ã£o', 'Segundo a Variety, a Netflix renovou Insatiable para a segunda temporada. A notÃ­cia surge mesmo apÃ³s as vÃ¡rias crÃ­ticas que a primeira temporada recebeu por promover, segundo os fÃ£s, de gordofobia - leia nossa crÃ­tica do primeiro ano.', NULL, NULL, 'insatiable.jpg', NULL, NULL, 1, NULL);

-- --------------------------------------------------------

--
-- Estrutura para tabela `noticias_has_login`
--

CREATE TABLE noticias_has_login (
  [noticias_idnoticias] int NOT NULL,
  [login_idlogin] int NOT NULL
)  ;

--
-- Fazendo dump de dados para tabela `noticias_has_login`
--

INSERT INTO noticias_has_login ([noticias_idnoticias], [login_idlogin]) VALUES
(1, 1),
(2, 1);

-- --------------------------------------------------------

--
-- Estrutura para tabela `noticias_has_tags`
--

CREATE TABLE noticias_has_tags (
  [noticias_idnoticias] int NOT NULL,
  [tags_idtags] int NOT NULL
)  ;

--
-- Fazendo dump de dados para tabela `noticias_has_tags`
--

INSERT INTO noticias_has_tags ([noticias_idnoticias], [tags_idtags]) VALUES
(1, 1),
(2, 1),
(1, 2),
(1, 3),
(2, 4);

-- --------------------------------------------------------

--
-- Estrutura para tabela `paises`
--

CREATE TABLE paises (
  [idpaises] int NOT NULL,
  [nomePais] varchar(45) DEFAULT NULL
)  ;

--
-- Fazendo dump de dados para tabela `paises`
--

INSERT INTO paises ([idpaises], [nomePais]) VALUES
(1, 'Estados Unidos'),
(2, 'Brasil'),
(3, 'FranÃ§a'),
(4, 'Reino Unido');

-- --------------------------------------------------------

--
-- Estrutura para tabela `paises_has_eventos`
--

CREATE TABLE paises_has_eventos (
  [paises_idpaises] int NOT NULL,
  [eventos_ideventos] int NOT NULL
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `paises_has_filmes`
--

CREATE TABLE paises_has_filmes (
  [paises_idpaises] int NOT NULL,
  [filmes_idfilmes] int NOT NULL
)  ;

--
-- Fazendo dump de dados para tabela `paises_has_filmes`
--

INSERT INTO paises_has_filmes ([paises_idpaises], [filmes_idfilmes]) VALUES
(1, 1),
(1, 2);

-- --------------------------------------------------------

--
-- Estrutura para tabela `paises_has_games`
--

CREATE TABLE paises_has_games (
  [paises_idpaises] int NOT NULL,
  [games_idgames] int NOT NULL
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `paises_has_series`
--

CREATE TABLE paises_has_series (
  [paises_idpaises] int NOT NULL,
  [series_idseries] int NOT NULL
)  ;

--
-- Fazendo dump de dados para tabela `paises_has_series`
--

INSERT INTO paises_has_series ([paises_idpaises], [series_idseries]) VALUES
(1, 1);

-- --------------------------------------------------------

--
-- Estrutura para tabela `publicadoras`
--

CREATE TABLE publicadoras (
  [idpublicadora] int NOT NULL,
  [nomePublicadora] varchar(100) DEFAULT NULL
)  ;

--
-- Fazendo dump de dados para tabela `publicadoras`
--

INSERT INTO publicadoras ([idpublicadora], [nomePublicadora]) VALUES
(1, 'Electronic Arts'),
(2, 'Nintendo'),
(3, 'Warner Bros. Interactive Entertainment');

-- --------------------------------------------------------

--
-- Estrutura para tabela `publicadoras_has_games`
--

CREATE TABLE publicadoras_has_games (
  [publicadoras_idpublicadora] int NOT NULL,
  [games_idgames] int NOT NULL
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `series`
--

CREATE TABLE series (
  [idseries] int NOT NULL,
  [titulo] varchar(100) DEFAULT NULL,
  [elenco] varchar(max),
  [sinopse] varchar(max),
  [canal] int DEFAULT NULL,
  [temporadas] int DEFAULT NULL,
  [duracao] int DEFAULT NULL,
  [poster] varchar(45) DEFAULT NULL,
  [trailer] varchar(45) DEFAULT NULL,
  [validar] varchar(3) DEFAULT 'off'
)  ;

--
-- Fazendo dump de dados para tabela `series`
--

INSERT INTO series ([idseries], [titulo], [elenco], [sinopse], [canal], [temporadas], [duracao], [poster], [trailer], [validar]) VALUES
(1, 'Mr. Mercedes', ' 	Brendan Gleeson, Harry Treadaway, Kelly Lynch', 'A histÃ³ria de um psicopata que comete assassinato em massa ao dirigir sua Mercedes em direÃ§Ã£o a uma multidÃ£o de pessoas. Imediatamente, o policial aposentado Bill Hodges (Brandon Gleeson) faz de sua missÃ£o encontrÃ¡-lo e levÃ¡-lo Ã  justiÃ§a.', 7, 2, 45, 'mercedes.jpg', NULL, NULL);

-- --------------------------------------------------------

--
-- Estrutura para tabela `series_has_generos`
--

CREATE TABLE series_has_generos (
  [series_idseries] int NOT NULL,
  [generos_idgeneros] int NOT NULL
)  ;

--
-- Fazendo dump de dados para tabela `series_has_generos`
--

INSERT INTO series_has_generos ([series_idseries], [generos_idgeneros]) VALUES
(1, 4),
(1, 5);

-- --------------------------------------------------------

--
-- Estrutura para tabela `series_has_lancamentos`
--

CREATE TABLE series_has_lancamentos (
  [series_idseries] int NOT NULL,
  [lancamentos_idlancamentos] int NOT NULL
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tags`
--

CREATE TABLE tags (
  [idtags] int NOT NULL,
  [tag] varchar(20) DEFAULT NULL
)  ;

--
-- Fazendo dump de dados para tabela `tags`
--

INSERT INTO tags ([idtags], [tag]) VALUES
(1, 'Cinema'),
(2, 'SÃ©rie'),
(3, 'Games'),
(4, 'Bilheteria'),
(5, 'LanÃ§amentos');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tendencias`
--

CREATE TABLE tendencias (
  [idtendencias] int NOT NULL,
  [nomeTendencia] varchar(45) DEFAULT NULL
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tendencias_has_midias`
--

CREATE TABLE tendencias_has_midias (
  [tendencias_idtendencias] int NOT NULL,
  [midias_idmidias] int NOT NULL
)  ;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tendencias_has_tags`
--

CREATE TABLE tendencias_has_tags (
  [tendencias_idtendencias] int NOT NULL,
  [tags_idtags] int NOT NULL
)  ;

--
-- Índices de tabelas apagadas
--

--
-- Índices de tabela `consoles`
--
ALTER TABLE [consoles]
  ADD PRIMARY KEY ([idconsoles]);

--
-- Índices de tabela `desenvolvedoras`
--
ALTER TABLE [desenvolvedoras]
  ADD PRIMARY KEY ([iddesenvolvedoras]);

--
-- Índices de tabela `desenvolvedoras_has_games`
--
ALTER TABLE [desenvolvedoras_has_games]
  ADD PRIMARY KEY ([desenvolvedoras_iddesenvolvedoras],[games_idgames]),
  ADD KEY `fk_desenvolvedoras_has_games_games1_idx` ([games_idgames]),
  ADD KEY `fk_desenvolvedoras_has_games_desenvolvedoras1_idx` ([desenvolvedoras_iddesenvolvedoras]);

--
-- Índices de tabela `diretores`
--
ALTER TABLE [diretores]
  ADD PRIMARY KEY ([iddiretores]);

--
-- Índices de tabela `emissoras`
--
ALTER TABLE [emissoras]
  ADD PRIMARY KEY ([idemissoras]);

--
-- Índices de tabela `eventos`
--
ALTER TABLE [eventos]
  ADD PRIMARY KEY ([ideventos]);

--
-- Índices de tabela `eventos_has_noticias`
--
ALTER TABLE [eventos_has_noticias]
  ADD PRIMARY KEY ([eventos_ideventos],[noticias_idnoticias]),
  ADD KEY `fk_eventos_has_noticias_noticias1_idx` ([noticias_idnoticias]),
  ADD KEY `fk_eventos_has_noticias_eventos1_idx` ([eventos_ideventos]);

--
-- Índices de tabela `filmes`
--
ALTER TABLE [filmes]
  ADD PRIMARY KEY ([idfilmes]);

--
-- Índices de tabela `filmes_has_diretores`
--
ALTER TABLE [filmes_has_diretores]
  ADD PRIMARY KEY ([filmes_idfilmes],[diretores_iddiretores]),
  ADD KEY `fk_filmes_has_diretores_diretores1_idx` ([diretores_iddiretores]),
  ADD KEY `fk_filmes_has_diretores_filmes1_idx` ([filmes_idfilmes]);

--
-- Índices de tabela `filmes_has_generos`
--
ALTER TABLE [filmes_has_generos]
  ADD PRIMARY KEY ([filmes_idfilmes],[generos_idgeneros]),
  ADD KEY `fk_filmes_has_generos_generos1_idx` ([generos_idgeneros]),
  ADD KEY `fk_filmes_has_generos_filmes1_idx` ([filmes_idfilmes]);

--
-- Índices de tabela `games`
--
ALTER TABLE [games]
  ADD PRIMARY KEY ([idgames]);

--
-- Índices de tabela `games_has_consoles`
--
ALTER TABLE [games_has_consoles]
  ADD PRIMARY KEY ([games_idgames],[consoles_idconsoles]),
  ADD KEY `fk_games_has_consoles_consoles1_idx` ([consoles_idconsoles]),
  ADD KEY `fk_games_has_consoles_games1_idx` ([games_idgames]);

--
-- Índices de tabela `games_has_diretores`
--
ALTER TABLE [games_has_diretores]
  ADD PRIMARY KEY ([games_idgames],[diretores_iddiretores]),
  ADD KEY `fk_games_has_diretores_diretores1_idx` ([diretores_iddiretores]),
  ADD KEY `fk_games_has_diretores_games1_idx` ([games_idgames]);

--
-- Índices de tabela `games_has_generos`
--
ALTER TABLE [games_has_generos]
  ADD PRIMARY KEY ([games_idgames],[generos_idgeneros]),
  ADD KEY `fk_games_has_generos_generos1_idx` ([generos_idgeneros]),
  ADD KEY `fk_games_has_generos_games1_idx` ([games_idgames]);

--
-- Índices de tabela `generos`
--
ALTER TABLE [generos]
  ADD PRIMARY KEY ([idgeneros]);

--
-- Índices de tabela `lancamentos`
--
ALTER TABLE [lancamentos]
  ADD PRIMARY KEY ([idlancamentos]);

--
-- Índices de tabela `lancamentos_has_filmes`
--
ALTER TABLE [lancamentos_has_filmes]
  ADD PRIMARY KEY ([lancamentos_idlancamentos],[filmes_idfilmes]),
  ADD KEY `fk_lancamentos_has_filmes_filmes1_idx` ([filmes_idfilmes]),
  ADD KEY `fk_lancamentos_has_filmes_lancamentos1_idx` ([lancamentos_idlancamentos]);

--
-- Índices de tabela `lancamentos_has_games`
--
ALTER TABLE [lancamentos_has_games]
  ADD PRIMARY KEY ([lancamentos_idlancamentos],[games_idgames]),
  ADD KEY `fk_lancamentos_has_games_games1_idx` ([games_idgames]),
  ADD KEY `fk_lancamentos_has_games_lancamentos1_idx` ([lancamentos_idlancamentos]);

--
-- Índices de tabela `login`
--
ALTER TABLE [login]
  ADD PRIMARY KEY ([idlogin]);

--
-- Índices de tabela `midias`
--
ALTER TABLE [midias]
  ADD PRIMARY KEY ([idmidias]);

--
-- Índices de tabela `midias_has_eventos`
--
ALTER TABLE [midias_has_eventos]
  ADD PRIMARY KEY ([midias_idmidias],[eventos_ideventos]),
  ADD KEY `fk_midias_has_eventos_eventos1_idx` ([eventos_ideventos]),
  ADD KEY `fk_midias_has_eventos_midias1_idx` ([midias_idmidias]);

--
-- Índices de tabela `midias_has_filmes`
--
ALTER TABLE [midias_has_filmes]
  ADD PRIMARY KEY ([midias_idmidias],[filmes_idfilmes]),
  ADD KEY `fk_midias_has_filmes_filmes1_idx` ([filmes_idfilmes]),
  ADD KEY `fk_midias_has_filmes_midias1_idx` ([midias_idmidias]);

--
-- Índices de tabela `midias_has_games`
--
ALTER TABLE [midias_has_games]
  ADD PRIMARY KEY ([midias_idmidias],[games_idgames]),
  ADD KEY `fk_midias_has_games_games1_idx` ([games_idgames]),
  ADD KEY `fk_midias_has_games_midias1_idx` ([midias_idmidias]);

--
-- Índices de tabela `midias_has_noticias`
--
ALTER TABLE [midias_has_noticias]
  ADD PRIMARY KEY ([midias_idmidias],[noticias_idnoticias]),
  ADD KEY `fk_midias_has_noticias_noticias1_idx` ([noticias_idnoticias]),
  ADD KEY `fk_midias_has_noticias_midias1_idx` ([midias_idmidias]);

--
-- Índices de tabela `midias_has_series`
--
ALTER TABLE [midias_has_series]
  ADD PRIMARY KEY ([midias_idmidias],[series_idseries]),
  ADD KEY `fk_midias_has_series_series1_idx` ([series_idseries]),
  ADD KEY `fk_midias_has_series_midias1_idx` ([midias_idmidias]);

--
-- Índices de tabela `noticias`
--
ALTER TABLE [noticias]
  ADD PRIMARY KEY ([idnoticias]);

--
-- Índices de tabela `noticias_has_login`
--
ALTER TABLE [noticias_has_login]
  ADD PRIMARY KEY ([noticias_idnoticias],[login_idlogin]),
  ADD KEY `fk_noticias_has_login_login1_idx` ([login_idlogin]),
  ADD KEY `fk_noticias_has_login_noticias1_idx` ([noticias_idnoticias]);

--
-- Índices de tabela `noticias_has_tags`
--
ALTER TABLE [noticias_has_tags]
  ADD PRIMARY KEY ([noticias_idnoticias],[tags_idtags]),
  ADD KEY `fk_noticias_has_tags_tags1_idx` ([tags_idtags]),
  ADD KEY `fk_noticias_has_tags_noticias1_idx` ([noticias_idnoticias]);

--
-- Índices de tabela `paises`
--
ALTER TABLE [paises]
  ADD PRIMARY KEY ([idpaises]);

--
-- Índices de tabela `paises_has_eventos`
--
ALTER TABLE [paises_has_eventos]
  ADD PRIMARY KEY ([paises_idpaises],[eventos_ideventos]),
  ADD KEY `fk_paises_has_eventos_eventos1_idx` ([eventos_ideventos]),
  ADD KEY `fk_paises_has_eventos_paises1_idx` ([paises_idpaises]);

--
-- Índices de tabela `paises_has_filmes`
--
ALTER TABLE [paises_has_filmes]
  ADD PRIMARY KEY ([paises_idpaises],[filmes_idfilmes]),
  ADD KEY `fk_paises_has_filmes_filmes1_idx` ([filmes_idfilmes]),
  ADD KEY `fk_paises_has_filmes_paises1_idx` ([paises_idpaises]);

--
-- Índices de tabela `paises_has_games`
--
ALTER TABLE [paises_has_games]
  ADD PRIMARY KEY ([paises_idpaises],[games_idgames]),
  ADD KEY `fk_paises_has_games_games1_idx` ([games_idgames]),
  ADD KEY `fk_paises_has_games_paises1_idx` ([paises_idpaises]);

--
-- Índices de tabela `paises_has_series`
--
ALTER TABLE [paises_has_series]
  ADD PRIMARY KEY ([paises_idpaises],[series_idseries]),
  ADD KEY `fk_paises_has_series_series1_idx` ([series_idseries]),
  ADD KEY `fk_paises_has_series_paises1_idx` ([paises_idpaises]);

--
-- Índices de tabela `publicadoras`
--
ALTER TABLE [publicadoras]
  ADD PRIMARY KEY ([idpublicadora]);

--
-- Índices de tabela `publicadoras_has_games`
--
ALTER TABLE [publicadoras_has_games]
  ADD PRIMARY KEY ([publicadoras_idpublicadora],[games_idgames]),
  ADD KEY `fk_publicadoras_has_games_games1_idx` ([games_idgames]),
  ADD KEY `fk_publicadoras_has_games_publicadoras1_idx` ([publicadoras_idpublicadora]);

--
-- Índices de tabela `series`
--
ALTER TABLE [series]
  ADD PRIMARY KEY ([idseries]),
  ADD KEY `fk_emissora_idx` ([canal]);

--
-- Índices de tabela `series_has_generos`
--
ALTER TABLE [series_has_generos]
  ADD PRIMARY KEY ([series_idseries],[generos_idgeneros]),
  ADD KEY `fk_series_has_generos_generos1_idx` ([generos_idgeneros]),
  ADD KEY `fk_series_has_generos_series1_idx` ([series_idseries]);

--
-- Índices de tabela `series_has_lancamentos`
--
ALTER TABLE [series_has_lancamentos]
  ADD PRIMARY KEY ([series_idseries],[lancamentos_idlancamentos]),
  ADD KEY `fk_series_has_lancamentos_lancamentos1_idx` ([lancamentos_idlancamentos]),
  ADD KEY `fk_series_has_lancamentos_series1_idx` ([series_idseries]);

--
-- Índices de tabela `tags`
--
ALTER TABLE [tags]
  ADD PRIMARY KEY ([idtags]);

--
-- Índices de tabela `tendencias`
--
ALTER TABLE [tendencias]
  ADD PRIMARY KEY ([idtendencias]);

--
-- Índices de tabela `tendencias_has_midias`
--
ALTER TABLE [tendencias_has_midias]
  ADD PRIMARY KEY ([tendencias_idtendencias],[midias_idmidias]),
  ADD KEY `fk_tendencias_has_midias_midias1_idx` ([midias_idmidias]),
  ADD KEY `fk_tendencias_has_midias_tendencias1_idx` ([tendencias_idtendencias]);

--
-- Índices de tabela `tendencias_has_tags`
--
ALTER TABLE [tendencias_has_tags]
  ADD PRIMARY KEY ([tendencias_idtendencias],[tags_idtags]),
  ADD KEY `fk_tendencias_has_tags_tags1_idx` ([tags_idtags]),
  ADD KEY `fk_tendencias_has_tags_tendencias1_idx` ([tendencias_idtendencias]);

--
-- AUTO_INCREMENT de tabelas apagadas
--

--
-- AUTO_INCREMENT de tabela `consoles`
--
ALTER TABLE [consoles]
  MODIFY [idconsoles] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT de tabela `desenvolvedoras`
--
ALTER TABLE [desenvolvedoras]
  MODIFY [iddesenvolvedoras] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de tabela `diretores`
--
ALTER TABLE [diretores]
  MODIFY [iddiretores] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de tabela `emissoras`
--
ALTER TABLE [emissoras]
  MODIFY [idemissoras] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT de tabela `eventos`
--
ALTER TABLE [eventos]
  MODIFY [ideventos] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de tabela `filmes`
--
ALTER TABLE [filmes]
  MODIFY [idfilmes] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de tabela `games`
--
ALTER TABLE [games]
  MODIFY [idgames] cast(11 as int) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de tabela `generos`
--
ALTER TABLE [generos]
  MODIFY [idgeneros] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT de tabela `lancamentos`
--
ALTER TABLE [lancamentos]
  MODIFY [idlancamentos] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de tabela `login`
--
ALTER TABLE [login]
  MODIFY [idlogin] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de tabela `midias`
--
ALTER TABLE [midias]
  MODIFY [idmidias] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de tabela `noticias`
--
ALTER TABLE [noticias]
  MODIFY [idnoticias] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de tabela `paises`
--
ALTER TABLE [paises]
  MODIFY [idpaises] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de tabela `publicadoras`
--
ALTER TABLE [publicadoras]
  MODIFY [idpublicadora] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de tabela `series`
--
ALTER TABLE [series]
  MODIFY [idseries] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de tabela `tags`
--
ALTER TABLE [tags]
  MODIFY [idtags] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de tabela `tendencias`
--
ALTER TABLE [tendencias]
  MODIFY [idtendencias] cast(11 as int) NOT NULL AUTO_INCREMENT;
--
-- Restrições para dumps de tabelas
--

--
-- Restrições para tabelas `desenvolvedoras_has_games`
--
ALTER TABLE [desenvolvedoras_has_games]
  ADD CONSTRAINT [fk_desenvolvedoras_has_games_desenvolvedoras1] FOREIGN KEY ([desenvolvedoras_iddesenvolvedoras]) REFERENCES desenvolvedoras ([iddesenvolvedoras]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_desenvolvedoras_has_games_games1] FOREIGN KEY ([games_idgames]) REFERENCES `games` ([idgames]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `eventos_has_noticias`
--
ALTER TABLE [eventos_has_noticias]
  ADD CONSTRAINT [fk_eventos_has_noticias_eventos1] FOREIGN KEY ([eventos_ideventos]) REFERENCES eventos ([ideventos]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_eventos_has_noticias_noticias1] FOREIGN KEY ([noticias_idnoticias]) REFERENCES `noticias` ([idnoticias]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `filmes_has_diretores`
--
ALTER TABLE [filmes_has_diretores]
  ADD CONSTRAINT [fk_filmes_has_diretores_diretores1] FOREIGN KEY ([diretores_iddiretores]) REFERENCES diretores ([iddiretores]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_filmes_has_diretores_filmes1] FOREIGN KEY ([filmes_idfilmes]) REFERENCES `filmes` ([idfilmes]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `filmes_has_generos`
--
ALTER TABLE [filmes_has_generos]
  ADD CONSTRAINT [fk_filmes_has_generos_filmes1] FOREIGN KEY ([filmes_idfilmes]) REFERENCES filmes ([idfilmes]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_filmes_has_generos_generos1] FOREIGN KEY ([generos_idgeneros]) REFERENCES `generos` ([idgeneros]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `games_has_consoles`
--
ALTER TABLE [games_has_consoles]
  ADD CONSTRAINT [fk_games_has_consoles_consoles1] FOREIGN KEY ([consoles_idconsoles]) REFERENCES consoles ([idconsoles]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_games_has_consoles_games1] FOREIGN KEY ([games_idgames]) REFERENCES `games` ([idgames]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `games_has_diretores`
--
ALTER TABLE [games_has_diretores]
  ADD CONSTRAINT [fk_games_has_diretores_diretores1] FOREIGN KEY ([diretores_iddiretores]) REFERENCES diretores ([iddiretores]) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT [fk_games_has_diretores_games1] FOREIGN KEY ([games_idgames]) REFERENCES `games` ([idgames]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `games_has_generos`
--
ALTER TABLE [games_has_generos]
  ADD CONSTRAINT [fk_games_has_generos_games1] FOREIGN KEY ([games_idgames]) REFERENCES games ([idgames]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_games_has_generos_generos1] FOREIGN KEY ([generos_idgeneros]) REFERENCES `generos` ([idgeneros]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `lancamentos_has_filmes`
--
ALTER TABLE [lancamentos_has_filmes]
  ADD CONSTRAINT [fk_lancamentos_has_filmes_filmes1] FOREIGN KEY ([filmes_idfilmes]) REFERENCES filmes ([idfilmes]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_lancamentos_has_filmes_lancamentos1] FOREIGN KEY ([lancamentos_idlancamentos]) REFERENCES `lancamentos` ([idlancamentos]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `lancamentos_has_games`
--
ALTER TABLE [lancamentos_has_games]
  ADD CONSTRAINT [fk_lancamentos_has_games_games1] FOREIGN KEY ([games_idgames]) REFERENCES games ([idgames]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_lancamentos_has_games_lancamentos1] FOREIGN KEY ([lancamentos_idlancamentos]) REFERENCES `lancamentos` ([idlancamentos]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `midias_has_eventos`
--
ALTER TABLE [midias_has_eventos]
  ADD CONSTRAINT [fk_midias_has_eventos_eventos1] FOREIGN KEY ([eventos_ideventos]) REFERENCES eventos ([ideventos]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_midias_has_eventos_midias1] FOREIGN KEY ([midias_idmidias]) REFERENCES `midias` ([idmidias]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `midias_has_filmes`
--
ALTER TABLE [midias_has_filmes]
  ADD CONSTRAINT [fk_midias_has_filmes_filmes1] FOREIGN KEY ([filmes_idfilmes]) REFERENCES filmes ([idfilmes]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_midias_has_filmes_midias1] FOREIGN KEY ([midias_idmidias]) REFERENCES `midias` ([idmidias]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `midias_has_games`
--
ALTER TABLE [midias_has_games]
  ADD CONSTRAINT [fk_midias_has_games_games1] FOREIGN KEY ([games_idgames]) REFERENCES games ([idgames]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_midias_has_games_midias1] FOREIGN KEY ([midias_idmidias]) REFERENCES `midias` ([idmidias]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `midias_has_noticias`
--
ALTER TABLE [midias_has_noticias]
  ADD CONSTRAINT [fk_midias_has_noticias_midias1] FOREIGN KEY ([midias_idmidias]) REFERENCES midias ([idmidias]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_midias_has_noticias_noticias1] FOREIGN KEY ([noticias_idnoticias]) REFERENCES `noticias` ([idnoticias]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `midias_has_series`
--
ALTER TABLE [midias_has_series]
  ADD CONSTRAINT [fk_midias_has_series_midias1] FOREIGN KEY ([midias_idmidias]) REFERENCES midias ([idmidias]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_midias_has_series_series1] FOREIGN KEY ([series_idseries]) REFERENCES `series` ([idseries]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `noticias_has_login`
--
ALTER TABLE [noticias_has_login]
  ADD CONSTRAINT [fk_noticias_has_login_login1] FOREIGN KEY ([login_idlogin]) REFERENCES login ([idlogin]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_noticias_has_login_noticias1] FOREIGN KEY ([noticias_idnoticias]) REFERENCES `noticias` ([idnoticias]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `noticias_has_tags`
--
ALTER TABLE [noticias_has_tags]
  ADD CONSTRAINT [fk_noticias_has_tags_noticias1] FOREIGN KEY ([noticias_idnoticias]) REFERENCES noticias ([idnoticias]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_noticias_has_tags_tags1] FOREIGN KEY ([tags_idtags]) REFERENCES `tags` ([idtags]) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Restrições para tabelas `paises_has_eventos`
--
ALTER TABLE [paises_has_eventos]
  ADD CONSTRAINT [fk_paises_has_eventos_eventos1] FOREIGN KEY ([eventos_ideventos]) REFERENCES eventos ([ideventos]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_paises_has_eventos_paises1] FOREIGN KEY ([paises_idpaises]) REFERENCES `paises` ([idpaises]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `paises_has_filmes`
--
ALTER TABLE [paises_has_filmes]
  ADD CONSTRAINT [fk_paises_has_filmes_filmes1] FOREIGN KEY ([filmes_idfilmes]) REFERENCES filmes ([idfilmes]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_paises_has_filmes_paises1] FOREIGN KEY ([paises_idpaises]) REFERENCES `paises` ([idpaises]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `paises_has_games`
--
ALTER TABLE [paises_has_games]
  ADD CONSTRAINT [fk_paises_has_games_games1] FOREIGN KEY ([games_idgames]) REFERENCES games ([idgames]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_paises_has_games_paises1] FOREIGN KEY ([paises_idpaises]) REFERENCES `paises` ([idpaises]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `paises_has_series`
--
ALTER TABLE [paises_has_series]
  ADD CONSTRAINT [fk_paises_has_series_paises1] FOREIGN KEY ([paises_idpaises]) REFERENCES paises ([idpaises]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_paises_has_series_series1] FOREIGN KEY ([series_idseries]) REFERENCES `series` ([idseries]) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Restrições para tabelas `publicadoras_has_games`
--
ALTER TABLE [publicadoras_has_games]
  ADD CONSTRAINT [fk_publicadoras_has_games_games1] FOREIGN KEY ([games_idgames]) REFERENCES games ([idgames]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_publicadoras_has_games_publicadoras1] FOREIGN KEY ([publicadoras_idpublicadora]) REFERENCES `publicadoras` ([idpublicadora]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `series`
--
ALTER TABLE [series]
  ADD CONSTRAINT [fk_emissora] FOREIGN KEY ([canal]) REFERENCES emissoras ([idemissoras]) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Restrições para tabelas `series_has_generos`
--
ALTER TABLE [series_has_generos]
  ADD CONSTRAINT [fk_series_has_generos_generos1] FOREIGN KEY ([generos_idgeneros]) REFERENCES generos ([idgeneros]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_series_has_generos_series1] FOREIGN KEY ([series_idseries]) REFERENCES `series` ([idseries]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `series_has_lancamentos`
--
ALTER TABLE [series_has_lancamentos]
  ADD CONSTRAINT [fk_series_has_lancamentos_lancamentos1] FOREIGN KEY ([lancamentos_idlancamentos]) REFERENCES lancamentos ([idlancamentos]) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT [fk_series_has_lancamentos_series1] FOREIGN KEY ([series_idseries]) REFERENCES `series` ([idseries]) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Restrições para tabelas `tendencias_has_midias`
--
ALTER TABLE [tendencias_has_midias]
  ADD CONSTRAINT [fk_tendencias_has_midias_midias1] FOREIGN KEY ([midias_idmidias]) REFERENCES midias ([idmidias]) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT [fk_tendencias_has_midias_tendencias1] FOREIGN KEY ([tendencias_idtendencias]) REFERENCES `tendencias` ([idtendencias]) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Restrições para tabelas `tendencias_has_tags`
--
ALTER TABLE [tendencias_has_tags]
  ADD CONSTRAINT [fk_tendencias_has_tags_tags1] FOREIGN KEY ([tags_idtags]) REFERENCES tags ([idtags]) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT [fk_tendencias_has_tags_tendencias1] FOREIGN KEY ([tendencias_idtendencias]) REFERENCES `tendencias` ([idtendencias]) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
