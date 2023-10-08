# Rendszerterv
## 1. A rendszer célja

A rendszer célja egy számológép, amellyel az emberek megkönnyíthetik a munkát. A számológépek a mindennapjaink részét képezik, szinte minden területen ott vannak. Ez a program is ezt a célt szolgálja majd.

## 2. Projektterv

### 2.1 Projektszerepkörök, felelőségek:
   * Scrum masters: Mihály Balázs
   * Product owner: Szegedi Tamás
   * Üzleti szereplő: Tajti Tibor
     
### 2.2 Projektmunkások és felelőségek:
   * Frontend: Kelemen András, Soós János, Penyaskó Dávid
   * Backend: Kelemen András, Soós János, Penyaskó Dávid
   * Tesztelés: Kelemen András, Soós János, Penyaskó Dávid
### 2.3 Ütemterv:

|Funkció                  | Feladat                                | Prioritás | Becslés (nap) | Aktuális becslés (nap) | Eltelt idő (nap) | Becsült idő (nap) |
|-------------------------|----------------------------------------|-----------|---------------|------------------------|------------------|---------------------|
|Követelmény specifikáció |Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |             
|Funkcionális specifikáció|Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |
|Rendszerterv             |Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |
|Program                  |Képernyőtervek elkészítése              |         2 |             1 |                      1 |                1 |                   1 |
|Program                  |Prototípus elkészítése                  |         3 |             8 |                      8 |                8 |                   8 |
|Program                  |Alapfunkciók elkészítése                |         3 |             8 |                      8 |                8 |                   8 |
|Program                  |Tesztelés                               |         4 |             2 |                      2 |                2 |                   2 |

### 2.4 Mérföldkövek:

 - 09.26 Rendszerterv
 - 09.29 Funkcionális specifikáció
 - 09.29 Követelmény specifikáció
 - 10.03 Adatbázis kialakítása
 - 10.09 Frontend design megtervezése
 - 10.09 Backend funkciók elkészítése

## 3. Üzleti folyamatok modellje



![Üzletifolyamat](../Project/Pictures/uzleti_folyamatok_modellje.png)

## 4. Követelmények

### funkcionális követelmények

| Id | Modul | Név | Leírás |
| :---: | --- | --- | --- |
| K1 | Felület | Kijelző | Az elvégzendő művelet, illetve a művelet eredméynét jeleníti meg. |
| K2 | Felület | Gombok | A számokat (0-9) illetve alapműveleteket tudja bevinni a felhasználó. |

### Támogatott eszközök

Egy asztali alkalmazást tervezünk, egy telefon, vagy asztali számítógép elég a használatához, internetkapcsolat sem szükséges hozzá.

## 5. Funkcionális terv

### 5.1 Rendszerszereplők

- felhasználó

### 5.2 Menühierarchiák

- Felhasználó
    - Beüthet számjegyeket, műveleti jeleket.
    - Törölhet számjegyeket, műveleti jeleket.
  
## 6. Fizikai környezet

- **Egy asztali alkalmazást készítünk, nem szükséges futtató program.**
  - **Nincsenek megvásárolt komponensek.**
  - **Fejlesztői eszközök: **
    - **Visual Studio 2023**

## 7. Architekturális terv

A programot C# nyelven írjuk. A megjelenést Windows Forms App-pal fogjuk megoldani.

## 8. Implementációs terv

A számológépet Windows Forms-ban fog elkészülni. A különböző számolási elemeket és egyéb gombok funkcióit elkülönítve, jól átláthatóan, kommentekkel hozzuk létre. 

## 9. Tesztterv

A tesztelések célja, hogy meggyőződjünk a felület gombjainak, beviteli mezőinek, számolás helyességének, illetve minden komponensének működéséről. A teszteléseket minden tag megadott számban elvégzi, külön file-ban dokumentálni fogja.

## 10. Telepítési terv
Nem szükséges telepíteni magát a szoftvert, elég ha csak rendelkezik a számítógép .NET keretrendszerrel, így az alkalmazást bármikor tudja futtatni a felhasználó.


## 11. Karbantartási terv
Figyelembe kell venni a felhasználó által jött visszajelzéseket is a programmal kapcsolatban. Ha hibát talált, mielőbb orvosolni kell, lehet az:

  -Működéssel kapcsolatos
  -Dizájnnal kapcsolatos
