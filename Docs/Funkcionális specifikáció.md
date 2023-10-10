# Funkcionális specifikáció

## 1. Jelenlegi helyzet leírása

A mai világban fontos, hogy olyan alkalmazásokat használjunk a munkánk során, amelyek nem használják túlságosan a számítógépünket. Ezért a legtöbb cég az alkalmazásait minél egyszerűbben és letisztultabban tervezi meg.



## 2. Vágyállomrendszer leírása
A megrendelő egy olyan számológép alkalmazást szeretne, amivel könnyedén tud egyszerűbb matematikai feladatokat megoldani, egy olyan alkalmazást, amit könnyen megtud nyitni a számítógépéről és nem kell a számológépét előkeresnie.
Az alkalmazást kezdeti állapotában is fel kell készíteni a későbbi fejleszthetőségre, ami az első használat utáni visszajelzések fényében valósulhat meg. A megrendelő egy egyszerű számológépet kért letisztult dizájnnal és egyszerűen átlátható gombokkal, mert a célja a gyors és hatékony számolás, ezért egyértelmű gombokkal készítjük majd el. Nem szeretne bonyolult műveleteket végezni, csak összeadást, kivonást szorzást és osztást. A szoftvert c# nyelven fog elkészülni.

## 3. Jelenlegi üzleti folyamatok modellje
Jelenleg a megrendelőnek nincs számítógépes számológép alkalmazása, amivel könnyedén tudna egyszerűbb matematikai műveleteket elvégezni. Jelenleg mindig elő kell keresnie a számológépét és így nem elég hatékony a munkában és azonkívül.


## 4. Igényelt üzleti folyamatok modellje
A megrendelő a számológépet képes lesz a számítógépéról könnyen megnyitni és gyors műveleteket végezni vele. Ha végzett a dolgával, egy kattintással be is tudja majd azt zárni.

## 5. Követelménylista

| Id | Modul | Név | Leírás |
| :---: | --- | --- | --- |
| K1 | Felület | Kijelző | Az elvégzendő művelet, illetve a művelet eredményét jeleníti meg. |
| K2 | Felület | Gombok | A számokat (0-9) illetve alapműveleteket tudja bevinni a felhasználó. |

## 6. Használati esetek

Alapvető aritmetikai műveletek elvégzésére lehet használni.

## 7. Megfeleltetés, hogyan fedik le a használati eseteket a követelményeket

K1, K2: A felhasználó a gombok segítségével viszi be a számokat, illetve a műveleteket, majd az eredmény a kijelzőn megjelenik.

## 8. Képernyőtervek
![Képernyőterv](../kepernyoterv.png)

## 9. Forgatókönyvek
Elindítva az alkalmazást bárhol könnyedén tudunk bonyolultabb matematikai feladatokat elvégezni.
## 10. Funkció - követelmény megfeleltetése

K1: A kijelzőn megjelennek a beütött számjegyek, műveletek, és az eredmény. K2: A különböző gombok megnyomásával bevihetőek a számok, amikkel műveletet kell elvégezni, és maguk a műveletek. 

## 11 Fogalomszótár
| Fogalom | Leírás |
| :---: | --- |
| c#| Programozási nyelv, ebben írjuk meg a programot|
| Aritmetikai művelet | összeadás, kivonás, szorzás, osztás műveletek |
