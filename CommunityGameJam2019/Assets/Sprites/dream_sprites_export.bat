set folderRoot=Dreamland
set scaling=--scale 2

rem Player sprites
rem IDLE
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerIdle/player_idle_left.aseprite %scaling% --save-as %folderRoot%/PlayerIdle/player_idle_left.png
rem WALK
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerWalk/player_walk_left.aseprite %scaling% --save-as %folderRoot%/PlayerWalk/player_walk_left.png

rem Finger sprites
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerFinger/finger_right.aseprite %scaling% --save-as %folderRoot%/PlayerFinger/finger_right.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerFinger/finger_left.aseprite %scaling% --save-as %folderRoot%/PlayerFinger/finger_left.png
