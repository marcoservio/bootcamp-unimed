CREATE TABLE pessoa
(
    id INT NOT NULL PRIMARY KEY AUTO INCREMENT,
    nome VARCHAR(30) NOT NULL,
    nascimento DATE
);

INSERT INTO pessoa
    (nome, nascimento)
VALUES
    ('Marco', '1997-07-31');

INSERT INTO pessoa
    (nome, nascimento)
VALUES
    ('Maria', '1999-01-22');

INSERT INTO pessoa
    (nome, nascimento)
VALUES
    ('Pedro', '2005-04-22');

INSERT INTO pessoa
    (nome, nascimento)
VALUES
    ('Marcela', '1997-12-20');

SELECT *
FROM pessoa;

SELECT nome, nascimento
FROM pessoa;

UPDATE pessoa SET nome = 'Maria Cecilia' WHERE id = 2;

UPDATE pessoa SET nome = 'Pedro Paulo' WHERE id = 3;

UPDATE pessoa SET nome = 'Marcela Clara' WHERE id = 4;

DELETE FROM pessoa WHERE id = 4;

SELECT *
FROM pessoa
ORDER BY nome DESC;

ALTER TABLE pessoa ADD genero VARCHAR(1) NOT NULL;

UPDATE pessoa SET genero = 'M' WHERE id IN(1, 3);

UPDATE pessoa SET genero = 'F' WHERE id IN(2, 5);

SELECT COUNT(id), genero
FROM pessoa;

INSERT INTO pessoa
    (nome, nascimento, genero)
VALUES
    ('Paula Ana', '1990-05-12', 'F');

CREATE TABLE cursos
(
    id_curso INT NOT NULL PRIMARY KEY AUTO INCREMENT,
    nome VARCHAR(10)
);

INSERT INTO cursos
    (nome)
VALUES
    ('MySQL');

INSERT INTO cursos
    (nome)
VALUES
    ('HTML');

INSERT INTO cursos
    (nome)
VALUES
    ('CSS');

UPDATE cursos SET nome = 'HTML5' WHERE id_curso = 2;

SELECT *
FROM cursos;

INSERT INTO cursos
    (nome)
VALUES
    ('Economia');

DELETE FROM cursos WHERE id_curso = 4;

ALTER TABLE cursos ADD carga_horaria INT(2);

UPDATE cursos SET carga_horaria = 20;

UPDATE cursos SET carga_horaria = 40 WHERE id_curso = 2;

DROP TABLE usuarios;

DROP DATABASE test;

USE TEST;

CREATE TABLE videos
(
    id_video INT NOT NULL PRIMARY KEY AUTO INCREMENT,
    author INT,
    title VARCHAR(30),
    likes INT,
    dislikes INT
);

INSERT INTO videos
    (author, title, likes, dislikes)
VALUES
    ('1', 'MySQL', 10, 2);

INSERT INTO videos
    (author, title, likes, dislikes)
VALUES
    ('2', 'HTML', 30, 1);

INSERT INTO videos
    (author, title, likes, dislikes)
VALUES
    ('4', 'CSS', 18, 3);

INSERT INTO videos
    (author, title, likes, dislikes)
VALUES
    ('3', 'JavaScript', 15, 8);

INSERT INTO videos
    (author, title, likes, dislikes)
VALUES
    ('1', 'Python', 50, 0);

CREATE TABLE author
(
    id_author INT NOT NULL PRIMARY KEY AUTO INCREMENT,
    name VARCHAR(30),
    born DATE
);

INSERT INTO author
    (name, born)
VALUES
    ('Marco', '1997-07-31');

INSERT INTO author
    (name, born)
VALUES
    ('Maria', '1999-10-12');

INSERT INTO author
    (name, born)
VALUES
    ('Pedro', '1990-02-11');

INSERT INTO author
    (name, born)
VALUES
    ('João', '1992-06-01');

INSERT INTO author
    (name, born)
VALUES
    ('Flavia', '1998-12-12');

UPDATE videos SET author = '';

UPDATE videos SET author = 1 WHERE id_video = 1;

UPDATE videos SET author = 2 WHERE id_video = 2;

UPDATE videos SET author = 4 WHERE id_video = 3;

UPDATE videos SET author = 3 WHERE id_video = 4;

UPDATE videos SET author = 1 WHERE id_video = 5;

ALTER TABLE videos ADD CONSTRAINT fk_author FOREIGN KEY (fk_author) REFERENCES author (id_author) ON DELETE CASCADE ON UPDATE CASCADE;

SELECT author.name AS author, videos.title, videos.likes, videos.dislikes
FROM videos JOIN author ON videos.fk_author = author.id_author;

CREATE TABLE seo
(
    id_seo INT NOT NULL PRIMARY KEY AUTO INCREMENT,
    category VARCHAR(20) NOT NULL
)

INSERT INTO videos
    (fk_author, title, likes, dislikes)
VALUES
    (2, 'PHP', 20, 8);

INSERT INTO seo
    (category)
VALUES
    ('Frontend');

INSERT INTO seo
    (category)
VALUES
    ('Backend');

ALTER TABLE videos ADD fk_seo INT NOT NULL;

UPDATE videos SET fk_seo = 1 WHERE id_video IN (2, 3, 4)

UPDATE videos SET fk_seo = 2 WHERE id_video IN (1, 5, 6);

