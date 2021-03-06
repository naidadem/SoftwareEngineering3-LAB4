@echo off

rem The Java interpreter must be in PATH

rem Set OCLE_HOME to the directory where the distribution was unpacked
SET OCLE_HOME=.

if "%OCLE_HOME%"=="" goto setEnv

SET OCLE_LIB=%OCLE_HOME%\lib

cd %OCLE_HOME%
java -Xms192m -Xmx192m -classpath %OCLE_HOME%\bin;%OCLE_LIB%\kLF.jar;%OCLE_LIB%\jgraph.jar;%OCLE_LIB%\Whiteboard.jar;%OCLE_LIB%\template.jar;%OCLE_LIB%\velocity-dep-1.3.jar ro.ubbcluj.lci.gui.mainframe.GApplication
goto end

:setEnv
echo Please set the OCLE_HOME environment variable to the directory where the distribution was unpacked.

:end
pause