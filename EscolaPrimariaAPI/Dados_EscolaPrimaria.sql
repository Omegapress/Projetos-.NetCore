-- Inserindo 10 professores com dados realistas
INSERT INTO PROFESSOR (ID_PROFESSOR, NOME, EMAIL, CPF, ENDERECO, NUMERO, COMPLEMENTO, CIDADE, ESTADO)
VALUES
(1, 'Carlos Silva', 'carlos.silva@universidade.com', 12345678901, 'Avenida Paulista', 1500, 'Apto 101', 'São Paulo', 'SP'),
(2, 'Mariana Costa', 'mariana.costa@universidade.com', 98765432100, 'Rua das Flores', 250, 'Casa', 'Rio de Janeiro', 'RJ'),
(3, 'Roberto Oliveira', 'roberto.oliveira@universidade.com', 13579135791, 'Alameda Santos', 320, 'Apto 202', 'Belo Horizonte', 'MG'),
(4, 'Ana Souza', 'ana.souza@universidade.com', 24680246802, 'Rua do Sol', 125, 'Casa 3', 'Curitiba', 'PR'),
(5, 'João Pereira', 'joao.pereira@universidade.com', 12309845678, 'Avenida Atlântica', 99, 'Cobertura', 'Florianópolis', 'SC'),
(6, 'Paula Almeida', 'paula.almeida@universidade.com', 99887766554, 'Rua do Lago', 400, 'Apto 201', 'Brasília', 'DF'),
(7, 'Bruno Carvalho', 'bruno.carvalho@universidade.com', 11122233344, 'Rua das Laranjeiras', 700, 'Casa', 'Salvador', 'BA'),
(8, 'Fernanda Lima', 'fernanda.lima@universidade.com', 44433322211, 'Rua das Palmeiras', 500, 'Apto 301', 'Porto Alegre', 'RS'),
(9, 'Pedro Santos', 'pedro.santos@universidade.com', 33322211144, 'Rua do Comércio', 450, 'Casa', 'Fortaleza', 'CE'),
(10, 'Cláudia Ramos', 'claudia.ramos@universidade.com', 55566677788, 'Avenida do Contorno', 1000, 'Apto 100', 'Goiânia', 'GO');

-- Inserindo 50 alunos com dados realistas
INSERT INTO ALUNO (ID_ALUNO, NOME, EMAIL, CPF, ENDERECO, NUMERO, COMPLEMENTO, CIDADE, ESTADO)
VALUES
(1, 'Lucas Fernandes', 'lucas.fernandes@exemplo.com', 12345678912, 'Rua Alfa', 123, 'Apto 12', 'São Paulo', 'SP'),
(2, 'Bianca Martins', 'bianca.martins@exemplo.com', 98765432112, 'Rua Beta', 456, 'Casa', 'Rio de Janeiro', 'RJ'),
(3, 'Matheus Souza', 'matheus.souza@exemplo.com', 12312312312, 'Rua Gama', 789, 'Apto 3', 'Belo Horizonte', 'MG'),
(4, 'Larissa Oliveira', 'larissa.oliveira@exemplo.com', 32132132132, 'Rua Delta', 101, 'Casa', 'Curitiba', 'PR'),
(5, 'Ricardo Santos', 'ricardo.santos@exemplo.com', 11122233344, 'Rua Epsilon', 202, 'Apto 1', 'Brasília', 'DF'),
(6, 'Camila Costa', 'camila.costa@exemplo.com', 22233344455, 'Rua Zeta', 303, 'Casa', 'Florianópolis', 'SC'),
(7, 'Gustavo Almeida', 'gustavo.almeida@exemplo.com', 33344455566, 'Rua Teta', 404, 'Apto 6', 'Salvador', 'BA'),
(8, 'Marina Silva', 'marina.silva@exemplo.com', 44455566677, 'Rua Iota', 505, 'Casa', 'Porto Alegre', 'RS'),
(9, 'Felipe Pereira', 'felipe.pereira@exemplo.com', 55566677788, 'Rua Kappa', 606, 'Apto 8', 'Fortaleza', 'CE'),
(10, 'Isabella Lima', 'isabella.lima@exemplo.com', 66677788899, 'Rua Lambda', 707, 'Casa', 'Goiânia', 'GO'),
(11, 'Vinicius Ribeiro', 'vinicius.ribeiro@exemplo.com', 77788899900, 'Rua Mu', 808, 'Apto 10', 'São Paulo', 'SP'),
(12, 'Juliana Cardoso', 'juliana.cardoso@exemplo.com', 88899900011, 'Rua Nu', 909, 'Casa', 'Rio de Janeiro', 'RJ'),
(13, 'Gabriel Rodrigues', 'gabriel.rodrigues@exemplo.com', 99900011122, 'Rua Xi', 100, 'Apto 11', 'Belo Horizonte', 'MG'),
(14, 'Amanda Moura', 'amanda.moura@exemplo.com', 11133355566, 'Rua Omicron', 111, 'Casa', 'Curitiba', 'PR'),
(15, 'Thiago Nunes', 'thiago.nunes@exemplo.com', 22244466677, 'Rua Pi', 112, 'Apto 12', 'Brasília', 'DF'),
(16, 'Daniel Barbosa', 'daniel.barbosa@exemplo.com', 33355577788, 'Rua Rho', 113, 'Casa', 'Florianópolis', 'SC'),
(17, 'Sara Gomes', 'sara.gomes@exemplo.com', 44466688899, 'Rua Sigma', 114, 'Apto 13', 'Salvador', 'BA'),
(18, 'Leonardo Melo', 'leonardo.melo@exemplo.com', 55577799900, 'Rua Tau', 115, 'Casa', 'Porto Alegre', 'RS'),
(19, 'Letícia Araújo', 'leticia.araujo@exemplo.com', 66688800011, 'Rua Upsilon', 116, 'Apto 14', 'Fortaleza', 'CE'),
(20, 'Renato Castro', 'renato.castro@exemplo.com', 77799911122, 'Rua Phi', 117, 'Casa', 'Goiânia', 'GO');
