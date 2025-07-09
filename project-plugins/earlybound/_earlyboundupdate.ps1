

pac auth create -n $settings["friendlyName"]
-env $settings["url"] -t $settings["tenantid"] -id $settings["applicationid"] -cs $settings["secret"]
pac auth select -n $settings["friendlyName"]
pac modelbuilder build -o $root -stf "$root\_earlyboundsettings.json"


<#
pac modelbuilder build -o "C:caminhocompleto\earlybound\_earlyboundsettings.json"
#>
