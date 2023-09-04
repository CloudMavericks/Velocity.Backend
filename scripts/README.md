# Scripts

This directory contains scripts that are used to setup code, build, and run the frontend projects.

> **Tip**: You can directly invoke the scripts from your file explorer by double-clicking on them, with default parameters.

## Windows Batch Scripts

| Script | Description | Usage |
| ------ | ----------- | ---------- |
| `update_submodules.cmd` | Updates the submodules in the repository. | `.\update_submodules.cmd` |
| `build.cmd` | Builds the Backend project. | `.\build.cmd --config=<config>` |
| `run.cmd` | Builds and runs the Backend project. | `.\run.cmd --config=<config>` |

### Parameters

| Parameter | Description | Default Value | Valid Values |
| --------- | ----------- | ------------- | ------------ |
| `--config` | The configuration to build the project with. | `Debug` | `Debug`, `Release` |

## Windows PowerShell Scripts

| Script | Description | Usage |
| ------ | ----------- | ---------- |
| `update_submodules.ps1` | Updates the submodules in the repository. | `.\update_submodules.ps1` |
| `build.ps1` | Builds the Backend project. | `.\build.ps1 -Config <config>` |
| `run.ps1` | Builds and runs the Backend project. | `.\run.ps1 -Config <config>` |

### Parameters

| Parameter | Description | Default Value | Valid Values |
| --------- | ----------- | ------------- | ------------ |
| `-Config` | The configuration to build the project with. | `Debug` | `Debug`, `Release` |

## Linux/macOS Shell Scripts

| Script | Description | Usage |
| ------ | ----------- | ---------- |
| `update_submodules.sh` | Updates the submodules in the repository. | `./update_submodules.sh` |
| `build.sh` | Builds the Backend project. | `./build.sh --config=<config>` |
| `run.sh` | Builds and runs the Backend project. | `./run.sh --config=<config>` |

### Parameters

| Parameter | Description | Default Value | Valid Values |
| --------- | ----------- | ------------- | ------------ |
| `--config` | The configuration to build the project with. | `Debug` | `Debug`, `Release` |