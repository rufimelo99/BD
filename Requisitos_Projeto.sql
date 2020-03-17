/*
Quantidade de cada Hamburguer vendido, ordenado por popularidade
*/
CREATE VIEW POPULARIDADE_HAMBURGUER (Nome_Hamburguer, Quant_Vendidos) AS
	SELECT Nome_Hamburguer, SUM(Quantidade) AS total 
	FROM HAMBURGUER_2
	GROUP BY Nome_Hamburguer
	ORDER BY total DESC offset 0 rows;

SELECT * FROM POPULARIDADE_HAMBURGUER

DROP VIEW POPULARIDADE_HAMBURGUER


/* 
Preco total de cada Pedido, falta adicionar data (ideia: por um atributo com dia da semana em que foi feito o pedido em HAMBURGUER_1 OU PEDIDO)
*/
CREATE VIEW PAGAMENTO AS 
	
	SELECT No_Pedido, SUM(Quantidade * Preco_Hamburguer) AS Preco_Total, Metodo	
	FROM (PEDIDO JOIN HAMBURGUER_2 ON Num_Pedido = No_Pedido 
		 JOIN HAMBURGUER_1 ON Nome_Hamburguer1 = Nome_Hamburguer)
		 JOIN METODO_PAGAMENTO ON Num_Pedido = Nom_Pedido	
	GROUP BY No_Pedido, Metodo
	ORDER BY No_Pedido ASC offset 0 rows;

SELECT * FROM PAGAMENTO

DROP VIEW PAGAMENTO


/*
Quantidade de pedidos em cada dia da semana 
*/

/*
Rating de cada hamburguer de cada pedido
*/
CREATE VIEW RATING_HAMBURGUER (Nome_Hamburguer, Rating) AS
	SELECT Nome_Hamburguer, AVG(Rating) AS Rating
	FROM HAMBURGUER_2
	GROUP BY Nome_Hamburguer
	ORDER BY Rating DESC offset 0 rows;

SELECT * FROM RATING_HAMBURGUER

DROP VIEW RATING_HAMBURGUER

/*
Average Rating dos pedidos para cada cozinheiro
*/
CREATE VIEW RATING_COZINHEIRO AS
	SELECT Cozinheiro_ID, AVG(Rating) AS Rating
	FROM PEDIDO JOIN HAMBURGUER_2 ON Num_Pedido = No_Pedido
	GROUP BY Cozinheiro_ID;

SELECT * FROM RATING_COZINHEIRO

DROP VIEW RATING_COZINHEIRO

/*
Average Rating do restaurante em si
*/
CREATE VIEW RATING_RESTAURANTE AS
	SELECT AVG(Rating) AS Rating_Restaurante FROM HAMBURGUER_2

SELECT* FROM RATING_RESTAURANTE

DROP VIEW RATING_RESTAURANTE

/*
Cliente mais popular
*/
CREATE VIEW CLIENTE_POPULAR AS
	SELECT Nome, Num_Telefone, COUNT(Num_Telefone_Cliente) AS Pedidos_Efetuados
	FROM CLIENTE JOIN PEDIDO ON Num_Telefone = Num_Telefone_Cliente
	GROUP BY Nome, Num_Telefone
	ORDER BY Pedidos_Efetuados DESC offset 0 rows;

SELECT * FROM CLIENTE_POPULAR

DROP VIEW CLIENTE_POPULAR

/*
Rating médio de cada pedido com o respetivo comentario
*/
CREATE VIEW AVALIACAO_2 AS
	SELECT No_Pedido, AVG(Rating) AS Rating, Comentario
	FROM AVALIACAO JOIN HAMBURGUER_2 ON Nu_Pedido = No_Pedido
	GROUP BY No_Pedido, Comentario
	ORDER BY No_Pedido ASC offset 0 rows;

SELECT * FROM AVALIACAO_2

SELECT * FROM AVALIACAO_2 JOIN 




DROP VIEW AVALIACAO_2


/*
Pedidos do cozinheiro com ID 01
*/
CREATE VIEW COZINHEIRO_01 AS
	SELECT No_Pedido, Nome_Hamburguer, Quantidade
	FROM PEDIDO JOIN HAMBURGUER_2 ON Num_Pedido = No_Pedido
	WHERE Cozinheiro_ID = 01

SELECT * FROM COZINHEIRO_01

DROP VIEW COZINHEIRO_01

/*
Pedidos do cozinheiro com ID 02
*/
CREATE VIEW COZINHEIRO_02 AS
	SELECT No_Pedido, Nome_Hamburguer, Quantidade
	FROM PEDIDO JOIN HAMBURGUER_2 ON Num_Pedido = No_Pedido
	WHERE Cozinheiro_ID = 02

SELECT * FROM COZINHEIRO_02

DROP VIEW COZINHEIRO_02

/*
Pedidos de um certo utilizador
*/
CREATE VIEW PEDIDOS_UTILIZADOR AS
	SELECT No_Pedido, Nome_Hamburguer, Quantidade, Data_Pedido
	FROM PEDIDO JOIN HAMBURGUER_2 ON Num_Pedido = No_Pedido
	WHERE Num_Telefone_Cliente = '504-377-1184'
	ORDER BY Data_Pedido DESC offset 0 rows;

SELECT * FROM PEDIDOS_UTILIZADOR

DROP VIEW PEDIDOS_UTILIZADOR

/*
Dias em que houve mais pedidos ordenado por popularidade
*/
CREATE VIEW POPULARIDADE_DIAS AS
	SELECT Data_Pedido, Count(Data_Pedido) AS Quantidade
	FROM HAMBURGUER_2
	GROUP BY Data_Pedido
	ORDER BY Quantidade DESC offset 0 rows;

SELECT * FROM POPULARIDADE_DIAS

DROP VIEW POPULARIDADE_DIAS

/*
Dias em que houve mais pedidos ordenado por data
*/
CREATE VIEW PEDIDOS_DIAS AS
	SELECT Data_Pedido, Count(Data_Pedido) AS Quantidade
	FROM HAMBURGUER_2
	GROUP BY Data_Pedido
	ORDER BY Data_Pedido DESC offset 0 rows;

SELECT * FROM PEDIDOS_DIAS

DROP VIEW PEDIDOS_DIAS

/*
Veiculos com respetivo funcionario 
*/
CREATE VIEW VEICULO_2 AS
	SELECT * FROM VEICULO

SELECT * FROM VEICULO_2

DROP VIEW VEICULO_2

GO
CREATE Trigger multibank ON METODO_PAGAMENTO 
AFTER INSERT, UPDATE 
AS
	DECLARE @total as real
	
	SELECT @total = Valor_a_dar FROM inserted;
	IF @total < 10


SELECT * FROM PEDIDOS_UTILIZADOR
