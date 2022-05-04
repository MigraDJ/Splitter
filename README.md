Lines Splitter

Application to solve the SQL Server error message "Cannot execute script: Insufficient memory to continue the execution of the program", which is due to the script file size (caused by the huge amount of lines of code), with this app you can split your script into many files by specifying the number of lines per file (usually 5000 or 10000)

The solution theoretically should be running this command: "SQLCMD -d <database-name> -i filename.sql"
but sometimes you can't run SQLCMD, if that's the case use this app to split your huge script into smaller files, and then run one by one.

Made in:
Visual Studio 2022 (no 3rd party libraries needed) with .NET 6
Ⓒ Gabriel Burrola
