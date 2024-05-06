#!/usr/bin/env bash
dotnet new console --framework net7.0 -o 2-new_project
cd 2-new_project
dotnet build
dotnet run
