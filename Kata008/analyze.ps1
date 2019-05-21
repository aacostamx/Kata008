dotnet sonarscanner begin /k:"<<YOUR PROJECT KEY>>" /d:sonar.login="sonar_user" /d:sonar.password="pass@word1" /d:sonar.host.url="https://atinternalsonar.azurewebsites.net"
dotnet build
dotnet sonarscanner end  /d:sonar.login="sonar_user" /d:sonar.password="pass@word1"