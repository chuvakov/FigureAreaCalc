# FigureAreaCalc - Библиотека и Api расчета площадей фигур

### Данный проект представляет собой реализацию тестового задания

www.figure-calc.alex-chuvakov.ru/swagger/index.html

___

Задание №1:

* Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 

Дополнительно:

* Юнит-тесты
* Легкость добавления других фигур
* Вычисление площади фигуры без знания типа фигуры в compile-time
* Проверку на то, является ли треугольник прямоугольным

Решение: www.figure-calc.alex-chuvakov.ru/swagger/index.html

___

Задание №2:

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Решение:

select p.name, c.name /n
from products as p /n
left join productscategories as pc on p.id = pc.productid /n
left join categories as c on pc.categoryid = c.id;
___
