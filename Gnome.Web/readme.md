- add db-connection.json file into Gnome.Web/ root
- copy & paste, modify connection string / credentials  to suit your needs
```json 
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.\\SQLEXPRESS;Database=gnome-core;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "SystemCredentials": {
    "SysUploader": {
      "UserName": "sys-uploader",
      "Password": "tajneHeslo"
    }
  }
}
```