Create database dbagenda;

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

Create table Log_Usuario (
	Id_log int auto_increment primary key,
	usuario varchar(20) NOT NULL,
    data_e_hora datetime NOT NULL,
    descricao Varchar(50) 
    );
    
    
DELIMITER $$

Create trigger TrLogDeleteCategoria
after
Delete
on tbCategoria
FOR EACH ROW
BEGIN
	INSERT INTO Log_Usuario 
		(usuario,
		data_e_hora,
		descricao)
    VALUES (
		USER(),
        current_timestamp(),
        CONCAT('A categoria ', old.nome_categoria, ' foi excluida')
        );
END;
$$
DELIMITER ;

DELIMITER $$

Create trigger TrAtualizar
after
insert
on tbCategoria
FOR each row 
BEGIN 
	INSERT INTO Log_Usuario 
		(usuario,
		data_e_hora,
		descricao)
    VALUES (
		USER(),
        current_timestamp(),
        CONCAT('A categoria ', new.nome_categoria, ' foi adicionada')
        );
END;
$$
DELIMITER ;

DELIMITER $$

Create trigger TrUpdate
after
update
on tbCategoria
FOR each row 
BEGIN 
	INSERT INTO Log_Usuario 
		(usuario,
		data_e_hora,
		descricao)
    VALUES (
		USER(),
        current_timestamp(),
        CONCAT('A categoria ', old.nome_categoria, ' foi alterada para ', new.nome_categoria)
        );
END;
$$
DELIMITER ;