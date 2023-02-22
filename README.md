#Итоговая проверочная работа

---

Для начала создаём массив входных значений размером 100 и заполняем его нулевыми значениями.

```cs 
string[] mass = new string[100];
for (int c = 0; c < 100; c++)
{
    mass[c] = "0";
}
```
---
Затем вводим данные в массив.
```cs
int j = 0;
while (j < 100)
{
    Console.Write("Введите текст или 0 для завершения:");
    string? s = Console.ReadLine();
    while (s == null)
    {
        s = Console.ReadLine();
    }
    try
    {
        if (Convert.ToInt32(s) == 0)
        {
            break;
        }
        mass[j] = s;
    }
    catch
    {
        mass[j] = s;
    }
    j++;
}
```
---
Далее считаем количество строк длиной 3 или меньше, чтобы определить длину выходного массива.
```cs
int NewMassLen = 0;

for (int i = 0; i < mass.Length; i++)
{
    if (StringLen(mass[i]) <= 3 && mass[i] != "0")
    {
        NewMassLen++;
    }
}
```
Функция для определения длины строки выглядит следующим образом:
```cs
int StringLen(string text)
{
    int m = 0;
    foreach (char n in text)
    {
        m++;
    }
    return m;
}
```
---
После этого инициализируем выходной массив и добавляем в него строки длиной 3 или меньше.
```cs
string[] NewMass = new string[NewMassLen];
int n = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (StringLen(mass[i]) <= 3 && mass[i] != "0")
    {
        NewMass[n] = mass[i];
        n++;
    }
}
```
---