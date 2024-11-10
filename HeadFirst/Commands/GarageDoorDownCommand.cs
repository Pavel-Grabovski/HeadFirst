using HeadFirst.Commands.Models;

namespace HeadFirst.Commands;

public class GarageDoorDownCommand : ICommand
{
    private readonly GarageDoor door;

    public GarageDoorDownCommand(GarageDoor door)
    {
        this.door = door;
    }
    public void Execute()
    {
        door.Close();
    }

    public void Undo()
    {
        door.Open();
    }
}
