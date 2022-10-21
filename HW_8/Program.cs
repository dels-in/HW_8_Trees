using HW_8;

StartProgram:
Console.WriteLine("Введите информацию о сотрудниках. Используйте Enter вместо имени, когда закончите.");
Node root = null;
while (true)
{
    Console.Write("Имя сотрудника: ");
    var name = Console.ReadLine() ?? string.Empty;
    if (name == string.Empty)
        break;
    var salary = 0;
    Console.Write("Зарплата сотрудника: ");
    try
    {
        salary = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Введите целое числовое значение.");
    }


    if (root == null)
    {
        root = new Node
        {
            Name = name,
            Salary = salary
        };
    }
    else
    {
        AddNode(root, new Node
        {
            Name = name,
            Salary = salary
        });
    }
}

Console.WriteLine("Отсортированный список зарплат в поряжке возрастания:");
Traverse(root);
StartFinding:
Console.Write("Введите размер интересуемой зарплаты: ");
while (true)
{
    var salaryToFind = 0;
    try
    {
        salaryToFind = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Введите целое числовое значение.");
    }

    var node = FindNode(root, salaryToFind);
    Console.WriteLine(node == null ? "Такой сотрудник не найден" : $"Имя сотрудника: {node.Name}");

    var branch = 0;
    while (true)
    {
        Console.WriteLine("Введите 0 для перехода к началу программы, 1 - для повторного поиска зарплаты");
        try
        {
            branch = int.Parse(Console.ReadLine());

            break;
        }
        catch (Exception)
        {
            Console.WriteLine("Введите целое числовое значение.");
        }
    }

    switch (branch)
    {
        case 0:
            goto StartProgram;
        case 1:
            goto StartFinding;
    }

    break;
}

static Node FindNode(Node rootToFind, int salary)
{
    if (salary < rootToFind.Salary)
    {
        if (rootToFind.Left != null)
        {
            return FindNode(rootToFind.Left, salary);
        }

        return null;
    }

    if (salary > rootToFind.Salary)
    {
        if (rootToFind.Right != null)
        {
            return FindNode(rootToFind.Right, salary);
        }

        return null;
    }

    return rootToFind;
}


static void AddNode(Node root, Node toAdd)
{
    if (root.Salary < toAdd.Salary)
    {
        if (root.Left != null)
        {
            AddNode(root.Left, toAdd);
        }
        else
        {
            root.Left = toAdd;
        }
    }
    else
    {
        if (root.Right != null)
        {
            AddNode(root.Right, toAdd);
        }
        else
        {
            root.Right = toAdd;
        }
    }
}

static void Traverse(Node originNode)
{
    if (originNode.Right != null)
    {
        Traverse(originNode.Right);
    }

    Console.WriteLine(originNode.Name + ": " + originNode.Salary);

    if (originNode.Left != null)
    {
        Traverse(originNode.Left);
    }
}