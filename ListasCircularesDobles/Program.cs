﻿using ListasCircularesDobles;

Lista lista = new Lista();

lista.insertarNodo();
lista.insertarNodo();
lista.insertarNodo();
lista.insertarNodo();
lista.insertarNodo();
Console.WriteLine("-----------");

lista.DesplegarNodoP();
Console.WriteLine("---------");
lista.DesplegarNodoU();

lista.BuscarNodo();
Console.WriteLine("---------");

lista.ModificarNodo();
lista.DesplegarNodoP();

lista.EliminarNodo();
lista.DesplegarNodoP();
