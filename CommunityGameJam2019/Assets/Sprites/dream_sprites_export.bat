set folderRoot=Dreamland
set scaling=--scale 2

rem PLAYER sprites

rem IDLE (body)
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerIdle/player_body_idle_left.aseprite %scaling% --save-as %folderRoot%/PlayerIdle/player_body_idle_left.png
rem IDLE (legs)
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerIdle/player_legs_idle_left.aseprite %scaling% --save-as %folderRoot%/PlayerIdle/player_legs_idle_left.png

rem WALK (body)
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerWalk/player_body_walk_left.aseprite %scaling% --save-as %folderRoot%/PlayerWalk/player_body_walk_left.png
rem WALK (legs)
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerWalk/player_legs_walk_left.aseprite %scaling% --save-as %folderRoot%/PlayerWalk/player_legs_walk_left.png


rem Finger sprites
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerFinger/finger_right.aseprite %scaling% --save-as %folderRoot%/PlayerFinger/finger_right.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerFinger/finger_left.aseprite %scaling% --save-as %folderRoot%/PlayerFinger/finger_left.png

rem Décoration
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/Decoration/rock_1.aseprite %scaling% --save-as %folderRoot%/Decoration/rock_1.png

rem Map
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/Map/map.aseprite %scaling% --save-as %folderRoot%/Map/map.png
