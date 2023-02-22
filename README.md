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