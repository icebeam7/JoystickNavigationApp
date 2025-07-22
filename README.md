# 🕹️ Joystick Navigation UI in .NET MAUI

This project demonstrates how to create a **gesture-driven joystick-style navigation system** in [.NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/), allowing users to navigate between pages by dragging a floating virtual joystick in different directions.

> 🎮 Inspired by game UIs.

---

## 🚀 Features

- 🕹️ Joystick UI control
- 🎯 Direction detection via drag gestures (up, down, left, right)
- ✨ Works on Android, iOS, and Windows
- 🧭 Page navigation triggered by joystick direction

---

## 📸 Demo
https://github.com/user-attachments/assets/12067677-8ded-4fe6-9156-c8aa850d9e90

---


## 💻 How It Works

1. A reusable `JoystickControl` view tracks drag gestures.
2. When released, it calculates the drag vector's direction.
3. Direction triggers:
    - Navigation to the corresponding page
4. Joystick resets to center.

---

## 🧑‍ Blog Post
https://dev.to/icebeam7/joystick-navigation-ui-in-net-maui
