Pseudocode:
----------
```
-web app for factory manager to track machine repairs
-many to many between engineers and machines
-use data validation, user should see an error if a field is left blank or wrong data type is used when adding a new engineer or machine to the lists
-should be able to add new machines if no engineers are listed, and vice versa
-be able to remove machines that a specific engineer is licensed to repair (eng details view)
-splash page that lists all engineers and machines

Engineer:
-EngineerId
-EngineerName
-(further exploration can add idle/working boolean)

Machine:
-MachineId
-MachineName
-Description
-(further exploration can add operational/malfunctioning boolean)

EngineerMachine:
-EngineerMachineId
-EngineerId
-MachineId
```