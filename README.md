# ASDD PRACTICAL 1 — GIT & GITHUB
**Aim:** To perform version control operations using Git and apply collaboration workflow.

### 1. SETUP
```bash
git --version
git config --global user.name "Your Name"
git config --global user.email "your-email@gmail.com"
git config --list
```

### 2. LOCAL REPOSITORY
```bash
mkdir git-demo
cd git-demo
git init
echo "Hello Git" > index.html
git status
git add .
git commit -m "Initial commit"
git log --oneline
```

### 3. GITHUB — CLONE & PUSH
```bash
git clone <GitHub-URL>
cd <repository-name>
git status
echo "# Git Demo Project" > README.md
git add README.md
git commit -m "Add README file"
git push -u origin main
```

### 4. BRANCHING
```bash
git branch
git branch feature
git checkout feature
git branch
```

### 5. MODIFY & COMMIT
```bash
echo "Feature added by collaborator" >> README.md
git status
git add README.md
git commit -m "Add feature"
```

### 6. MERGE
```bash
git checkout main
git merge feature
git push
```

### 7. PULL & FETCH
```bash
git pull
git fetch
```

### 8. REBASE
```bash
git checkout feature
git rebase main
git status
```

### 9. REMOTE & HISTORY
```bash
git remote -v
git log --oneline
git status
```

### ⭐ MAIN WORKFLOW
```text
Clone → Status → Add → Commit → Push
                    ↓
              Branch → Checkout
                    ↓
             Modify → Add → Commit
                    ↓
             Checkout main
                    ↓
                  Merge
                    ↓
                  Push
```

### IMPORTANT COMMANDS
```text
git init       → Initialize repository
git clone      → Copy remote repository
git status     → Check changes
git add        → Stage changes
git commit     → Save changes
git push       → Upload changes
git pull       → Download + merge changes
git fetch      → Download without merge
git branch     → Manage branches
git checkout   → Switch branch
git merge      → Combine branches
git rebase     → Replay commits
git log        → View history
git remote -v  → View remote repository
```
