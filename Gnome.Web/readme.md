- add db-connection.json file into Gnome.Web/ root with db connection string:
```json 
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.\\SQLEXPRESS;Database=gnome-core;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```