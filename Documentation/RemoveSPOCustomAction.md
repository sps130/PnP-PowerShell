#Remove-SPOCustomAction
Removes a custom action
##Syntax
```powershell
Remove-SPOCustomAction [-Scope <CustomActionScope>] [-Force [<SwitchParameter>]] [-Web <WebPipeBind>] -Identity <GuidPipeBind>
```


##Parameters
Parameter|Type|Required|Description
---------|----|--------|-----------
|Force|SwitchParameter|False||
|Identity|GuidPipeBind|True||
|Scope|CustomActionScope|False||
|Web|WebPipeBind|False|The web to apply the command to. Omit this parameter to use the current web.|
