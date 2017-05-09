- add db-connection.json file into Gnome.Web/ root
- copy & paste, modify connection string to suit your environment
```json 
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.\\SQLEXPRESS;Database=gnome-core;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```