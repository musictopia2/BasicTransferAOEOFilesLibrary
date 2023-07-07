namespace BasicTransferAOEOFilesLibrary;
public interface IBarSource
{
    Task CreateBarFileAsync(string barName);
}