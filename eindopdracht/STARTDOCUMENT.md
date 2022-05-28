# Startdocument Voor Ouderbijdrage

Startdocument van **Steffan van der Werf**. Studentnummer **5062934**.

## Probleem omschrijving

Een basisschool berekent de ouderbijdrage als volgt: Voor een kind jonger dan 6 wordt € 38,- gerekend, voor een kind jonger dan 10 (en niet jonger dan 6) € 50,- en voor een kind vanaf 10 jaar € 65,-. Er dient een programma te worden ontwikkeld waarmee voor ieder kind de geboortedatum (formaat dd-mm-jjjj) kan worden ingevoerd. Voor elk kind moet de verschuldigde ouderbijdrage worden berekend en getoond. Verder moeten cumulatief de totale bijdrage, de leeftijd van de jongste leerling en het aantal kinderen in iedere categorie worden getoond. 

Alle schermen moeten het formaat van 450 bij 375 pixels

### Invoer & Uitvoer

in dit stuk ga ik de in en uitvoer producten beschrijven. 
#### Input

In de tabel hier onder ga ik het over de input omschrijven. (de input dat de gebruiker moet in vullen om de applicatie te laten werken)

|Case|Type|Conditie|
|----|----|----------|
|Naam van de school|`String`|not empty|
|Id van de school|`int` |not empty|
|Naam van het kind|`String` |not empty|
|Leeftijd van het kind|`DateTime`|`dd-mm-jjjj`|
|Gekoppelde school Id|`int`|not empty|
|Administratie nummer van kind|`int`|not empty|

#### Output

|Case|Type|
|----|----|
|leeftijd jongste kind |`int`|
|Cumulatief van de totale bijdrage |`float`|
|Aantal kinderen per categorie |`int`|
|leeftijd van een kind |`int`|
|Bedrag voor ouderbijdragen |`float`|
#### Berekeningen

| Case              | Calculation                        |
| ----------------- | ---------------------------------- |
| Cumulatief van de totale bijdrage | de som van alle ouderbijdragen bij elkaar opgeteld |
| Berekenen wat de ouderbijdragen voor kind is |  Voor een kind jonger dan 6 wordt € 38,- gerekend, voor een kind jonger dan 10 (en niet jonger dan 6) € 50,- en voor een kind vanaf 10 jaar € 65,-|
| Berekenen van huidige leeftijd | de som van alle ouderbijdragen bij elkaar opgeteld |


## Lay-out van de GUI

## Klassen diagram

![Klassen diagram](klassenDiagram.png "Eerste versie van het klassen diagram")

## Testplan

in dit hoofstuk ga ik de testcases omschrijven die de applicatie gaan testen.

### Test Data

In de volgende tabellen ga je alle data vinden die nodig is om de applicatie te testen
#### School

| ID            | Input                             | Code                              |
| ------------- | --------------------------------- | --------------------------------- |
| `school1` | name: school, id: 1 | `new School("school", 1)`|
| `school2` | name: basisschool ,id: 2 | `new School("basisschool", 2)`|

#### Child

| ID            | Input                             | Code                              |
| ------------- | --------------------------------- | --------------------------------- |
| `child1` | name: klaas, birthDate: 02-02-2002, schoolId: 1, id : 1 | `new Child("klaas", new DateTime(2002, 02, 02), 1, 1)`|
| `child2` | name: fin, birthDate: 02-02-2012, schoolId: 2, id : 2| `new Child("fin", new DateTime(2012, 02, 02), 2, 2)`|

#### ParentContribution

| ID            | Input                             | Code                              |
| ------------- | --------------------------------- | --------------------------------- |
| `ParentContribution1` | childId: 1 | `new ParentContribution(1)`|
| `ParentContribution2` | childId: 2 | `new ParentContribution(2)`|

### Testgevallen

In dit hoofstuk ga ik de stappen omschrijven om de test uit te voeren als een basis lijn.

#### #1 getYoungestChildAge

Returns de leeftijd van jongste kind van de school

| Step | Input        | Action                 | Expected output |
| ---- | ------------ | ---------------------- | --------------- |
| 1    | `School1` | `getYoungestChildAge()` | 20 |
| 2    | `School2` | `getYoungestChildAge()` | 10 |

#### #2 getTotalProfit

[omschrijving]

| Step | Input        | Action                 | Expected output |
| ---- | ------------ | ---------------------- | --------------- |
| 1    | `School1` | `getTotalProfit()` | 65 |
| 2    | `School2` | `getTotalProfit()` | 65 |

#### #3 getCountChildPerCat

[omschrijving]

| Step | Input        | Action                 | Expected output |
| ---- | ------------ | ---------------------- | --------------- |
| 1    | `School1` | `getCountChildPerCat(20)` | 1 |
| 2    | `School2` | `getCountChildPerCat(10)` | 1 |


#### #4 getAge

[omschrijving]

| Step | Input        | Action                 | Expected output |
| ---- | ------------ | ---------------------- | --------------- |
| 1    | `child1` | `getAge()` | 20 |
| 2    | `child2` | `getAge()` | 10 |


#### #5 calcContribuation

[omschrijving]

| Step | Input        | Action                 | Expected output |
| ---- | ------------ | ---------------------- | --------------- |
| 1    | `child1` | `getYoungestChildAge()` | 65 |
| 2    | `child2` | `getYoungestChildAge()` | 65 |



