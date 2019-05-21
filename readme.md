# Kata 008

## Summary
Covers static Analysis of code and technical debt

## Pre Reading
- [Technical Debt](https://martinfowler.com/bliki/TechnicalDebt.html)
- [3 Types of Technica Debt](https://hackernoon.com/there-are-3-main-types-of-technical-debt-heres-how-to-manage-them-4a3328a4c50c)

## Discussion
- Install SonarLint for VS 2017
- Do not correct any default Sonar errors yet
- Add a SonarQube Connection
    * Url : https://atinternalsonar.azurewebsites.net
    * User name : sonar_user
    * Password  : pass@word1

    The UI is a little clunky, in real projects it will be connected through VSTS build pipelines
- Run an analysis on the project
    * Describe some issues it found
- Note that SonarLink cannot push to the SonarQube server, and can only use existing rules.
    * Can this still be useful? How so?
- Install SonarScanner (dotnet tool install --global dotnet-sonarscanner --version 4.3.1)
- Modify the analyze.ps1 to use your sonay key ("kata008_<<firstinitial>><<lastname>>) for example: kata008_lbass
    * Note: storing the password here is not an acceptable solution in a real project, how would you overcome that?
- Run the ps1
- Navigate to https://atinternalsonar.azurewebsites.net and navigate to your project
    * Discuss the results

## Thought Exercise
Not all Technical Debt can be easily quantified. Static analysis provides some measure of quality and technical debt, how would you manage others? How would you communicate quality and technical debt to non-technical team members or executives?

## Code Exercise
Update the project to pass SonarQube analysis