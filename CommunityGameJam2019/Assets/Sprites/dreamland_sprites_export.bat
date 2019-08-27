set folderRoot=Dreamland
set scaling=--scale 2

rem [Player]

rem idle dreamland (body/legs)
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerIdle/player_body_idle_left.aseprite %scaling% --save-as %folderRoot%/PlayerIdle/player_body_idle_left.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerIdle/player_legs_idle_left.aseprite %scaling% --save-as %folderRoot%/PlayerIdle/player_legs_idle_left.png

rem walk dreamland (body/legs)
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerWalk/player_body_walk_left.aseprite %scaling% --save-as %folderRoot%/PlayerWalk/player_body_walk_left.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerWalk/player_legs_walk_left.aseprite %scaling% --save-as %folderRoot%/PlayerWalk/player_legs_walk_left.png

rem walk (legs) dreamland
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerWalk/player_legs_walk_left.aseprite %scaling% --save-as %folderRoot%/PlayerWalk/player_legs_walk_left.png

rem Finger dreamland
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerFinger/finger_right.aseprite %scaling% --save-as %folderRoot%/PlayerFinger/finger_right.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/PlayerFinger/finger_left.aseprite %scaling% --save-as %folderRoot%/PlayerFinger/finger_left.png

rem --------------

rem [Decoration]
set folderCustom=Decorations

rem Rock
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/rock_1.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/rock_1.png

rem Fency
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/fency_1.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/fency_1.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/fency_2.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/fency_2.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/fency_3.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/fency_3.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/fency_4.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/fency_4.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/fency_5.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/fency_5.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/fency_6.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/fency_6.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/fency_7.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/fency_7.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/fency_8.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/fency_8.png



rem Heart
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/heart.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/heart.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/heart_blue.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/heart_blue.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/heart_green.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/heart_green.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/heart_yellow.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/heart_yellow.png

rem Flover
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/flover_red_1.aseprite --scale 1 --save-as %folderRoot%/%folderCustom%/flover_red_1.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/flover_white_1.aseprite --scale 1 --save-as %folderRoot%/%folderCustom%/flover_white_1.png

rem Candy
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/candy_1.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/candy_1.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/mini_candy_red.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/mini_candy_red.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/mini_candy_blue.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/mini_candy_blue.png

rem Pills
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/pill_blue.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/pill_blue.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/pill_red.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/pill_red.png

rem bullet heart
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/bullet_heart.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/bullet_heart.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/%folderCustom%/bullet_heart.aseprite %scaling% --save-as %folderRoot%/%folderCustom%/bullet_heart.png


rem --------------

rem [Map]
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/Map/map.aseprite %scaling% --save-as %folderRoot%/Map/map.png
"C:\Program Files\Aseprite\Aseprite.exe" -b %folderRoot%/Map/water_map.aseprite %scaling% --save-as %folderRoot%/Map/water_map.png

rem --------------

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
