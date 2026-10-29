### AIM
To perform version control operations using Git and apply collaboration workflow.

---

# 1. CHECK GIT

git --version

---

# 2. CONFIGURE GIT

git config --global user.name "Your Name"

git config --global user.email "your-email@gmail.com"

git config --list

---

# 3. CREATE LOCAL REPOSITORY

mkdir git-demo

cd git-demo

git init

---

# 4. CREATE FILE

echo "Hello Git" > index.html

---

# 5. CHECK STATUS

git status

---

# 6. ADD FILE

git add index.html

OR

git add .

---

# 7. COMMIT

git commit -m "Initial commit"

---

# 8. VIEW COMMIT HISTORY

git log --oneline

---

# 9. CREATE GITHUB REPOSITORY

Create a new repository on GitHub.

Copy the HTTPS repository URL.

Example:

https://github.com/USERNAME/REPOSITORY.git

---

# 10. CLONE GITHUB REPOSITORY

git clone <GitHub-URL>

cd <repository-name>

git status

---

# 11. CREATE / MODIFY FILE

echo "# Git Demo Project" > README.md

---

# 12. ADD + COMMIT

git add README.md

git commit -m "Add README file"

---

# 13. PUSH TO GITHUB

git push -u origin main

If required:

git branch -M main

git push -u origin main

---

# 14. CHECK REMOTE

git remote -v

---

# 15. CREATE BRANCH

git branch feature

git branch

---

# 16. SWITCH TO FEATURE BRANCH

git checkout feature

git branch

---

# 17. MODIFY FILE

echo "Feature added by collaborator" >> README.md

---

# 18. CHECK CHANGES

git status

---

# 19. ADD AND COMMIT FEATURE

git add README.md

git commit -m "Add feature"

---

# 20. SWITCH BACK TO MAIN

git checkout main

---

# 21. MERGE FEATURE

git merge feature

---

# 22. PUSH MERGED CHANGES

git push

---

# 23. PULL CHANGES

git pull

---

# 24. FETCH CHANGES

git fetch

---

# 25. CHECK HISTORY

git log --oneline

---

# 26. REBASE

git checkout feature

git rebase main

---

# 27. CHECK STATUS

git status

---

# IMPORTANT COMMANDS

git init
→ Initialize a new Git repository.

git clone <URL>
→ Copy a remote repository to the local system.

git status
→ Check current repository status.

git add .
→ Stage all changes.

git commit -m "message"
→ Save changes as a commit.

git push
→ Upload local commits to GitHub.

git pull
→ Download and integrate changes from GitHub.

git fetch
→ Download remote changes without merging.

git branch
→ Display branches.

git branch <name>
→ Create a new branch.

git checkout <name>
→ Switch branch.

git merge <name>
→ Merge another branch into the current branch.

git rebase <name>
→ Replay current branch commits on top of another branch.

git log --oneline
→ Display commit history.

git remote -v
→ Display remote repository URL.

---

# COMPLETE PRACTICAL FLOW

git clone <GitHub-URL>

cd <repository-name>

git status

echo "# Git Demo Project" > README.md

git add README.md

git commit -m "Add README file"

git push -u origin main

git branch feature

git checkout feature

echo "Feature added by collaborator" >> README.md

git add README.md

git commit -m "Add feature"

git checkout main

git merge feature

git push

git pull

git fetch

git log --oneline
