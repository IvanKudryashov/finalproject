# Задача:
## Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
# Описание алгоритма
## Создаем два массива  Потом метод, в котором в цикле идем по всему массиву и проверяем условие ( длина строки <=3 ), если да, то элемент первого массива заносится в count элемент второго массива. После  увеличиваем переменную count на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проходим по всем элементам массива строк.