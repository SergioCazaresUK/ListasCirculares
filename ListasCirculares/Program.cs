﻿using ListasCirculares;

Lista lista = new Lista();

lista.InsertarNodo();
lista.InsertarNodo();
lista.InsertarNodo();
lista.InsertarNodo();
lista.InsertarNodo();
Console.WriteLine("----------------");
lista.DesplegarLista();

lista.BuscarNodo();

lista.ModificarNodo();
lista.DesplegarLista();

lista.EliminarNodo();
lista.DesplegarLista();