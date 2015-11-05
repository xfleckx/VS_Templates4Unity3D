@echo off

if not exist ".\lib" (
    mkdir .\lib
)

for /d %%a in (.\src\*) do (
    7z a "%%~na.zip" %%a\*
    )

mv *.zip .\lib

set templates_target="Templates\ItemTemplates\Unity3D"

set vs12_templates="%USERPROFILE%\Documents\Visual Studio 2012\"
set vs13_templates="%USERPROFILE%\Documents\Visual Studio 2013\"
set vs15_templates="%USERPROFILE%\Documents\Visual Studio 2015\"

for /d %%a in (%vs12_templates% %vs13_templates% %vs15_templates%) do (

    if exist %%a (
        xcopy /y /i .\lib\* %%a%templates_target%
        )

)