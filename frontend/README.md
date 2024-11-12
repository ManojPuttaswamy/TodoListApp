# Assignment5
Your React, front end code should go here



https://github.com/bodonnell-DePaul/Assignment5-FE/assets/5862378/94e927bb-1a61-4838-9095-9a3c85f4d13d


## Requirements  
1. When opening your application a user will see several Todo items and Todo lists that are loaded from an external API.  
2. The user can edit the ITEMS in the list and submit them back to the API where they are saved.  
3. The user can create new ITEMS in the list and submit them back to the API where they are saved.
4. If I terminate the backend application and reboot it the new and/or edited items should be persisted.
   
## Instructions

## Backend code
1. Refactor your API so that the list of todoItems is read from the `todoitems.json` JSON file in this repo, instead of the static list in Assignment 4
2. The entire JSON file should be read in along with all of the item details
3. Modify your POST method to serialize new items to a file.
4. When a new todo items is posted it is serialized and written to `todoitems.json` as a JSON object.
5. The written object will now be persisted, so next time you run the backend API the new todo item will be loaded and sent to the front end
6. Create a PUT method to modify items already in your list.  This will require a couple things:
   - Modify your `TodoItem class` to have a unique id field.  This will allow you to match up the edited item on the front end with the back end
   - You must only write the newly edited item to the `todoitems.json` file
  
## Frontend code
1. Add a POST method to your frontend.  The POST method will add new items to your todo list.  If the new item is part of a new list then it should be reflected on the UI.
2. Add a PUT method to your frontend.  The PUT method will allow you to edit current items on your todo list and sync them back to the server.
   - In order to do this you will have to make the todo item into a form so and apply changes.  This will allow you to integrate a PUT method into   the edits


## Documentation:
- [ASP.NET Core documentation](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0)
- [Create Minimal APIs](https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-8.0&tabs=visual-studio)
- [Minimal API Overview](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/overview?view=aspnetcore-8.0)
- [JavaScript Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch)
