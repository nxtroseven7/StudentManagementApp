# Student Management App

A lightweight desktop application built with C# and Windows Forms for managing student records. Instead of relying on a heavy database server, this app reads and writes directly to a local comma-delimited text file (`data.txt`), keeping data storage simple, portable, and easy to inspect.

## Features

- **View Students**: Displays all stored student records in a clean `DataGridView` on the main screen (`Form1`).
- **Add New Students**: Opens a dedicated form (`FormInsert`) to append new student entries to the data file.
- **Edit Existing Records**: Select any row in the grid to open `StudentModify`, pre-filled with that student's details, and overwrite their record in the file.
- **Delete Records**: Remove selected students from the grid and text file with a confirmation prompt to prevent accidental deletions.
- **Input Validation**: Enforces strict `dd/MM/yyyy` date formatting before saving changes to keep the data file consistent.

## Data Structure

All records are stored in `data.txt` as comma-separated values in the following order:

```text
StudentID,FirstName,LastName,BirthDate,Address,Email