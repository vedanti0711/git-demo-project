# ASDD PRACTICAL 1 — GIT & GITHUB

### 1. SETUP
```bash
git --version
git config --global user.name "Vedanti"
git config --global user.email "vedantichavan0711@gmail.com"
git config --list
```

### 2. LOCAL REPOSITORY
```bash
mkdir git-practice
cd git-practice
git init
echo "Hello Git" > index.html
git status
git add .
git commit -m "Initial commit"
git log --oneline
```

### 3. CLONE GITHUB
```bash
git clone https://github.com/vedanti0711/demo2.git
cd demo2
git status
```

### 4. ADD → COMMIT → PUSH
```bash
echo "# Git Demo Project" > README.md
git status
git add README.md
git commit -m "Add README file"
git push -u origin main
```

### 5. BRANCH
```bash
git branch
git branch feature
git checkout feature
git branch
```

### 6. MODIFY → COMMIT
```bash
echo "Feature added by collaborator" >> README.md
git status
git add README.md
git commit -m "Add feature"
```

### 7. MERGE → PUSH
```bash
git checkout main
git merge feature
git push
```

### 8. PULL → FETCH
```bash
git pull
git fetch
```

### 9. REBASE
```bash
git checkout feature
git rebase main
git status
```

### 10. VERIFY
```bash
git status
git log --oneline
git remote -v
```

### ⭐ MAIN FLOW
```text
CLONE → ADD → COMMIT → PUSH
             ↓
          BRANCH
             ↓
        CHECKOUT FEATURE
             ↓
        MODIFY → COMMIT
             ↓
       CHECKOUT MAIN
             ↓
           MERGE
             ↓
           PUSH
```

### IMPORTANT COMMANDS
```text
git init       = Initialize
git clone      = Copy GitHub repo
git status     = Check changes
git add        = Stage
git commit     = Save
git push       = Upload
git pull       = Download + merge
git fetch      = Download only
git branch     = Branch
git checkout   = Switch
git merge      = Combine
git rebase     = Replay commits
git log        = History
git remote -v  = Remote
```
