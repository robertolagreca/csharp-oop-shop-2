// See https://aka.ms/new-console-template for more information
using CSharpShop2;
using System.Runtime.ConstrainedExecution;

//A partire da quanto già fatto con csharp-oop-shop dove vi era stato chiesto di creare una classe
//Prodotto generica per gestire un generico prodotto dello Shop, vi chiedo ora di essere
//più specifichi e di creare le sottoclassi opportune di alcuni prodotti che potremmo identificare
//nel nostro shop.
//In particolare immaginiamo che nel nostro shop possiamo commerciare le seguenti tipologie di prodotto:
//Acqua(massimo 1.5L)
//Sacchetto di Frutta a pezzi (al massimo puo contenere 5 pezzi di frutta)
//Elettrodomestico
//Cibo in Scatola (al massimo può contenere 300g di peso su una scatola)
//Per ognuno dei seguenti prodotti più specifici vi si chiede di identificare quali potrebbero essere
//i loro attributi e metodi che eventualmente gli riguardano, ereditando i metodi e gli attributi
//generici dalla classe Prodotto creata nell’esercizio precedente.
//Un esempio per la classe Acqua che eredità Prodotto è aggiungere i seguenti attributi e metodi:
//attributo litri: per indicare quanti litri di acqua ci sono nella bottiglia di acqua
//attributo ph: che indica il livello di acidità dell’acqua (sola lettura)
//attributo sorgente: che indica la sorgente di provenienza dell’acqua (sola lettura)... ecc ecc

//metodo bevi (double litriDaBere) che toglie dall’attributo litri una quantità pari a litriDaBere
//di acqua se presenti.
//metodo riempi(double litri) che riempie la bottiglia di acqua con tot litri di acqua, stando attenti a
//non riempirla troppo.
//metodo svuota() che rimuove tutta l’acqua dalla bottiglia.
//metodo stampaProdotto() che fa l’override del metodo di base StampaProdotto già dichiarato nella superclasse
//Prodotto (se non lo avete già fatto dichiaratelo anche nella classe prodotto è si occupa di
//stampare il “codice - nome”, l lo abbiamo chiamato NomeEsteso), per stampare oltre al codice
//e al nome dell’acqua, anche la sua sorgente, il ph e i litri contenuti.

//Dichiariazione viariabili
int code;
int iva;
float price;
string name;
string description;



//Assegnazione valori esempio
code = 0;
iva = 22;
price = 12.99f;
name = "I sentieri dei nidi di ragno";
description = "Autore Italo Calvino"; 



//creazione oggetti.
//Prodotto prodObject = new Prodotto(name, description, price, iva);
Acqua bottle1 = new Acqua("Sor", "Naturale", 1.9f, 6, 1.5f, 8, "Trentino",1f);

List<string> fruits = new List<string>() {"Mandorle" , "Noci" , "Nocciole"};
FruitsPack fruits1 = new FruitsPack("Pacco frutta secca", "mandorle ecc", 4.6f, 22, fruits);

Elettrodomestico washingMachine = new Elettrodomestico("Lavatrice", "Lava bene", 300f, 22, 24.7f, 52.2f, 1.05f, "Bianca");


//PRODOTTO ACQUA

//Richiedo variabili a classe Prodotto e Stampa
Console.WriteLine("-----------------------------------");
Console.WriteLine("STAMPA PRODOTTO: BOTTIGLIA D'ACQUA");
code = bottle1.GetCode();
Console.WriteLine("Il codice creato per l'acqua è " + code);

Console.WriteLine("Hai inserito i seguenti dati:");

Console.WriteLine("Nome prodotto: " + bottle1.GetName());
Console.WriteLine("Descrizione prodotto: " + bottle1.GetDescription());

bottle1.FullName();
bottle1.BasicPrice();
bottle1.FullPrice();
Console.WriteLine("-----------------------------------");

//PRODOTTO ELETTRODOMESTICO

//Richiedo variabili a classe Prodotto e Stampa
Console.WriteLine("-----------------------------------");
Console.WriteLine("STAMPA PRODOTTO: LAVATRICE");
code = washingMachine.GetCode();
Console.WriteLine("Il codice creato per la lavatrice è " + code);

Console.WriteLine("Hai inserito i seguenti dati:");

Console.WriteLine("Nome prodotto: " + washingMachine.GetName());
Console.WriteLine("Descrizione prodotto: " + washingMachine.GetDescription());

washingMachine.FullName();
washingMachine.BasicPrice();
washingMachine.FullPrice();
Console.WriteLine("-----------------------------------");



//PRODOTTO SACCHETTO FRUTTA

//Richiedo variabili a classe Prodotto e Stampa
Console.WriteLine("-----------------------------------");
Console.WriteLine("STAMPA PRODOTTO: SACCHETTO DI FRUTTA");
code = fruits1.GetCode();
Console.WriteLine("Il codice creato per il sacchetto di frutta è " + code);

Console.WriteLine("Hai inserito i seguenti dati:");

Console.WriteLine("Nome prodotto: " + fruits1.GetName());
Console.WriteLine("Descrizione prodotto: " + fruits1.GetDescription());



//Metodo che restituisce codice + nome
fruits1.FullName();



//Metodo che restituisce il prezzo base
fruits1.BasicPrice();
//Console.WriteLine(prodObject.GetPrice());



//Metodo che restituisce il prezzo compreso di IVA.
fruits1.FullPrice();
//Console.WriteLine(prodObject.GetIva());
Console.WriteLine("-----------------------------------");


// PRODOTTO LIBRO
/*
//Set delle variabili nell'oggetto
prodObject.SetName(name);
prodObject.SetDescription(description);
prodObject.SetPrice(price);
prodObject.SetIva(iva);




//Richiedo variabili a classe Prodotto e Stampa
code = prodObject.GetCode();
Console.WriteLine("Il codice creato per il tuo libro è " + code);

Console.WriteLine("Hai inserito i seguenti dati:");

Console.WriteLine(prodObject.GetName());
Console.WriteLine(prodObject.GetDescription());



//Metodo che restituisce codice + nome
prodObject.FullName(name, code);



//Metodo che restituisce il prezzo base
prodObject.BasicPrice(price);
//Console.WriteLine(prodObject.GetPrice());



//Metodo che restituisce il prezzo compreso di IVA.
prodObject.FullPrice(price, iva);
//Console.WriteLine(prodObject.GetIva()); */