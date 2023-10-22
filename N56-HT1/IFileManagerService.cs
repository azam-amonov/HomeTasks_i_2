namespace N56_HT1;

public interface IFileManagerService
{
    public bool CreateUserDirectory(User user);
    public bool CreateUserMediaFiles(int countOfFiles);
    public bool CreateUserDataFiles(int countOfFiles);
}