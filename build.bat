@echo off
mkdir bin
::C files compile with same options
gcc src/ls.c -s -Ofast -o bin/ls.exe
gcc src/cat.c -s -Ofast -o bin/cat.exe
gcc src/clear.c -s -Ofast -o bin/clear.exe
gcc src/pwd.c -s -Ofast -o bin/pwd.exe
gcc src/touch.c -s -Ofast -o bin/touch.exe
gcc src/rm.c -s -Ofast -o bin/rm.exe

::C# compile
csc /target:exe /out:bin/mv.exe -recurse:src\mv.cs -optimize
csc /target:exe /out:bin/cp.exe -recurse:src\cp.cs -optimize
pause