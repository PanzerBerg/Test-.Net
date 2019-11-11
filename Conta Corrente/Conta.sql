--
-- File generated with SQLiteStudio v3.2.1 on dom out 20 21:11:44 2019
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: Clientes
CREATE TABLE Clientes (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, nome VARCHAR NOT NULL, cpf VARCHAR NOT NULL, conta INTEGER NOT NULL, agencia INTEGER NOT NULL, digito INTEGER NOT NULL, saldo DOUBLE NOT NULL, saldo_dolar DOUBLE NOT NULL);
INSERT INTO Clientes (id, nome, cpf, conta, agencia, digito, saldo, saldo_dolar) VALUES (1, 'José Almeida', '147.527.351-20', 1234, 123456, 1, 60.0, 10.0);
INSERT INTO Clientes (id, nome, cpf, conta, agencia, digito, saldo, saldo_dolar) VALUES (2, 'Anderson de Souza', '254.658.321-50', 2345, 234567, 2, '851,629150390625', '173,86399841308594');
INSERT INTO Clientes (id, nome, cpf, conta, agencia, digito, saldo, saldo_dolar) VALUES (3, 'Alberto Andrade', '854.561.284-30', 3456, 345678, 3, 247.0, 0.0);
INSERT INTO Clientes (id, nome, cpf, conta, agencia, digito, saldo, saldo_dolar) VALUES (4, 'Marilia Alves', '155.157.486-54', 4567, 456789, 4, 857.0, 0.0);

-- Table: Clientes_Senhas
CREATE TABLE Clientes_Senhas (id INTEGER PRIMARY KEY NOT NULL, cpf VARCHAR NOT NULL, senha INTEGER NOT NULL);
INSERT INTO Clientes_Senhas (id, cpf, senha) VALUES (1, '147.527.351-20', 1234);
INSERT INTO Clientes_Senhas (id, cpf, senha) VALUES (2, '254.658.321-50', 2345);
INSERT INTO Clientes_Senhas (id, cpf, senha) VALUES (3, '854.561.284-30', 3456);
INSERT INTO Clientes_Senhas (id, cpf, senha) VALUES (4, '155.157.486-54', 4567);

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
