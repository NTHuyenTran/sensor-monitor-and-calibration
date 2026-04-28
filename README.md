# 🚀 Sensor Monitor & Calibration System (GUI)

![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2022-purple.svg)
![C#](https://img.shields.io/badge/Language-C%23-blue.svg)
![.NET](https://img.shields.io/badge/Framework-.NET%204.7.2%2F6.0-green.svg)
![License](https://img.shields.io/badge/License-MIT-yellow.svg)

## 📌 Introduction
This is a specialized Graphical User Interface (GUI) application developed using **C# WinForms**. It serves as a central dashboard that receives data from sensors via an MCU, visualizes real-time measurements, logs data, and provides a precise 2-point calibration toolset.

---

## 🛠 Core Features

### 1. 🖥 Real-time Monitoring (Monitor)
A minimalist and intuitive interface focusing on real-time measurement parameters:
* **Temperature:** 0 - 100°C (Thermistor)
* **Weight/Mass:** 0 - 5 kg (Loadcell)
* **Angle:** 0 - 300° (Potentiometer)
* **Speed:** 0 - 500 RPM (Encoder)

### 2. 📊 Data Logging
* **Format:** Automatically exports data to `.csv` or `.txt` files.
* **Mechanism:** Periodic data saving (Default: every 10 seconds) with timestamps.
* **Location:** Data is centrally managed in the `/data` directory.

### 3. 🎯 Calibration System
Provides a dedicated interface for the **2-point calibration** process to eliminate system errors:
* **Zero Calibration:** Sets the baseline value when there is no input (zero-point).
* **Span Calibration:** Calculates the slope based on a maximum reference point (e.g., a 5kg standard weight).
* **Algorithm:** Automatically calculates the linear equation $y = ax + b$ to update the display system.

---

## 📂 Repository Structure
The project is organized into functional modules:

```text
├── docs/                                    # Documentation, block diagrams & algorithms
├── data/                                    # Stores saved data files (.csv)
│   ├── saved_logs/                          # Actual measurement logs
│   └── sample_data.csv                      # Sample data for testing
└── src/                                     # Visual Studio source code
    ├── SensorMonitorAndCalibration.sln      # Main Solution file
    └── SensorMonitorAndCalibration/         # WinForms Project
        ├── Forms/                           # User Interfaces (UI)
        └── Modules/                         # Processing Logic (Serial, Logging, Calib)
