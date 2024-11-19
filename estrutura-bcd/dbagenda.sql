Create database Create database dbagenda;

use dbagenda; 

Create table tbUsuarios (
	nome VARCHAR(60) NOT NULL,
	usuario VARCHAR(20) NOT NULL primary key,
    telefone VARCHAR(15),
    senha Varchar(15) NOT NULL
    );
    
Create table tbCategoria (
	cod INT auto_increment primary key,
    nome_categoria Varchar(60) NOT NULL,
    usuario VARCHAR(20)
    );
    
DELIMITER $$

Create trigger TrInsertCategoria 
before
INSERT
ON tbCategoria
FOR EACH ROW
BEGIN
	SET NEW.usuario = CURRENT_USER();
END;
$$

DELIMITER ;