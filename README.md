# 🎓 Student Management System

A simple and interactive **C# Console Application** for managing student records.  
With this app, you can easily:

- ➕ Add new students
- 📋 View the full student list
- 🏆 Identify the top student based on GPA
- 🚪 Exit the program anytime with a single command

---

## 📌 Features

- **Console-based UI** – Clean and minimalistic interface to interact with users.
- **Input Validation** – Ensures user inputs are correct using a dedicated `InputHelper`.
- **Data Handling** – Uses a `Student` class and list-based storage to manage entries.
- **Top Student Finder** – Quickly finds and displays the student with the highest GPA.
- **Modular Structure** – Separated concerns across helper, logic, and main layers for better organization and reusability.

---

## 🏗️ Project Structure

```
StudentManagement/
│
├── Model/
│   └── Student.cs            # Student class (Name, GPA)
│
├── Helper/
│   └── InputHelper.cs        # Handles all input and validation logic
│
├── Logic/
│   └── StudentManager.cs     # Business logic: add, list, find top student
│
├── Program.cs                # Main program loop and menu
└── StudentManagement.csproj  # Project file
```

---

## ▶️ How to Run

Make sure you have [.NET SDK](https://dotnet.microsoft.com/download) installed.

```bash
git clone https://github.com/Motahare-KamraniFard/StudentManagement.git
cd StudentManagement
dotnet run
```

---

## 📈 Future Enhancements

- 💾 Save and load student data from a file (JSON or CSV)
- 🔍 Search students by name
- 📊 Sort students by GPA
- 🧪 Unit tests for logic and validation
- 🖼️ UI upgrade to WinForms or WPF

---

## 🤝 Contributing

Feel free to fork the project, improve it, and submit a pull request!  
If you find a bug or have a suggestion, open an issue.

---

## 📃 License

MIT License – see [LICENSE](LICENSE) for details.

---

Made with 💙 by [Motahare KamraniFard](https://github.com/Motahare-KamraniFard)
