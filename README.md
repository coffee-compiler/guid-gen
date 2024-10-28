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
guidgen 3

#30462a77-3c35-4c4a-8a3e-79edf12bb42f
#955d03cd-6587-4add-ae18-f523042d22bf
#eedeeaa2-d773-4e88-99d1-d5f371e788d0
```

### Generate v7 GUIDs

```powershell
guidgen 5 --v7

#0192d50d-d3b5-72fe-850a-dda67c33d5ec
#0192d50d-d3b8-73c8-b657-673d4eeb83cf
#0192d50d-d3b8-7451-9018-d513dfb3d5e5
#0192d50d-d3b8-7d26-8938-119c37afc1df
#0192d50d-d3b8-743d-9bf6-f2d640bc46ff
```

### Render Table

```powershell
guidgen 10 --table

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