ALTER TABLE videos ADD CONSTRAINT fk_seo FOREIGN KEY (fk_seo) REFERENCES seo (id_seo) ON DELETE CASCADE ON UPDATE CASCADE;

SELECT *
FROM videos JOIN seo ON videos.fk_seo = seo.id_seo;

SELECT videos.title, seo.category
FROM videos JOIN seo ON videos.fk_seo = seo.id_seo;

SELECT videos.title, author.name AS author, seo.category
FROM videos JOIN seo ON videos.fk_seo = seo.id_seo JOIN author ON videos.fk_author = author.id_author;

CREATE TABLE playlist
(
    id_playlist INT NOT NULL PRIMARY KEY AUTO INCREMENT,
    name_playlist VARCHAR(30) NOT NULL
);

INSERT INTO playlist
    (name_playlist)
VALUES
    ('HTML + CSS');
INSERT INTO playlist
    (name_playlist)
VALUES
    ('HTML + PHP + JS');
INSERT INTO playlist
    (name_playlist)
VALUES
    ('Python + PHP');

CREATE TABLE videos_playlist
(
    id_vp INT NOT NULL PRIMARY KEY AUTO INCREMENT,
    fk_videos INT NOT NULL ,
    fk_playlist INT NOT NULL
)

ALTER TABLE videos_playlist ADD CONSTRAINT fk_videos FOREIGN KEY (fk_videos) REFERENCES videos (id_video) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE videos_playlist ADD CONSTRAINT fk_playlist FOREIGN KEY (fk_playlist) REFERENCES playlist (id_playlist) ON DELETE CASCADE ON UPDATE CASCADE;

INSERT INTO videos_playlist
    (fk_videos, fk_playlist)
VALUES(2, 1);

INSERT INTO videos_playlist
    (fk_videos, fk_playlist)
VALUES(3, 1);

SELECT *
FROM playlist p JOIN videos_playlist pl ON p.id_playlist = pl.fk_playlist;

SELECT *
FROM playlist p JOIN videos_playlist pl ON p.id_playlist = pl.fk_playlist JOIN videos v ON v.id_video = pl.fk_videos;

SELECT p.name_playlist, v.title
FROM playlist p
    JOIN videos_playlist pl ON p.id_playlist = pl.fk_playlist
    JOIN videos v ON v.id_video = pl.fk_videos;

SELECT p.name_playlist, v.title, a.name as author
FROM playlist p
    JOIN videos_playlist pl ON p.id_playlist = pl.fk_playlist
    JOIN videos v ON v.id_video = pl.fk_videos
    JOIN author a ON v.fk_author = a.id_author;

ALTER TABLE playlist ADD fk_author INT NOT NULL;

UPDATE playlist SET fk_author = 4 WHERE id_playlist = 1;

UPDATE playlist SET fk_author = 2 WHERE id_playlist = 2;

UPDATE playlist SET fk_author = 3 WHERE id_playlist = 3;

ALTER TABLE playlist ADD CONSTRAINT fk_author FOREIGN KEY (fk_author) REFERENCES author (id_author) ON DELETE CASCADE ON UPDATE CASCADE;

SELECT a.name, p.name_playlist
FROM playlist p JOIN author a ON p.fk_author = a.id_author

INSERT INTO videos_playlist
    (fk_videos, fk_playlist)
VALUES
    (1, 2);

INSERT INTO videos_playlist
    (fk_videos, fk_playlist)
VALUES
    (6, 2);

INSERT INTO videos_playlist
    (fk_videos, fk_playlist)
VALUES
    (4, 2);

INSERT INTO videos_playlist
    (fk_videos, fk_playlist)
VALUES
    (6, 3);

INSERT INTO videos_playlist
    (fk_videos, fk_playlist)
VALUES
    (5, 3);

SELECT *
FROM videos_canais vc JOIN videos v ON vc.fk_video = v.id_video;

SELECT *
FROM videos_canais vc
    JOIN videos v ON vc.fk_video = v.id_video
    JOIN canais c ON vc.fk_canal = c.id_canal;

SELECT v.nome_video, v.autor_video, c.nome_canal
FROM videos_canais vc
    JOIN videos v ON vc.fk_video = v.id_video
    JOIN canais c ON vc.fk_canal = c.id_canal;

SELECT v.nome_video, v.autor_video, c.nome_canal
FROM videos_canais vc
    INNER JOIN videos v ON vc.fk_video = v.id_video
    INNER JOIN canais c ON vc.fk_canal = c.id_canal;

SELECT *
FROM videos_canais vc
    LEFT OUTER JOIN videos v ON vc.fk_video = v.id_video

SELECT *
FROM videos_canais vc
    RIGHT OUTER JOIN videos v ON vc.fk_video = v.id_video;

SELECT *
FROM videos v
    LEFT OUTER JOIN videos_canais vc ON vc.fk_video = v.id_video
    RIGHT OUTER JOIN canais c ON vc.fk_canal = c.id_canal;

    SELECT v.id_video, v.nome_video
    FROM videos v
        LEFT OUTER JOIN videos_canais vc ON vc.fk_video = v.id_video
UNION
    SELECT c.id_canal, c.nome_canal
    FROM videos_canais vc
        RIGHT OUTER JOIN canais c ON vc.fk_canal = c.id_canal;

SELECT *
FROM videos_canais
    JOIN videos ON videos_canais.fk_video = videos.id_video
    JOIN canais ON videos_canais.fk_canal = canais.id_canal
WHERE canais.id_canal = 2;