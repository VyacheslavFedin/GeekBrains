# 1. Задайте список из нескольких чисел.
#    Напишите программу, которая найдёт сумму элементов списка,
#    стоящих на нечётной позиции.
#    Пример:
#    - [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12
#    Решение:

list_1 = [2, 3, 5, 9, 3]
temp_1 = 0
for i in range(1, len(list_1), 2):
    temp_1 += list_1[i]
print(temp_1)

# 2. Напишите программу, которая найдёт произведение пар чисел списка.
#    Парой считаем первый и последний элемент, второй и предпоследний и т.д.
#    Пример:
#    - [2, 3, 4, 5, 6] => [12, 15, 16];
#    - [2, 3, 5, 6] => [12, 15]
#    Решение:

list_2 = [2, 3, 4, 5, 6]
temp_2 = 0
repeat_2 = 0

if len(list_2) % 2 > 0:               # выясняем необходимое количество циклов
    repeat_2 = int(len(list_2) / 2) + 1
else:
    repeat_2 = int(len(list_2) / 2)

for i in range(0, repeat_2, 1):                        # перемножаем пары
    temp_2 = list_2[i] * list_2[- i - 1]
    print(temp_2, end=' ')

# 3. Задайте список из вещественных чисел. Напишите программу,
#    которая найдёт разницу между максимальным и минимальным значением дробной
#    части элементов.
#    Пример:
#    - [1.1, 1.2, 3.1, 5, 10.01] => 0.19
# Решение :

list_3 = [1.1, 1.2, 3.1, 5, 10.01]
temp_list_3 = []
repeat_3 = len(list_3)
max_3 = 0
min_3 = 1


for i in range(repeat_3):                       # убираем целую часть чисел
    temp_list_3.append(round(list_3[i] - int(list_3[i]), 14))


for i in range(repeat_3):                       # ищем min и max  и выводим их разность
    if max_3 < temp_list_3[i]:
        max_3 = temp_list_3[i]
    if min_3 > temp_list_3[i] and temp_list_3[i] != 0:
        min_3 = temp_list_3[i]
print(max_3 - min_3)

# 4. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
#    Пример:
#    - 45 -> 101101
#    - 3 -> 11
#    - 2 -> 10
#    Решение :

#    способ "деление на 2"

number_4 = int(input('введите число : '))
temp_4 = 0
list_4 = []

while number_4 >= 1:                # заполняем список еденицами и нулями
    temp_4 = number_4 % 2
    number_4 //= 2
    list_4.append(temp_4)

for i in range(len(list_4)):  # выводим список на экран в обратном порядке
    print(list_4[-i-1], end='')

# 5. Задайте число. Составьте список чисел Фибоначчи,
#    в том числе для отрицательных индексов.
#    Пример:
#    - для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0,
#    1, 1, 2, 3, 5, 8, 13, 21]
#    Решение:

k = 8
sum = 0
pos1 = 1
pos2 = 0

list_pos = []
list_neg = []
list_5 = []

for i in range(1, k, 1):  # составляем положительную сторону
    sum = pos1 + pos2
    pos2 = pos1
    pos1 = sum
    list_pos.append(sum)

sum = 0
pos1 = 1
pos2 = 0

for i in range(1, k, 1):  # составляем отрицательную сторону
    sum = pos2 - pos1
    pos2 = pos1
    pos1 = sum
    list_neg.append(sum)

for i in range(k - 1):     # запись в основной список и вывод на экран
    list_5.append(list_neg[-i-1])
list_5.append(1)
list_5.append(0)
list_5.append(1)
for i in range(k - 1):
    list_5.append(list_pos[i])

print(list_5)
