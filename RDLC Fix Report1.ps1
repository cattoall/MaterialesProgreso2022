$path = "$PSScriptRoot\Report1.rdl"

$file = (Get-Content $path) 

# Unwraps the Body and the Page element. 
# Simple string replacement
$file = $file -replace '<ReportSections>',""
$file = $file -replace '<ReportSection>',""
$file = $file -replace '</ReportSection>',""
$file = $file -replace '</ReportSections>',""

# Parse the XML doc
$xml = [xml]$file;

# Set the XML namespace
$xml.Report.xmlns = "http://schemas.microsoft.com/sqlserver/reporting/2008/01/reportdefinition";

# Delete ReportParametersLayout node    
$xml.Report.RemoveChild($xml.Report.ReportParametersLayout);

# Save the file
Set-Content -Value $xml.OuterXml -Path "Report1.rdl"