# MegaDesk_2.0-CIT365-F2022-Team_Deseret
Team_Deseret MegaDesk_2.0 Repo CIT365 class


# Project Title

A brief description of what this project does and who it's for

# Requirements
- Review your naming of objects and members as a team. Use one or more of the following Microsoft resources as a guide:
    - [Naming Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)
    - [General Naming Conventions](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions?redirectedfrom=MSDN)
- Use at least one instance of a List<> class in your application.

```
  Consider using a List of enumerated desktop materials to populate a combo-box of desktop materials when adding a new quote and/or 
  for the search functionality. Initializing the desktop material combo-box list using the key-value pairs found in the enum data 
  source can be completed by first populating a variable with a List<DesktopMaterial> type. The challenge is when you GetValues from 
  the enum using Enum.GetValues, you will need cast/convert to type DesktopMaterial when running the built-in ToList() method. 
  Then this variable (let's name it materials) can be assigned to the DataSource of the combo box (let's name the combo box 
  desktopMaterialComboBox) like this:

  desktopMaterialComboBox.DataSource = materials;
```

- Add the ability for the user to SEARCH through the orders by combo-box selected surface material and display the desk quote with the customer name, quote date, desk specs, and overall price quote.
- Add the ability for the user to click to display all saved quotes using a DataGridView object.
- Read in the rush order price list from this file: [rushOrderPrices.txt](https://byui.instructure.com/courses/204340/assignments/9369045?module_item_id=25984686#:~:text=Read%20in%20the%20rush%20order%20price%20list%20from%20this%20file%3A%20rushOrderPrices.txt.).
    - Use these values from the file versus using 'magically' embedded values in the rush order quote amount logic within your DeskQuote class.
    - The order of the prices is obtuse so make sure you match this array or list of values with the specifications chart. [MegaDesk Project Description](https://byui.instructure.com/courses/204340/assignments/9369045?module_item_id=25984686#:~:text=The%20order%20of%20the%20prices%20is%20obtuse%20so%20make%20sure%20you%20match%20this%20array%20or%20list%20of%20values%20with%20the%20specifications%20chart.%20MegaDesk%20Project%20Description)
    
```
  - Create a GetRushOrder method within the DeskQuote class to handle the population of a member variable that holds a two 
    dimension array that encases the logic in a try catch block.
  - Reference: C# Programming Yellow Book Section 3.6.6 - "Reading from a File".
    Hint: Use the ReadAllLines method of the File object to read the values into a single dimension array and then use nested 
    loops to populate a two dimensional array with three rows and three columns.
  - Consider: "Where should you store the text file within the folder structure of your project?"
```

- Store the desk quotes in an appended JSON file named quotes.json
```bash
  Use the Newtonsoft JSON.NET library to aid in the serialization of the output into JSON format. You may elect to install via 
  the package manager.
  
  PM> Install-Package Newtonsoft.Json

  Hint: quotes.json should exist and then you can deserialize, add, and serialize (format the date into json format). 
  See example: (json add new object to existing json file C#).
```
[See example: (json add new object to existing json file C#).](https://stackoverflow.com/questions/33081102/json-add-new-object-to-existing-json-file-c-sharp)

- Support a solid UX with proper PARC design on the UI.
- Your team will only submit one repository and one video in which everyone is expected to participate. It is up to your team how you divide up the workload and collaborate on the project.


| Person      | Task                           |
| :---------- | :----------------------------- |
| Courtney    | Search functionality           |
| Angela      | JSON file                      |
| Parker      | Display all saved quotes       |
| Freddy      | Rush order list from text file |
