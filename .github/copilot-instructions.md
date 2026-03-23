# Copilot Instructions

## Project Guidelines
- Prefer architecture where all driver-related operations are centralized in `DriverService` and other classes should call `DriverService` instead of `DriverRepository` directly.