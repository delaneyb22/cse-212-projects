/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then display "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze {
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _map;
    private int _x;
    private int _y;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> map) {
        _map = map;
        _x = 1;
        _y = 1;
    }

    public void MoveUp() {
        if (_map.TryGetValue((_x, _y - 1), out bool[] directions) && directions[0]) {
            _y--;
        }
    }

    public void MoveDown() {
        if (_map.TryGetValue((_x, _y + 1), out bool[] directions) && directions[2]) {
            _y++;
        }
    }

    public void MoveLeft() {
        if (_map.TryGetValue((_x - 1, _y), out bool[] directions) && directions[3]) {
            _x--;
        }
    }

    public void MoveRight() {
        if (_map.TryGetValue((_x + 1, _y), out bool[] directions) && directions[1]) {
            _x++;
        }
    }

    public void ShowStatus() {
        Console.WriteLine($"({_x}, {_y})");
    }
}