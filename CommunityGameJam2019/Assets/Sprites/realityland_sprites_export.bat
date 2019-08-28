set folderRoot=Realityland
set scaling=--scale 6

rem REALITYLAND

rem [Enemies]

set folderCustom=Enemies

rem Policeman
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/policeman_idle.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/policeman_idle.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/policeman_walk.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/policeman_walk.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/gun_policeman_left.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/gun_policeman_left.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/gun_policeman_right.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/gun_policeman_right.png

rem Military
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/military_idle.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/military_idle.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/military_walk.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/military_walk.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/military_gun_left.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/military_gun_left.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/military_gun_right.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/military_gun_right.png


rem --------------

rem [Decoration]

set scaling=--scale 2
set folderCustom=Decorations

rem Blood
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/drop_of_blood.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/drop_of_blood.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/blood_particle.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/blood_particle.png

rem Bullet
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/bullet.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/bullet.png

rem stop lights
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/stop_light.aseprite --scale 4 --save-as %folderRoot%/%folderCustom%/stop_light.png

rem Baryk
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/baryl_red.aseprite --scale 4 --save-as %folderRoot%/%folderCustom%/baryl_red.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/baryl_blue.aseprite --scale 4 --save-as %folderRoot%/%folderCustom%/baryl_blue.png


rem Building
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/building.aseprite --scale 4 --save-as %folderRoot%/%folderCustom%/building.png


rem --------------

rem [Map]
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/Map/map_reality.aseprite %scaling% --save-as %folderRoot%/Map/map_reality.png
