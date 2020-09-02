USE db24;
DELIMITER $$
CREATE TRIGGER mytbl8_2guard1 BEFORE INSERT ON mytbl8_2
FOR EACH ROW
BEGIN
DECLARE a varchar(100);
SELECT CURRENT_USER() INTO @a;
SIGNAL SQLSTATE '50000' SET message_text=@a;
END; $$
DELIMITER ;

INSERT INTO mytbl8_2(userRole) values('You!shall!not!pass!');
