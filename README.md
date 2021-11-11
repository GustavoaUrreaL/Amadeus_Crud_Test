# Amadeus_Crud_Test
Technical Test Amadeus

#Arquitectura 
Se uso una arquitectura MVC con api.net, angular cli y base de datos relacional Postgres

#Infraestructure

Se propone un crud con un formulario de datos personales con 2 pestañas, en donde se trendra el Home que sera el formulario con los datos necesario y una tabla En donde se podra ver los usuarios previamente ingresados con su respectiva informacion, la url ="http://localhost:4200/home"

Se uso Visual studio 2019 para desarrollar la Api que tiene 5 principales(Getusers, GetuserId, Postcustoemr, Update customer, delete customer) servicios con su respectivo swagger el cual esta en la url=http://localhost:47859/swagger

Se relaciono la api con una base de datos local (DBlocal )en postgres el cual cuenta con una tabla con schema public la cual esta en la url =127.0.0.1:5433  con usuario postgres y clave 1234
