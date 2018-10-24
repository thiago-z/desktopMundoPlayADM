SELECT nomegenero FROM filmes
INNER JOIN filme_genero
ON filme_genero.filme = filmes.idfilmes
INNER JOIN generos
ON filme_genero.genero = generos.idgeneros
WHERE filme_genero.filme = 1

SELECT nomediretor FROM filmes
INNER JOIN filme_diretor
ON filme_diretor.filme = filmes.idfilmes
INNER JOIN diretores
ON filme_diretor.diretor = diretores.iddiretores
WHERE filme_diretor.filme = 1

SELECT nomePais FROM filmes
INNER JOIN filme_pais
ON filme_pais.filme = filmes.idfilmes
INNER JOIN paises
ON filme_pais.pais = paises.idpaises
WHERE filme_pais.filme = 1
