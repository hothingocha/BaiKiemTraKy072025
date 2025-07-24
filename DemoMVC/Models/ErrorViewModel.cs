namespace DemoMVC.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
//dotnet aspnet-codegenerator controller -name StudentController -m Student -dc DemoMVC.Data.ApplicationDbcontext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite

