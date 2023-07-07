namespace BasicTransferAOEOFilesLibrary;
public static class Utilities
{
    public static string GamesPath => @$"{ll1.NewGamePath}\GameFiles";
    private static async Task CopyOriginalFilesAsync()
    {
        Console.WriteLine("Delete Old Files");
        await ff1.DeleteFolderAsync(GamesPath);
        Console.WriteLine("Copying Original Files");
        await ff1.CopyFolderAsync(ll1.OriginalAOEOPath, GamesPath);
    }
    public static async Task ExtractFilesAsync(IBarSource source)
    {
        await CopyOriginalFilesAsync(); //already shows the console progress.
        await source.CreateBarFileAsync("rm");
        await source.CreateBarFileAsync("data");
        await source.CreateBarFileAsync("ai");
        await source.CreateBarFileAsync("art");
        await source.CreateBarFileAsync("render");
        await source.CreateBarFileAsync("Scenario");
    }
}