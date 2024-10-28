# GuidGen

GuidGen is a simple GUID/UUID generator that should be used as a dotnet tool.

## Installation

```
dotnet pack
dotnet tool install --global --add-source ./nupkg GuidGenerator
```

## Usage

### Generate v4 GUIDs

```powershell
guidgen 10

#  Index │                 GUID
# ───────┼──────────────────────────────────────
#    0   │ 17ae4421-d333-404e-9990-e10ff59959f4
#    1   │ bcaa54d0-a0d7-40da-9451-c0743c6cde3a
#    2   │ 65a984da-c50a-4c7d-8907-3903217e9b74
#    3   │ b3ef16f7-c669-4f85-90a7-d6059eb79481
#    4   │ 52cb7218-efe2-471e-968f-a53ef6a1427a
#    5   │ 043ab5cc-8b2a-4518-920c-51b85c11ba65
#    6   │ c85a512f-1b23-4f5c-8923-af5dac4f3609
#    7   │ 83735616-af97-4bb9-b471-12f4aa2db579
#    8   │ 3cb03e74-f380-4637-9a1e-e00d21da328e
#    9   │ 0d5ad8e6-efd5-4551-90d0-221582e480ee
```

### Generate v7 GUIDs

```powershell
guidgen 5 --v7

#  Index │                 GUID
# ───────┼──────────────────────────────────────
#    0   │ 0192d4ec-d57e-7106-b9f4-5b64db4fbca0
#    1   │ 0192d4ec-d57f-7e97-a401-a76bbbea6dee
#    2   │ 0192d4ec-d57f-74b1-9a7f-1c7dc06ce436
#    3   │ 0192d4ec-d57f-7840-8f39-38ae17609a20
#    4   │ 0192d4ec-d57f-707b-8b2b-708f3b2490e2
```
