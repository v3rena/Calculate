# Calculate
A small command line application that is a calculator.

## Gitflow priniciples in a nutshell
* Maintain two branches: `master` and `dev`
* Create temporary throw-away feature branches
* The `master` branch is most stable branch
* Maintain a `dev` branch where feature branch patches are integrated
* Tag only stable versions in the master branch

## Branches
All feature, bugfix and hotfix branches should contain the issue number as well as a short description of the issue (can be the same as the issue title).
For example:
* `186-add-new-deployment-group`
* `12-icon-mismatch`
* `248-crcp-inf2-should-be-uppercase`
* `1-implement-addition`

## Commits
A properly formed Git commit subject line should always be able to complete the following sentence:
If applied, this commit will `your subject line here`

For example:

* If applied, this commit will `update getting started documentation`
* If applied, this commit will `remove deprecated methods`
* If applied, this commit will `release version 1.0.0`
* If applied, this commit will `merge pull request #123 from user/branch`

If the commit fixes and issue, add `closes isse-no` to the commit message.

For example:
* `refactor pump class closes #56`
* `fix InvalidCastException closes #176`
