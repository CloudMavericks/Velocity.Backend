#!/bin/bash

# Parameters
Config="Debug"

# Parse command-line arguments
while [[ $# -gt 0 ]]; do
    key="$1"
    case $key in
        --config=*)
            Config="${key#*=}"
            shift
            ;;
        *)
            # Unknown option
            echo "Unknown option: $1"
            exit 1
            ;;
    esac
done

echo "Selected Build Configuration: $Config"

# Initialize and update submodules
echo "Initializing and updating submodules..."
git submodule update --init --recursive

# Restore projects
echo "Restoring the Backend projects..."
dotnet restore ../Velocity.Backend/Velocity.Backend.sln

# Build the projects
echo "Building the Backend projects..."
dotnet build ../Velocity.Backend/Velocity.Backend.sln --configuration $Config --no-restore

echo "Press any key to continue..."
read -n 1 -s