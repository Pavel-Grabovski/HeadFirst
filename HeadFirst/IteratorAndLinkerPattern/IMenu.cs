namespace HeadFirst.IteratorAndLinkerPattern;

public interface IMenu
{
    IEnumerator<MenuItem> CreateEnumerator();
}