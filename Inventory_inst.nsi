!include MUI2.nsh
Name "Fusion Inventory"
OutFile "Fusion_Inventory_Installer.exe"
installdir "C:\Fusion Inventory"
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_COMPONENTS
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_LANGUAGE "English"

Section "Program Files"
	SetOutPath $INSTDIR
	File bin\Fusion_Inventory.exe
	File bin\Fusion_Inventory.exe.config
	File bin\MySql.Data.dll
	File bin\BouncyCastle.Crypto.dll
	File bin\Fusion_Inventory.pdb
	File bin\Google.Protobuf.dll
	File bin\Microsoft.Office.Interop.Excel.dll
	File bin\Renci.SshNet.dll
	CreateShortCut "$DESKTOP\Fusion_Inventory.lnk"  "$INSTDIR\Fusion_Inventory.exe"
SectionEnd

Section "MariaDB (10.4.8)"
	SetOutPath $INSTDIR\Dependencies
	File setup\mariadb-10.4.8-winx64.msi
	ExecWait 'msiexec /i "mariadb-10.4.8-winx64.msi" /qn installdir="$INSTDIR\MariaDB" password=princess servicename=MariaDB'
SectionEnd

Section "Import New Database"
	SetOutPath $INSTDIR
	File setup\inv_blank.sql
	File setup\blank_db_import.bat
	ExecWait blank_db_import.bat
	Delete blank_db_import.bat
SectionEnd

Section ".NET Framework (4.8)"
	SetOutPath $INSTDIR\Dependencies
	File setup\ndp48-x86-x64-allos-enu.exe
	ExecWait "ndp48-x86-x64-allos-enu.exe"
SectionEnd