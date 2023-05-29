// Инициализировал переменную, хранящую позицию курсора
int cursorPosition = 0;
// Сделал курсор невидимым;
Console.CursorVisible = false;
// Отрисовал впервые интерфейс
Draw();

int a = 1, b;

b = a == 1 ? 1 : 0;

while (true)
{
    // Попросил пользователя нажать клавишу и сохранил ее в переменную
    ConsoleKey key = Console.ReadKey(true).Key;

    // Меняю позицию курсора в зависимости от нажатой пользователем клавиши
    cursorPosition = key == ConsoleKey.UpArrow ? key == ConsoleKey.DownArrow ? cursorPosition : cursorPosition - 1 : cursorPosition + 1;

    Draw();
}

// Отрисовать интерфейс
void Draw()
{
    Console.Clear();

    // Задал количество вариантов ответов
    int answersCount = 9;

    // Выставил рамки для курсора
    if (cursorPosition >= answersCount) cursorPosition = answersCount - 1;
    else if (cursorPosition < 0) cursorPosition = 0;
    
    // Сам процесс отрисовки
    for (int i = 0; i < answersCount; i++)
    {
        if (cursorPosition == i) Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Строка #{i+1}");
        Console.ResetColor();
    }   
}