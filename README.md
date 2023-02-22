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
Выводим получившиеся значения.

```cs
foreach (string o in NewMass)
{
    Console.WriteLine(o);
}
```
---
Результат работы программы.

<img src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAakAAACCCAYAAAD8MDcaAAAABHNCSVQICAgIfAhkiAAAABl0RVh0U29mdHdhcmUAZ25vbWUtc2NyZWVuc2hvdO8Dvz4AAAAuaVRYdENyZWF0aW9uIFRpbWUAAAAAANCh0YAgMjIg0YTQtdCyIDIwMjMgMTk6MDg6MTTCOdMxAAAdvklEQVR4nO2dP2wiWZvuH+9eLTUrXZmRdmUmWbjBlfmklWAiM8EKRloJvggmgolgIphgZCYynZFBR6Yj6AgcQUemNwFH4Ag6AiJwVNXBJ+iomJtUOTo3AAzY/Ckb3GD382u9UruKes+pt06dQxXnvA8ACNojLAUBFWLuX/Erla2Ny9t1DPa1/s/p/1+84j9/Ohf2fztcuN/+ixB//FET//ef57f/x3+r4o8/uuKn7zcv3/FfeeENqeKPP4QIe7y7v55bjN9emSkoipXT3deDJgCIg/F/yGM5ASAB6AH48pXK1MZlHnyl8rbNc9d/h/H513/z4nvTEP/4x6e57f/yvRf//q86/vGP680K+N8phCIJ/Dt0/L/PGVz8z5vN/BHyQuAgRQghZG/5p11XgBBCCFkGBylCCCF7y/YGKZMbWVlAiIlpUOUa8lHH1oogrx9vqoKuqkFoKuRaFsFj066rRPYB6ykaQkMlPNMejrzItjSojRTch4/wo8nIutmuXgpbf5IalCJwOZ1wugKIlyUEcmU2CGIIa7SGUtyGdtwHpyeGqjmEQim562qRfeTQjfNqCSFkEPC9wfVfu64QeU62NG3TLbKyEHLWPd12GBYVTYjGqVUAEP5iX9yhqUJuZEXweN6P9+xStPqa0IQmVLkmssHju30mb17MeBjRzwuvabQ/XNGEWvTffd4arQlVyCJ7YhIAhCPVvX+0EKImTo+Mlb/ONvV/dNoQ2sz5WINFIauyKAat0xg4wiJb64q+JoSm9UW3No2hkfJX2br4mdxZIT/wP92/7vh1lmoJoV4Gp+fqzgpZyCLrNnb8uvaxrv4ARDBbE7KqTXc3jE9FPjmriG5fFZo2at/91qVIeY+m8Qiei0pLFqqmjdt/UZyeTKdkb3p/RGua6NfyIt+QRV9VhSrXxLl/XL4jJbpaRYRNEIfRmtC6qZG/fF/0Z67ZKv/3ry+sZ6KhPe76G42v1Xo0v816KhpCE5WwSeDQLVINVaitc+E+hLH4HqdEa8HdIURDnFq3c//Tnsee9TcpRygEp6Sg3R7cbdPrcRwcHMDiDKFqjiCX9N/tO0m1UI6bUY374LK7EMoM4SuUkTqZeRLT64jbzDg4OIA93oS+rPCjINJJD8wzmzpv/jYqO1aHPiwjZDHj4OBnvPvyiPJXsE3/1mAR9ZwLzZgHv374PN4YRqlaQABlxD12OF0hJJsSbBaTofIfxYL4AQD0JhL2UfzNzgTayy7AsuOXcRiG0w706s27TbfNOtq6DU6nxXi917WPFfU/ilZQiJhRDtlxcHAAX0FZ3r4WMGiXkI4F4PE44fJFkFGciJdyCI4vr9ksQSkkEPI4YXcFkOw5kS7n4J95VbXZ/SHB4nEBSRd++P57eDJApFBC1Gqs/pu2/zkWXH+j8Q1XNChKGaeL6i25cFYuIy6VEPL9OfcEtTK+N2/w48EBDmxxNHUFOY+Eg4MDHBz8hHefn+H8ydb4X9t2aIvVIWLjP/QBqokAfr++nfnEqFl+ubmCMgSG+nC02eRHPGZDPW7Hmw+jXrVz8wsyIQ3xkBNvPk3Xn+jDUcsc6su7EHcyiYCuYLBg3+g4/c7PY8tfx2b+JdhCReQy9wYoAI5YHD6UEAq8wce/AOAGN52H628Wlv9IVsVP10d+/xpiaSe+6viFmM0wSzqGwyHc2S7KvjYirgKGQ8BuswD4vNbFXf3WtI9l9bfZbUCvgD+vPo8/Z7hIAMDnqwtc3P3Vge5KIOGZ7u+8/x2/3/11g5tkDrFQHD6nCR/v7pEN749mDr9djffn0ignyogErHhfX1P5LbZ/YPH13zS+gARXugyf2QylUMXVvS9fxuK7hC2fP9kez/iblA+hTBv2ZAFZ7/SrouTJQFVVaJpA0lZHOj3uZO0u2M1m+AqDmckXAhmXBLNl/E1akgDoaxu3yXGGdAgoJEpQjN4IRsrfBIP+JUsAmVwINgzQ7s138Xa7HejVxwPU87E8fqP4r3u8eFL8J+iArgwwGAwe9RQzqt669rG6/kpvANg8iG4wWcPkzqKrqlA1gWZcRy4Uw4dx/2hyRJGvddHXxtdfycAlSaNqT2q4yf0BHQNFmTq7vUJvANic9vUVN+RfgjlUgqqqI+sl4ZIeulp2/Y3G9+Lv38094cwiDcqIxMqQIjkU/Uf3yl0f383On+yCrQ9S+lDBp04HnU9X+PDm70g3bYjEA9P9zSQ8LhecTg+SPRcyhbOZg2cfw6f2/a8fR/slCWZdX9N5WRBJJ2CrJpFsDh9Z+TXlb4oR/7qCUsiDeM+OZCH5wIWR+20zVsRPGnfzKy/AE+M/HGKoSzBbJHx6+zP+9tOfuBqaYTYDQ8Xg89i69rGm/l/e/4xY1YZMbwhNVVGN2B4d79vr3+FxOuHy+BCvWxDJJOE9BGByI1POwKfnEBq/bjywxFG/V5eN7g88bB/mx5zBWv86huU4XC7XyHy5Ba97l1//zeOro56O4eL9L4iXgVAuh+BknDIY383On+yCZ18npeuAZJ55M60P0bm5wc3NNQqlNiSnB2ETgF4TPd0Cl8u21JdkNgP6EKu6PsmVQNLVRjLx4XHZigyUvxEG/evDJkrVa7yLJNG0xdFKnUxd9HrQ7Z653zC2zar4SRYLzPoAgxU3/pPj/9cF2j3A7vHcbTK5PA9+01xZ9zXtw0j961UFQ6WMmMeFSPkJT3MAvnz+jJtPV3gfy6BnCyDiMQEWJ5yWAcrpHK4/jx6FTXYnbPd76Q3uD0CC2e6a/nkYhN2mQ2n31lfaaPvXB7i5uRmZ8jA+666/kfgeHh3j+Hj1D2kfYnGUEUAmFx5tMBxfAFjwdPXc9z95MlsfpCSzDScOBxwnbvhPi0h45n8Mn3zXO7S6EY84AaWHi1sAtx+RyfVgT5aQj3rhOD7GiTeIs3wF5/7R6wGXywZpOIQujXppsyRh1OCmPxxLNgsGuTjeG/8JY4SB8jfisf5v3iGWaMIWL+B8PIW/k8ugigBypRT8J8c4Pj6B//Qcp1ub4r88fqajE8QiLqBdx8elr/c3iD+AXK4O+JIoht1wnASRTodgaZfu/aa5nFXtw1D9D/1Ip51oJuO46NxgMHzcEOWPRhH0ukft3+3HWSEOFxQ0e7fAQIEytMDlc44+fORGMh2A7YGXp98fAABnBLUzLxzHJwhnkvChiUL5851vyXwIszT6/8nh0bSz3kr7X3P9DcY3UGij1ystnjgx4csHxOJlIJBBJWw1Ht+hAmVohivgmd/+3Pc/2YjtTBUcT0GfmUMr1H5LVM6nU4rnptgKTfS7l+LMPZ8V2Xt2KVqyKkazeGXRqmRF2AFhCl4KdeEU0uk01nBFCCHnhXcyLfXeFNmJmcIVoalF4Tc9PI9l5T8mFk/1f38KOgARrahCk7N35zQ7BV1oqpBrD6cpryp/la2KX6qlCVWuiFPHTCwfTEE2Fv9V5k1VRFfVZs7N4PTzNe3DSP29WVmotejdfndWFtojpqCHiy0hq5rQ7qaQF8WZd7p84Mh/LmqyKlS1L+RuQ+RPz0VD64u817Tx/QGMp6BfnotsTRaaEOMp6OPyHSmxaIGCEOLhFPQl/tdPQV99/Y3GN1zRHkwNn5uCPvPZ4GVfCLUmosfr4zux43BRtPqTafALpqBveP/Ttm47r4AhMwUvhdo4e7g9XBFqjWn1v3Vj+xgPUvkXJuFBo60x5u4jhBCyt1Cqg5BXQrSmIakE8MNvV7uuCiFbg4MUIYSQvYWv+wghhOwtHKQIIYTsLdSTInsF9aSIEbx5GUIINGYWU/mL/bmURkII9Iv+FV7IS2DrCWYHpQgC6TZ0yQJnKIlMrgy9Zze8IJN8u4z0pCyoxnwI9SyI5XIolIb48OObXVeN7BFH/iIyziF6C9YC6800fPHyNJPFwEC2DbL3bGc+O/WkqCdFPSnqST2XntTEjoKiKLdEyh0WlzN9yyR+WiX89D6MtpdGPSnqSRmOHwDqSa2AelIzPJOeVDiXhr0cQ7K5+MpIngxUTYOmymhdpuA9Wvgx8oKgntQE6knNQT0p6kntm56UNVpB2l7GD798Aky2B/uVagGJahNNZQizPYREMoFyFfiOr4tfNNSTmkA9qTuoJ0U9qcX+d6gndXyKQtKGUiyx9LjOxRu8vfiI6+trfHz/++i3KWcI2a0lYCa7gHpSc5WnnhT1pKgntY96UianBy6LHfG6PhpA9RICEuDKKNAaZwuP+avdhAILqFn4sqGe1ATqSQGgnhT1pFb5x870pG4//DJ6QzMxVwJ1HWhnfHBFCguremh3woIBBobfOZN9hHpSE6gnBepJUU9qn/WkOp3O1NoKhgB0pYfOzRfA5Mf5ZRZnYT+8bjf80XOUcyGY2zkuf3kFbGeqIPWkNvZPPSnqST31/gBeuZ7Ug/4mOD8F3eQWqVpX9MfT2zVVFo3LM+E1uPyCtte28woYMuoF0VYZ2wf1pGiv05i7jxBCyN5CqQ5CXgnUkyKvEQ5ShBBC9ha+7iOEELK3cJAihHxTmIKXULXLu5yKZES0pu2ltAn1pMheQT0pspQjN86KDciqNu5fWqhkw4/3o9RRLdfv0lU9CuspGpq8MNVSuKLN93/9FiqpR3b6K/x/qzxj7r4A4mUJgVyZASeGGOlJ2dCO++D0xFA1h1AoJXddLbInREtlJJ0D5CI+uFw+RJIlDCx2PLZ7uf30Dr/++u55KtnOwDfOXRorDOFMlNA64xf1TdnOfHbqSVFPinpS1JN6Lj2pw7CoaJqohA8Xft5IfE3+4nTBt3YpgvcWu4crmlArKZGqjBYFa2pLFMPj8z9OidaCu2t20XF41NnN+TxtzJ/j0vga8G+kfxotkE6J4PhzQmii30hNzzHfGMdfE6rcEpWzk7n2o1bOxXltFENVroms3zofn0XXf+b+XFn+oVucXXaFqgmh9Rsin8qLrtYSqTXJEqgnRT0pw/EDQD2pFVBPaoZt60npowTEs7kd77Muvrcff8X3BweQQuWl+R3NngDMOR9++P47eApAIJOE3wTg5g1+PDjAgS2Opj6biPdetvZ76LqOSe6plfE14N/o9ZHsMSQ9dcRdFkgWJyK50T1ljdaQCwClkAs2mxO+eA7t4WzySAlmXwjOagwepwexqhmRUgmnx8vPbxHLyvfnSki7FCQDTjhDBUiBEOwGMgxTT2oC9aTmoJ4U9aT2Sk/q9iOS8RLKuTK0gIJ2s4lmtYQ/300zwBuL72r0Zga/fxzV71Ohil4sAI8d+Nh5RF3HOIJ5xF0SlEJz8/g+6vgm0pF3uP4CAH/h6uIGAGCxW4BhHdV6B59vgc+fb/Cg1HYBP78drbPrxJMIBEqIBI7x7u3NI858QfmHQUQCZtQTMby7+gygg3g6gEBh/RdQ6klNoJ7UHdSTop7UYv871JMCcHPxK/723QEC8QzqAzM8iRI0OQ//0aTc9fFdhz6bMn04hA4JkvkR7cGVuYtduxSCVE8gkrjevH95xPG6UsfFgrcn7UIBbXMM1V4LlWIWqaj3/tlj2JtJBn77EW0FsBhpP+vKtzlhwwC9mbdqw15vpSLBBOpJzVWeelLUk6Ke1D7qSc1ydfEOb377O350xlA3h5AIWQ3H99lpZ+BzueBy2nFw8B3+z9/f4nrypXLT/sXo8Usa+G3nLX76/gCBZAE93Y5Augq1dvr0c11az+0GnXpSE6gnBYB6UtSTWuUfO9OTWshQgTKUYLaYjcd3U3RgJP+ybL+Cq0+f8Klz7/WY4fgu8b/F/unq4h3+/O1nuGJlwBVA9K4/udd+TH44bcBg3H5GP69NK2ay2WAxGl+lDUW3wO6cjgVmu93Q8dSTmkA9KVBPinpSe6snZfIi26ghfxaG330Cx4kf0VwGIZuCerX3iPhuyFCBMjTDFfA87jij8V3mfwvX5ySaxfmpHyfHVliP3YiEnDAPeujNXgZnBJVx+wlmkgiYmyiURwNuu9kDXCEEx9clFH9EfP/6gEJ1CFc8h1P3MY5PwsgkPIafpA1PsV1p1JPa2D/1pKgn9dT7A3j9elL+80vR6PbFaAa7JvrdmsiGHYbjm1o8x1t0U47V53dvCcRxuDieXi3EuinoT+lflvk3cvyqNnsczk/jN26f0Zkp+rNT0CftZ3YKOg7dIlWThaapoi83RP4sK1oLp6AvicGyKejHy+M1tsd1ZLsy6gXRVhnbB/WkaC/LTN686GsVET1c/bmtT0EnhBBC7mM6CSJmG6Bab2MgOZFIBCDV43hvYLbyzkdUGo22ufFJirbPZnKnRE3ujzOy9EW3khJeA9lwqCdFCCFkb6FUByGEkL2FgxQhhJC9hXpSZK+gnhQxgjcvQwiBxsxiKn+xP5cySAjxQMTv2H+OSrcPTRPQVBmtfHC04+gUtXvHTvqxSvgZV8+TtWx9dt+gFEEg3YYuWeAMJZHJlaH37IYXZJJvl5GelAXVmA+hngWxXA6F0hAffnyz66qRPeLIX0TGOZxfhDpGb6bhi5enmSwG02wbh948qqUABoUkIuU2hpINdss4P8mXd4i5mnNZ282BDMpxHeXqMyfLJGvZzuwN6klRT4p6UtSTei49qYkdBUVRbomUOywuZ/qWSfy0Snjp9TmtaXPnus6iNW2uPdJ2Y9STop6U4fgBoJ7UCqgnNcO29aQm+3Jp2MsxJJuLr4zkyUDVtNGrvMsUvOMM6TAF4XHqaLZtKLZkqKqKfquClHdJcI7PEHMNUS2UH3PW5BmgntQE6knNQT0p6kntlZ4UAGu0grS9jB9++QSYbA/2K9UCEtUmmsoQZnsIiWQC5Srw3Y9vAIsFFrMEZyKGciIGXxtwxnPIlAsYOH/Gu3v5YE9iETgHZcSr/Jli11BPagL1pO6gnhT1pBb736Ge1PEpCkkbSrHE0uM6F2/w9uIjrq+v8fH976PfppwhZN3TJ81hNYFf31/h06crvI8lUYcHId+9pymTF7GQDb1SDvwpffdQT2qu8tSTop4U9aT2UU/K5PTAZbEjXtdHA6heQkACXBkFWuNs4TF/tZtQYIHFgnH7mspOTM5XGQBm2/yX0MNADAFzG4XCE+R4ydahntQE6kkBoJ4U9aRW+cfO9KRuP/wyekMzMVcCdR1oZ3xwRQoLq3pod8KCAQYDjNqXAljsM+cnWWAxA8PBfPuKxHyQmgU8SjGdPBvUk5pAPSlQT4p6UnurJwWg0+lMra1gCEBXeujcfAFMfpxfZnEW9sPrdsMfPUc5F4K5nbtrP4VCE+ZQBvmwGw6HexQfqYlSeaayjhQiLh3VXMngOZOvwXamClJPamP/1JOintRT7w/g9etJzfc3wfkp6Ca3SNW6oj+e3q6psmhcnj1IYOo/H7cvoQm1W5nGZ6ZOov/4e4f2rLbzChgy6gXRVhnbB7Og016nMXcfIYSQvYVSHYS8EqI1DUklgB9+u9p1VQjZGhykCCGE7C183UcIIWRv4SBFCHn9mLzI96eZNGrRo/XHkL2AelJkr6CeFFmGOytDyFk8aVng7RV+++EAB5IPhVWrucne8Yy5+wKIlyUEcuWZ3FmELGekJ2VDO+6D0xND1RxCoZTcdbUIITvkWXP3XSRzaM5ILcwpZ2oq5EYWweP5471nl2j1NWjjJ7HszAdM3jz695Uz+3l4x2NguKJBnVHitEZrUIWM7FhqwJHqLlDerOH0yFj569jU/9FpA9rM+ViDRciqjGLQOo2BI4zsOEmppvXRrU1jaKT8VayLn8mdhfzA/3T/uuPXEYt5gGoSv15co/PpA+LxEgZzCUJXs659rKs/AASzNciqNt3fODVUNgCcnFXQ7Y+SwwpNRb91iZR3Gnxr8ByVlgxVGz8pNoo4PZnmuNr0/ojWNPRreeQbMvqqClWu4dw/Lt+RQlerIGwCDqM1aN3UyF++P6deu8r//esL6xka2uOuv9H4Wq1Pex0XnvjXNPRb8/ElLxPqSVFPynD8AFBPagXUk5rhmfSkVuE+7yIXklCKuGB3BZAZeJC5F1/y8qCe1ATqSc1BPSnqSe2bntRKTF5EQnYoOSfefOwA6OBtLI1AL41Y4BAfLygB/1KhntQE6kndQT0p6kkt9r9DPal1SDbYzDp6sxnfB220B9JocCQvFupJzVWeelLUk6Ke1D7qSZFvF+pJTaCeFADqSVFPapV/7ExPai26AmUowT771GhxwmnRofSU2Q+O+yQOjy8F6klNoJ4UqCdFPal91pMaFWGB3XWCk5MZcxwBt1colBXYYhmk/A4cO7w4zSXgGlZRKM+8H7+9RrOnwxmKw+uwPnkWIfm6bCelOvWkNvZPPSnqST31/gBev56Ue76DmdJKTY/NN4Q81ovqty7F6b34ARCm47AodkfnuFa3irYPtvMKGDLqBdFWGdsH9aRor9OYu48QQsjeQqkOQl4J1JMirxEOUoQQQvYWvu4jhBCyt3CQIoQQsrdQT4rsFdSTIqtg+/g22c5UwfE6qX4xLE4cDuE48YrweUOoQhZZt/F1MrRv16zRmlC1riiG3cJxEhTZliq0mTUwtG/b2D6+WduSo/EgJWfd022HYVHRhGicjhYUzi1W1FQhNx4uRPWeXYpWXxOa0IQq10Q2eHy3z+TNi/79hXwzi1/vLza0RmujQXK8mNCRWrScsSZOj4yVv8429X9/Ma81WBSyKoticLogdHYxr6b1RXdmMa+R8lfZuviZ3FnxcDnl7GLO1cevs1RLCPVyuvh7VJ7xLznr2se6+gMQwWxtvBh0zCMW856cVUS3rwptvNC637oUKe/RNB7Bc1FpyULVtLvFvqcn08Wmm94f0Zom+rW8yDdk0VfV8WLecfmOlOhqFRE2QRxGa0Lrjjp3b77/cDHvEv/rF/Ouv/5G42u1Hj3Ytmn7oL1Mo54U9aQMxw8A9aRWQD2pGbatJ7Wt9kFeHNSTmkA9qTmoJ0U9qb3Sk9pi+yAvC+pJTaCe1B3Uk6Ke1GL/e6AntUn7IC8S6knNVZ56UtSTop7UXupJbaN9kBcJ9aQmUE8KAPWkqCe1yj92pye1hfZBXibUk5pAPSlQT4p6UvusJ7Vp+yAvl+1MFaSe1Mb+qSdFPamn3h/A69eT2qR90F607bwChox6QbRVxvZBPSna6zTm7iOEELK3UKqDkFcC9aTIa4SDFCGEkL2Fr/sIIYTsLRykCCGE7C3PNkh58zKEEGjMLHbwF/tzKVeEEOgX/Su8EEII+ZbZeoJZADjyF5FxDtFbsFZPb6bhi5enK80HBlbDE0II+SbZ/iB1FEQmY0c5koG9WsCD1KzDHq4fmVGZEELIt8nWX/eFc2nYyzEkm4tTnkieDFRNg6bKaF2m4D3adg0IIYS8Frb6JGWNVpC2l/HDL58Ak+3BfqVaQKLaRFMZwmwPIZFMoFwFvvvxzTarQQgh5BWxnfQVx6ei1u+K84mUsykoLmek4xfZYfByJC9N+WcajUajLbbtODIFL0eJNRegLcipBkDg+Ey0hCYugxykaDQajfbQtva67/bDL3D1HNMNkg+ZehrmnA+RXHvhMYd2JywYoEk5GEIIIQvY6m9SnU5n+ofJjiEASemhc/MFMPlxXvJhUK6irQwh2QOIJ0MwtxPUgyGEELKQZ1kntZghdLMH8UwEFrMEfaigXU8gEHv79apACCHkRcEEs4QQQvYW5u4jhBCyt3CQIoQQsrdwkCKEELK3cJAihBCyt+zPIGXyIt+fSnjUokzqRwgh3zpbHaTcWRlCzsJtesLBt1f47YcDHEg+FAaLk9MSQgj5ttifJylCCCHkHl99kApna5BVDULT0G8VcXpy+LWrQAgh5IXwVQcp93kXuZCEUsQFuyuAzMCDTDkHP8cpQgghC/h6g5TJi0jIDiUXw5uPHdx0rvA2lkbTHEAswFGKEELIQ77eICXZYDPr6LV7022DNtoDCTa77atVgxBCyMuBEycIIYTsLV9vkNIVKEMJdqd9us3ihNOiQ+kpsx+ErgOSWfpqVSOEELKfbF+qQ7LA7jqBPrvUSVfwqXOFQllBKJZBqhlHQbHAl07ANawiVP5r+tnbazR7OiKhOLzVDHpDHZ8/f9l6NQkhhLwMtibz687Ki/XjW6m7z4TzDSGrmhBCE/3WpTh1Hz7wYzoOi2JXHcvRN8SpdfcSxjQajUb7+kY9KUIIIXsLJ04QQgjZWzhIEUII2Vv+P1HQpHm39/s+AAAAAElFTkSuQmCC">

