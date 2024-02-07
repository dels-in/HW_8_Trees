<h3>Деревья и кучи</h3>

Цель:
<ul>
<li>построение бинарного дерева поиска</li>
<li>его обход в симметричном порядке</li>
<li>поиск элемента по бинарному дереву</li>
</ul>

Описание/Пошаговая инструкция выполнения домашнего задания:
Напишите программу, которая:
<ul>
<li>принимает на вход из консоли информацию о сотрудниках: имя + зарплата (имя в первой строке, зарплата в виде целого числа во второй строке; и так для каждого сотрудника, пока пользователь не введет пустую строку в качестве имени сотрудника)</li>
<li>попутно при получении информации о сотрудниках строится бинарное дерево с этой информацией, где в каждом узле хранится имя сотрудника, а его зарплата является значением, на основе которого производится бинарное разделение в дереве</li>
<li>после окончания ввода пользователем программа выводит имена сотрудников и их зарплаты в порядке возрастания зарплат (в каждой строчке формат вывода "Имя - зарплата"). Использовать для этого симметричный обход дерева.</li>
<li>после этого программа запрашивает размер зарплаты, который интересует пользователя. В построенном бинарном дереве программа находит сотрудника с указанной зарплатой и выводит его имя. Если сотрудник не найден - выводится "такой сотрудник не найден"</li>
<li>после этого программа предлагает ввести цифру 0 (переход к началу программы) или 1 (снова поиск зарплаты). При вводе 0 должен произойти переход к началу работы программы, т.е. опять запрашивается список сотрудников и строится новое дерево. При вводе 1 должны снова запросить зарплату, которую хочется поискать в дереве - см.предыдущий пункт.</li>
</ul>
