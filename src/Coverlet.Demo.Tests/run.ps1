$diretorio_local = Get-Location;
$diretorio_cobertura = (Join-Path  $diretorio_local "cobertura");

dotnet restore 
dotnet build 

If (!(test-path $diretorio_cobertura)) {
    New-Item -Path $diretorio_cobertura -ItemType Directory
}	

dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=$diretorio_cobertura\cobertura.xml
reportgenerator -reports:$diretorio_cobertura\cobertura.xml -targetdir:$diretorio_cobertura
