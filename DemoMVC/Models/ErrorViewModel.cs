namespace DemoMVC.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
//dotnet aspnet-codegenerator controller -name DaiLyController -m DaiLy -dc DemoMVC.Data.ApplicationDbcontext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite

