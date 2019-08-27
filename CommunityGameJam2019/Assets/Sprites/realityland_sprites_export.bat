set folderRoot=Realityland
set scaling=--scale 2

rem REALITYLAND

rem Decoration

set folderCustom=Decorations

rem Blood
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/drop_of_blood.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/drop_of_blood.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/blood_particle.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/blood_particle.png

rem Bullet
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/bullet.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/bullet.png
