pipeline {
    agent any 
    stages {
        stage('Checkout code') { 
            steps {
                git branch: 'develop', url: 'https://github.com/jsotelo83/seleniumTraining.git'
            }
        }
        stage('Restore Nuget') { 
            steps {
                bat label: '', script: '"C:\\ProgramData\\chocolatey\\bin\\nuget.exe" restore SP-Challenge.sln'
            }
        }
        stage('Build') { 
            steps {
                bat "\"${tool 'MSBuildLocal'}\" SP-Challenge.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
            }
        }
        stage('Test') { 
            steps {
                bat '"C:\\ProgramData\\chocolatey\\bin\\nunit3-console.exe" SP-Challenge/bin/Debug/SP-Challenge.exe'
            }
        }
    }
}