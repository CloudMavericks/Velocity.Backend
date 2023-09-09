# Velocity - Backend

This repository contains the source code of the backend server for Project Velocity.

This repository is a part of the [Project Velocity](https://github.com/CloudMavericks/20IT928-PRIEE-C7.git).

It also contains the shared project as a submodule. 

| S.No | Submodule Name  | Repository Link                                       |
|------|-----------------|-------------------------------------------------------|
| 1    | Velocity.Shared | https://github.com/CloudMavericks/Velocity.Shared.git |

Other repositories of the project are:

| S.No | Repository Name   | Repository Link                                          |
|------|-------------------|----------------------------------------------------------|
| 1    | 20IT928-PRIEE-C7  | https://github.com/CloudMavericks/20IT928-PRIEE-C7.git   |
| 2    | Velocity.Frontend | https://github.com/CloudMavericks/Velocity.Frontend.git  |

## Team Members

| S.No | Name                | College Registration No |
|------|---------------------|-------------------------| 
| 1    | Sathiyaraman M      | 111720102140            |
| 2    | Sudharsan S V       | 111720102129            |
| 3    | Sairam J            | 111720102133            |
| 4    | Shree Ranganathan S | 111720102310            |

## How to clone this repository

Open a terminal and run the following command at your desired location:

```bash
git clone --recursive https://github.com/CloudMavericks/20IT928-PRIEE-C7.git
```

This will clone the repository along with all the submodules.

> Note: If you have already cloned the repository without the `--recursive` flag, then run the `update_submodules.sh` (for Linux/macOS) or `update_submodules.cmd` (Windows - Command Prompt) or `update_submodules.ps1` (for Windows - Powershell) script from the `scripts` folder to clone the submodules.

> Alternatively you can run the following command from the root of the repository to clone all the submodules.
```bash
git submodule update --init --recursive
```

