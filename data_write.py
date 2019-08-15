#author: Michael Gulson
#This file should write information to my sql database

#https://www.w3schools.com/python/python_mysql_insert.asp
#insert into table example
# import mysql.connector

# mydb = mysql.connector.connect(
#   host="localhost",
#   user="yourusername",
#   passwd="yourpassword",
#   database="mydatabase"
# )
# mycursor = mydb.cursor()

# sql = "INSERT INTO customers (name, address) VALUES (%s, %s)"
# val = ("John", "Highway 21")
# mycursor.execute(sql, val)

# mydb.commit()

# print(mycursor.rowcount, "record inserted.")


# import mysql.connector

# mydb = mysql.connector.connect(
#   host="gullman99.database.windows.net",
#   user="gullman99",
#   passwd="E@bch6969",
#   database="my database"
# )

# mycursor = mydb.cursor()

# sql = "INSERT INTO Users (ID, LastName, FirstName, Email) VALUES (%d, %s, %s, %s)"
# val = (4, "Gulson", "Luke", "lukegulson@gmail.com")
# mycursor.execute(sql, val)

# mydb.commit()

# print(mycursor.rowcount, "record inserted.")

from sqlalchemy import create_engine
engine = create_engine('gullman99.database.windows.net')