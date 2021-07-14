@echo off
SET root=%~dp0

@echo Delete and Re-create parameter_from_compass.txt file   
IF EXIST %root%parameter_from_compass.txt DEL %root%parameter_from_compass.txt /q /f
echo browser^=%browser%^&environment^=%environment%^&datacenter^=%datacenter%^&username^=%username%^&password^=%password%>%root%parameter_from_compass.txt


@ECHO Runing test on %1 dll: %root%%dll%
REM Running tests
"C:\ProgramData\chocolatey\lib\NUnit.Runners.Net4\tools\nunit-console-x86.exe" "%root%%dll%" /nodots /include:%category%

if ERRORLEVEL 1 goto fail

goto end

:fail
exit /b 1

:end
exit /b 0