@echo off
echo Creating bin folder
mkdir bin

::C# compile
echo ***COMPILING***

echo cat.cs is compiling to cat.exe
csc /target:exe /out:bin/cat.exe -recurse:src\cs\cat.cs -optimize

echo clear.cs is compiling to clear.exe
csc /target:exe /out:bin/clear.exe -recurse:src\cs\clear.cs -optimize

echo cp.cs is compiling to cp.exe
csc /target:exe /out:bin/cp.exe -recurse:src\cs\cp.cs -optimize

echo df.cs is compiling to df.exe
csc /target:exe /out:bin/df.exe -recurse:src\cs\df.cs -optimize

echo du.cs is compiling to du.exe
csc /target:exe /out:bin/du.exe -recurse:src\cs\du.cs -optimize

echo kill.cs is compiling to kill.exe
csc /target:exe /out:bin/kill.exe -recurse:src\cs\kill.cs -optimize

echo ls.cs is compiling to ls.exe
csc /target:exe /out:bin/ls.exe -recurse:src\cs\ls.cs -optimize

echo mv.cs is compiling to mv.exe
csc /target:exe /out:bin/mv.exe -recurse:src\cs\mv.cs -optimize

echo ps.cs is compiling to ps.exe
csc /target:exe /out:bin/ps.exe -recurse:src\cs\ps.cs -optimize

echo pwd.cs is compiling to pwd.exe
csc /target:exe /out:bin/pwd.exe -recurse:src\cs\pwd.cs -optimize

echo rm.cs is compiling to rm.exe
csc /target:exe /out:bin/rm.exe -recurse:src\cs\rm.cs -optimize

echo touch.cs is compiling to touch.exe
csc /target:exe /out:bin/touch.exe -recurse:src\cs\touch.cs -optimize


echo uname.cs is compiling to uname.exe
csc /target:exe /out:bin/uname.exe -recurse:src\cs\uname.cs -optimize

pause