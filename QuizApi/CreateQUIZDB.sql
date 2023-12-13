CREATE DATABASE QUIZDB;
USE QUIZ_APAGAR_DEPOIS;

CREATE TABLE quiz (
  ID int NOT NULL AUTO_INCREMENT,
  TITLE varchar(255),
  IMAGE varchar(255),
  PRIMARY KEY (ID)
);

CREATE TABLE quiz (
  ID int NOT NULL AUTO_INCREMENT,
  TITLE varchar(255),
  IMAGE varchar(255),
  PRIMARY KEY (ID)
);

CREATE TABLE question (
  ID int NOT NULL,
  ENUNCIATION varchar(255) DEFAULT NULL,
  QUIZ_ID int DEFAULT NULL,
  IMAGE varchar(255) DEFAULT NULL,
  CORRECT_ANSWER int DEFAULT NULL,
  PRIMARY KEY (ID)
);

CREATE TABLE answer (
  ID int NOT NULL,
  TEXT varchar(255) DEFAULT NULL,
  QUESTION_ID int DEFAULT NULL,
  IMAGE varchar(255) DEFAULT NULL,
  PRIMARY KEY (ID),
  KEY QUESTION_ID_FK (QUESTION_ID),
  CONSTRAINT QUESTION_ID_FK FOREIGN KEY (QUESTION_ID) REFERENCES question (ID)
);

ALTER TABLE `question`
ADD KEY `QUIZ_ID_FK` (`QUIZ_ID`),
ADD KEY `CORRECT_ANSWER_FK` (`CORRECT_ANSWER`),
ADD CONSTRAINT `CORRECT_ANSWER_FK` FOREIGN KEY (`CORRECT_ANSWER`) REFERENCES `answer` (`ID`),
ADD CONSTRAINT `QUIZ_ID_FK` FOREIGN KEY (`ID`) REFERENCES `quiz` (`ID`);



-- Inserindo dados na tabela 'quiz'
INSERT INTO quiz (TITLE, IMAGE) VALUES ('O Enigma de Hogwarts', 'hogwarts.png');
INSERT INTO quiz (TITLE, IMAGE) VALUES ('O Mistério da Máquina do Mistério', 'mystery_machine.png');

select * from quiz
