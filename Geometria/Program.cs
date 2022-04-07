// See https://aka.ms/new-console-template for more information
/*
 Esercitazione di oggi: Geometria
Nome repo: csharp-geometria
Consegna: Nel progetto csharp-geometria eseguire le seguenti cose:
1. Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo.
Aggiungere un opportuno costruttore con parametri.
Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
2. Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, i valori di base e di altezza con cui
istanziare un nuovo Rettangolo. Dopo averlo istanziato, stampate a video il perimetro e l’area.
3. Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo) e provate a
stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:
 —— Rettangolo1 ——
base: 20 cm
altezza: 10 cm
Perimetro: 60 cm
Area: 200 cm2
*/

//----CHIEDERE ALL'UTENTE PARAMETRI BASE E ALTEZZA E STAMPA IN VIDEO RISULTATI----//

using Geometria;
int b;
int h;
Console.WriteLine("Inserisci cm base rettangolo: " );
b = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci cm altezza rettangolo ");
h = int.Parse(Console.ReadLine());




Rettangolo rtng = new Rettangolo(b,h);
rtng.Stampa();

//-------STAMPO A VIDEO PIU' RETTANGOLI CON DIVERSI PARAMETRI--------//

Console.WriteLine();
Console.WriteLine("---1° RETTANGOLO---");
int baseRettangolo = 25;
int altezzaRettangolo =25;

Rettangolo rett = new Rettangolo(baseRettangolo, altezzaRettangolo);
rett.Stampa();

//--------------------------------------------------------------------//


Console.WriteLine();
Console.WriteLine("---2° RETTANGOLO---");
int baseRett = 35;
int altezzaRett = 20;

Rettangolo rett1 = new Rettangolo(baseRett, altezzaRett);
rett1.Stampa();

//-------------------------------------------------------------------//


Console.WriteLine();
Console.WriteLine("---3° RETTANGOLO---");
int baseRe = 28;
int altezzaRe = 37;

Rettangolo rett2 = new Rettangolo(baseRe, altezzaRe);
rett2.Stampa();
















