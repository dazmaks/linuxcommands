@echo off
mkdir bin
gcc ls.c -o bin/ls.exe
gcc cat.c -o bin/cat.exe
gcc clear.c -o bin/clear.exe
gcc pwd.c -o bin/pwd.exe
gcc touch.c -o bin/touch.exe
pause