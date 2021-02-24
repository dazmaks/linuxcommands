@echo off
echo "Creating bin folder"
mkdir bin
::C files compile with same flags
echo "***COMPILING C***"

echo "ls.c is compiling to ls.exe"
gcc src/c/ls.c -s -Ofast -o bin/ls.exe

echo "cat.c is compiling to cat.exe"
gcc src/c/cat.c -s -Ofast -o bin/cat.exe

echo "clear.c is compiling to clear.exe"
gcc src/c/clear.c -s -Ofast -o bin/clear.exe

echo "touch.c is compiling to touch.exe"
gcc src/c/touch.c -s -Ofast -o bin/touch.exe

echo "rm.c is compiling to rm.exe"
gcc src/c/rm.c -s -Ofast -o bin/rm.exe

::C# compile
echo "***COMPILING C#***"

echo "mv.cs is compiling to mv.exe"
csc /target:exe /out:bin/mv.exe -recurse:src\cs\mv.cs -optimize

echo "cp.cs is compiling to cp.exe"
csc /target:exe /out:bin/cp.exe -recurse:src\cs\cp.cs -optimize

echo "df.cs is compiling to df.exe"
csc /target:exe /out:bin/df.exe -recurse:src\cs\df.cs -optimize

echo "ps.cs is compiling to ps.exe"
csc /target:exe /out:bin/ps.exe -recurse:src\cs\ps.cs -optimize

echo "pwd.cs is compiling to pwd.exe"
csc /target:exe /out:bin/pwd.exe -recurse:src\cs\pwd.cs -optimize

pause