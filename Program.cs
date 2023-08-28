string[] GetNewMas(string[] mas){
    int sizenewmas = 0;
    foreach (string t in mas){
        if (t.Length <= 3) sizenewmas++;
    }
    string[] newmas = new string[sizenewmas];
    int i = 0;
    foreach (string t in mas){
        if (t.Length <= 3){
            newmas[i] = t;
            i++;
        }
    }
    return newmas;
}

void ShowMas(string[] mas){
    Console.Write("[");
    for (int i = 0; i < mas.Length-1; i++){
        Console.Write($"\"{mas[i]}\", ");
    }
    Console.Write($"\"{mas[mas.Length-1]}\"]");
}

string[] GetStrings(int size){
    string[] mas = new string[size];
    string txt = "";
    for (int i = 0; i < size; i++){
        Console.WriteLine("Введите строку: ");
        mas[i] = txt + Console.ReadLine();
    }
    return mas;
}

int GetInput(string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInput("Введите количество строк: ");
string[] mas = GetStrings(size);
string[] newmas = GetNewMas(mas);
ShowMas(mas);
Console.Write(" -> ");
ShowMas(newmas);