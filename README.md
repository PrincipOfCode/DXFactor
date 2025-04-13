# DXFactory 🏭
**Batch DXF Filename Editor for Industrial Scaling**

DXFactory is a smart utility tool for batch-renaming DXF files based on customizable parameters embedded in their filenames.  
Originally designed to help PPC teams scale up technical recipes,  
it allows engineers and production managers to automatically update filename parameters across entire folders —  
saving time, ensuring consistency, and preventing manual errors.

---

## ✨ Features

- 🔄 Batch rename all `.dxf` files in a folder
- 🧠 Identify and edit embedded parameters (e.g., materials, quantities)
- 📏 Scale recipe values for increased production
- 🎯 Designed specifically for PPC and production engineers
- 💬 Preview new names before applying changes
- ⚙️ Support for custom renaming logic
- 🧪 Regex pattern matching (optional, advanced mode)
- ✅ Easy to use – graphical interface or command-line

---

## ⚙️ How It Works

DXFactory scans a selected folder for DXF files.  
It parses parameters from filenames (e.g., `Product_QTY2_THI2_MAT2B.dxf`) and allows users to update them based on scaling logic (e.g., change `QTY2` to `QTY10`).

Users can define:
- Which parameters to update
- The scaling factor or target values
- Rename preview before confirming changes

This tool was built to support production environments,  
especially in companies where DXF files are generated automatically and filenames carry essential production data.

---

## 🛠️ Installation

___

## ▶️ Usage

1. Run the app 
2. Select source folder
3. select target folder
4. Choose scaling options
5. Preview & apply changes

___

## 🧪 Example

Before:
	`TableTopSurface_QTY1_THI1_MATP4.dxf`
	`TableLeg_QTY4_THI2_MATP4.dxf`

After (with scale factor ×5):
	`TableTopSurface_QTY5_THI1_MATP4.dxf`
	`TableLeg_QTY20_THI2_MATP4.dxf`