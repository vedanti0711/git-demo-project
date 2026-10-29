# ASDD PRACTICAL 1 — GIT & GITHUB

**Aim:** To perform version control operations using Git and apply collaboration workflow.

### 1. CHECK & CONFIGURE
```bash
git --version
git config --global user.name "Vedanti"
git config --global user.email "vedantichavan0711@gmail.com"
git config --list
```

### 2. LOCAL GIT REPOSITORY
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

### 3. GITHUB REPOSITORY
**First create a NEW empty repository on GitHub.**

Then copy its HTTPS URL.

Example URL:
```text
https://github.com/vedanti0711/demo2.git
```

Clone it:
```bash
git clone https://github.com/vedanti0711/demo2.git
cd demo2
git status
```

### 4. CREATE FILE → ADD → COMMIT → PUSH
```bash
echo "# Git Demo Project" > README.md
git status
git add README.md
git commit -m "Add README file"
git push -u origin main
```

### 5. BRANCHING
```bash
git branch
git branch feature
git checkout feature
git branch
```

### 6. MODIFY FEATURE
```bash
echo "Feature added by collaborator" >> README.md
git status
git add README.md
git commit -m "Add feature"
```

### 7. MERGE
```bash
git checkout main
git merge feature
git push
```

### 8. PULL & FETCH
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

### 10. CHECK REMOTE & HISTORY
```bash
git remote -v
git log --oneline
git status
```

# ⭐ COMPLETE FLOW TO PRACTICE

```bash
git --version
git config --global user.name "Vedanti"
git config --global user.email "vedantichavan0711@gmail.com"

mkdir git-practice
cd git-practice
git init

echo "Hello Git" > index.html
git add .
git commit -m "Initial commit"

git clone https://github.com/vedanti0711/demo2.git
cd demo2

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

git checkout feature
git rebase main

git status
git log --oneline
git remote -v
```

# COMMAND MEANINGS

```text
git init       = Create local repository
git clone      = Copy GitHub repository to computer
git status     = Check current changes
git add        = Stage changes
git commit     = Save changes
git push       = Send changes to GitHub
git pull       = Get + merge changes from GitHub
git fetch      = Get changes without merging
git branch     = Create/view branches
git checkout   = Switch branch
git merge      = Combine branch changes
git rebase     = Replay commits on another branch
git log        = Show commit history
git remote -v  = Show GitHub connection
```

# ⚠️ IMPORTANT

**Never type `< >` around a URL.**

Correct:
```bash
git clone https://github.com/vedanti0711/demo2.git
```

Wrong:
```bash
git clone <https://github.com/vedanti0711/demo2.git>
```
