# Principiile SOLID

## S-Single Responsibility Principle

Un modul are un unic motiv de a fi modificat deoarece are doar o singura functie.

## O-Open-Closure Principle

Un modul trebuie sa fie usor de extins , dar foarte greu de modificat.La o cerinta noua sa nu modificam codul ,doar sa adaugam la  el.

## L-Liskov Substitution Principle

Daca orice modul este legat de  o clasa de baza, atunci referinta catre clasa de baza poate fi inlocuita cu o clasa derivata ,fata a afecta functionalitatea modulului.

## I-Interface Segregation Principle

Nu trebuie sa depindem de interfete pe care nu o sa le utilizam vreodata . Practic sa nu ne incarcam programul degeaba.

## D-Dependency Principle

Trebuie sa depindem de abstractizari, nu pe implementari concrete.