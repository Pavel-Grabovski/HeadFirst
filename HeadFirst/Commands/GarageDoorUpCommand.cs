using HeadFirst.Commands.Models;

namespace HeadFirst.Commands;

public class GarageDoorUpCommand : ICommand
{
    private readonly GarageDoor door;

    public GarageDoorUpCommand(GarageDoor door)
    {
        this.door = door;
    }

    public void Execute()
    {
        door.Open();
    }
}
