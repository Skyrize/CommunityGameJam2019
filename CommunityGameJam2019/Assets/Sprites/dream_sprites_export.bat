set folderRoot=Dreamland
set scaling=--scale 2

rem [PLAYER]

rem IDLE (body)
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerIdle/player_body_idle_left.aseprite %scaling% --save-as %folderRoot%/PlayerIdle/player_body_idle_left.png
rem WALK (body)
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerWalk/player_body_walk_left.aseprite %scaling% --save-as %folderRoot%/PlayerWalk/player_body_walk_left.png

rem IDLE (legs)
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerIdle/player_legs_idle_left.aseprite %scaling% --save-as %folderRoot%/PlayerIdle/player_legs_idle_left.png
rem WALK (legs)
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerWalk/player_legs_walk_left.aseprite %scaling% --save-as %folderRoot%/PlayerWalk/player_legs_walk_left.png


rem Finger sprites
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerFinger/finger_right.aseprite %scaling% --save-as %folderRoot%/PlayerFinger/finger_right.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerFinger/finger_left.aseprite %scaling% --save-as %folderRoot%/PlayerFinger/finger_left.png

rem Décoration
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/Decoration/rock_1.aseprite %scaling% --save-as %folderRoot%/Decoration/rock_1.png

rem Map
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/Map/map.aseprite %scaling% --save-as %folderRoot%/Map/map.png

rem [Enemies]

rem Sheep Idle & Walk
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/Enemies/Sheep/sheep_idle.aseprite %scaling% --save-as %folderRoot%/Enemies/Sheep/sheep_idle.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/Enemies/Sheep/sheep_walk.aseprite %scaling% --save-as %folderRoot%/Enemies/Sheep/sheep_walk.png

rem Monkey Idle & Walk
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/Enemies/Monkey/monkey_idle.aseprite %scaling% --save-as %folderRoot%/Enemies/Monkey/monkey_idle.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/Enemies/Monkey/monkey_walk.aseprite %scaling% --save-as %folderRoot%/Enemies/Monkey/monkey_walk.png

rem Wolf Idle & Walk
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/Enemies/Wolf/wolf_idle.aseprite %scaling% --save-as %folderRoot%/Enemies/Wolf/wolf_idle.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/Enemies/Wolf/wolf_walk.aseprite %scaling% --save-as %folderRoot%/Enemies/Wolf/wolf_walk.png