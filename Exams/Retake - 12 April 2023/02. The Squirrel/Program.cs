int sizeOfTheMatrix = int.Parse(Console.ReadLine());
string[] commands = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
char[,] matrix = ReadMatrixFromConsole(sizeOfTheMatrix, sizeOfTheMatrix);
int squirrelPositionRow = 0;
int squirrelPositionCol = 0;
for (int row = 0; row < sizeOfTheMatrix; row++)
{
    for (int col = 0; col < sizeOfTheMatrix; col++)
    {
        if (matrix[row, col] == 's')
        {
            squirrelPositionRow = row;
            squirrelPositionCol = col;
        }
    }
}

int collectedHazelNut = 0;
for (int i = 0; i < commands.Length; i++)
{
    string currCommand = commands[i];
    if (currCommand == "up")
    {
        if (squirrelPositionRow -1 >= 0)
        {
            if (matrix[squirrelPositionRow-1,squirrelPositionCol] == 't')
            {
                Console.WriteLine($"Unfortunately, the squirrel stepped on a trap...");
                Console.WriteLine($"Hazelnuts collected: {collectedHazelNut}");
                return;
            }
            else if (matrix[squirrelPositionRow - 1, squirrelPositionCol] == 'h')
            {
                collectedHazelNut++;
                if (collectedHazelNut ==3)
                {
                    Console.WriteLine($"Good job! You have collected all hazelnuts!");
                    Console.WriteLine($"Hazelnuts collected: {collectedHazelNut}");
                    return;
                }
            }
            squirrelPositionRow--;
            matrix[squirrelPositionRow, squirrelPositionCol] = '*';
        }
        else if (squirrelPositionRow - 1 < 0)
        {
            Console.WriteLine($"The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {collectedHazelNut}");
            return;
        }

        
    }
    else if (currCommand == "down")
    {
        if (squirrelPositionRow + 1 <= sizeOfTheMatrix-1)
        {
            if (matrix[squirrelPositionRow + 1, squirrelPositionCol] == 't')
            {
                Console.WriteLine($"Unfortunately, the squirrel stepped on a trap...");
                Console.WriteLine($"Hazelnuts collected: {collectedHazelNut}");
                return;
            }
            else if (matrix[squirrelPositionRow + 1, squirrelPositionCol] == 'h')
            {
                collectedHazelNut++;
                if (collectedHazelNut == 3)
                {
                    Console.WriteLine($"Good job! You have collected all hazelnuts!");
                    Console.WriteLine($"Hazelnuts collected: {collectedHazelNut}");
                    return;
                }
            }

            squirrelPositionRow++;
            matrix[squirrelPositionRow, squirrelPositionCol] = '*';
        }
        else if (squirrelPositionRow + 1 >= sizeOfTheMatrix)
        {
            Console.WriteLine($"The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {collectedHazelNut}");
            return;
        }

    }
    else if (currCommand == "left")
    {
        if (squirrelPositionCol - 1 >= 0)
        {
            if (matrix[squirrelPositionRow, squirrelPositionCol-1] == 't')
            {
                Console.WriteLine($"Unfortunately, the squirrel stepped on a trap...");
                Console.WriteLine($"Hazelnuts collected: {collectedHazelNut}");
                return;
            }
            else if (matrix[squirrelPositionRow, squirrelPositionCol-1] == 'h')
            {
                collectedHazelNut++;
                if (collectedHazelNut == 3)
                {
                    Console.WriteLine($"Good job! You have collected all hazelnuts!");
                    Console.WriteLine($"Hazelnuts collected: {collectedHazelNut}");
                    return;
                }
            }

            squirrelPositionCol--;
            matrix[squirrelPositionRow, squirrelPositionCol] = '*';
        }
        else if (squirrelPositionCol - 1 < 0)
        {
            Console.WriteLine($"The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {collectedHazelNut}");
            return;
        }

    }
    else if (currCommand == "right")
    {
        if (squirrelPositionCol + 1 <= sizeOfTheMatrix-1)
        {
            if (matrix[squirrelPositionRow, squirrelPositionCol + 1] == 't')
            {
                Console.WriteLine($"Unfortunately, the squirrel stepped on a trap...");
                Console.WriteLine($"Hazelnuts collected: {collectedHazelNut}");
                return;
            }
            else if (matrix[squirrelPositionRow, squirrelPositionCol + 1] == 'h')
            {
                collectedHazelNut++;
                if (collectedHazelNut == 3)
                {
                    Console.WriteLine($"Good job! You have collected all hazelnuts!");
                    Console.WriteLine($"Hazelnuts collected: {collectedHazelNut}");
                    return;
                }
            }

            squirrelPositionCol++;
            matrix[squirrelPositionRow, squirrelPositionCol] = '*';
        }
        else if (squirrelPositionCol + 1 >= sizeOfTheMatrix)
        {
            Console.WriteLine($"The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {collectedHazelNut}");
            return;
        }

    }

}

if (collectedHazelNut < 3)
{
    Console.WriteLine($"There are more hazelnuts to collect.");
    Console.WriteLine($"Hazelnuts collected: {collectedHazelNut}");
}



static char[,] ReadMatrixFromConsole(int rows, int cols)
{
    char[,] matrix = new char[rows, cols];
    for (int row = 0; row < rows; row++)
    {
        char[] newElements = Console.ReadLine().ToArray();
        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = newElements[col];
        }
    }

    return matrix;
}
         
