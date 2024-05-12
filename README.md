# Sales Taxes

API App ReadMe

Required
- Visual Studio 2022
- Target frame work net 8.0

Installed Packages 
- AutoMapper 13.0.1
- Newtonsoft.Json 13.0.3
- Swashbuckle.AspNetCore

The data is stored in a Json file located in the following folder net8.0, the path has been provided below
"SalesTaxesConsoleApp\SalesTaxesConsoleApp\bin\Debug\net8.0\Items.json"

Steps 
- Upon cloning or unzipping the application, open it in visual studio 
	- Right click on the Solution and Restore NuGet packages 
	- Rebuild the Application 
	- Run the application by clicking on the play button with the name https
- When the application runs successfully, swagger will open up in your default browser https://localhost:7096/swagger/index.html
- The swagger ui displays all the endpoints of the API along with detailed information about each endpoint and the ability to execute requests.

The Goods API includes:
- GetGoodsList (/api/Goods/GetGoodsList) this gets a list of all the goods saved in the Json file, below is the expected results
[
  {
    "id": 1,
    "itemName": "Book",
    "price": 12.49,
    "isImported": false,
    "isTaxable": false
  },
  {
    "id": 2,
    "itemName": "Music CD",
    "price": 14.99,
    "isImported": false,
    "isTaxable": true
  },
  {
    "id": 3,
    "itemName": "Chocolate Bar",
    "price": 0.85,
    "isImported": false,
    "isTaxable": false
  },
  {
    "id": 4,
    "itemName": "Box of Chocolates",
    "price": 10,
    "isImported": true,
    "isTaxable": false
  },
  {
    "id": 5,
    "itemName": "Bottle of Perfume",
    "price": 47.5,
    "isImported": true,
    "isTaxable": true
  },
  {
    "id": 6,
    "itemName": "Bottle of Perfume",
    "price": 27.99,
    "isImported": true,
    "isTaxable": true
  },
  {
    "id": 7,
    "itemName": "Bottle of Perfume",
    "price": 18.99,
    "isImported": false,
    "isTaxable": true
  },
  {
    "id": 8,
    "itemName": "Packet Paracetamol",
    "price": 9.75,
    "isImported": false,
    "isTaxable": false
  },
  {
    "id": 9,
    "itemName": "Chocolates",
    "price": 11.25,
    "isImported": true,
    "isTaxable": false
  }
]

- GetGood (/api/Goods/GetGood) Get's a single item from the Json file, takes a single input which is the Id of the item which can be found from the first call GetGoodsList, 
/api/Goods/GetGood?Id=2
expected results below 

{
  "id": 2,
  "itemName": "Music CD",
  "price": 14.99,
  "isImported": false,
  "isTaxable": true
}

Second api documentation is the Sales
- PurchaseGoods (api/Sales/PurchaseGoods) sends a list of items you want to purchase and prints out a receipt 

Data input 
[
  {
    "id": 1,
    "quantity": 1
  },
  {
    "id": 2,
    "quantity": 1
  },
  {
    "id": 3,
    "quantity": 1
  }

]'

Results

--------------------------------------------------

Sales Receipt: 

1 Book: 12.49
1 Music CD: 16.49
1 Chocolate Bar: 0.85

Sales Taxes: 1.50
Sales Total: 29.83

--------------------------------------------------
