@echo on
git add .

SET /P COM=Commit :

git commit -m "%COM%"

git pull
pause