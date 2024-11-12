# ToDo List Application

A ToDo List application built with **React** for the frontend and a **.NET Core Web API** for the backend. This application allows users to create multiple lists, add tasks to each list, move tasks between lists, and update or delete tasks. Tasks have due dates and are highlighted based on their urgency.

## Table of Contents

1. [Features](#features)
2. [Tech Stack](#tech-stack)

## Features

- Create and manage multiple to-do lists.
- Add tasks with titles, descriptions, and due dates.
- Move tasks between lists.
- Highlight tasks based on how close they are to the due date:
  - **Red** for tasks due within 2 days.
  - **Yellow** for tasks due within 4 days.
  - **Green** for tasks due within 7 days.
- Edit and update tasks as needed.
- Delete tasks when completed.

## Tech Stack

**Frontend**:  
- [React](https://reactjs.org/) - JavaScript library for building user interfaces.
- [React Bootstrap](https://react-bootstrap.github.io/) - Bootstrap components for React, providing UI components.

**Backend**:  
- [.NET Core](https://dotnet.microsoft.com/) - Cross-platform framework for building APIs.
- [ASP.NET Core Web API](https://docs.microsoft.com/en-us/aspnet/core/) - Framework for creating RESTful APIs.
- **C#** - Primary language used in the backend for API development.

**Database**:  
- JSON file (for data persistence in this example).
