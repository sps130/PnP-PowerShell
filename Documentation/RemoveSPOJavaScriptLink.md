#Remove-SPOJavaScriptLink
Removes a JavaScript link or block from a web or sitecollection
##Syntax
```powershell
Remove-SPOJavaScriptLink [-Force [<SwitchParameter>]] [-Scope <CustomActionScope>] [-Web <WebPipeBind>] -Name <String>
```


##Parameters
Parameter|Type|Required|Description
---------|----|--------|-----------
|Force|SwitchParameter|False||
|Name|String|True|Name of the Javascript link. Omit this parameter to retrieve all script links|
|Scope|CustomActionScope|False||
|Web|WebPipeBind|False|The web to apply the command to. Omit this parameter to use the current web.|
