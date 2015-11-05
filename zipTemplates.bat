
for /d %%a in (".\src\*") do (
    zip "%%~na.zip" "%%a"
    )

if not exist ".\lib" (
    mkdir .\lib
)

mv *.zip .\lib