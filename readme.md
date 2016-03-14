#Pošta
1. Faruk Sinanovic
2. Benjamin Šehic
3. Omer Selimanjin
4. Random

##Opis teme

Korist softvera je olakšavanje rada zaposlenicima firme i bolje poslovanje pošte. Cilj softvera je automatizacija
odredenih procesa i ekonomizacija resursa firme (barem jedan radnik manje). Sistem pruža centralizovano upravljanje resursima,
mobilnost i fleksibilnost pri radu, koji je ujedno jednostavan i intuitivan za upotrebu. Pruža uniforman nacin upravljanjem i uredivanjem administrativnih poslova.

##Opis procesa

Klijent daje pošiljke blagajniku koje ih unosi u sistem. Pošiljke se, u zavisnosti od adresa, sortiraju po rejonima. Poslovoda ce imati informacije 
o prvim zadnjim rokovima dostave, i bira dostavljace koje ce isporuke izvršavati na osnovu rejona. Dostavljaci imaju mobilnu aplikaciju u kojoj
oznacava koje su pošiljke isporucene, te u slucaju neuspjele dostave navode razlog neizvršene dostave. Nakon toga dostavljaci podnose izvještaje o dostavljenim
pošiljkama i te informacije se pohranjuju u odgovarajuce spremište. Pošiljke koje nisu dostavljene se ponovno vracaju u sistem, te njima daje prioritet dostave.

##Funkcionalnosti i Akteri

######Poslodavoda
Osoba koja je odgovorna za poslovanje i od koje sve zavisi.
Funkcionalnosti poslovode su:
- Dodavanje i uklanjanje radnika, odabir radnika za odredene poslove
- Nabavka i raspodjela vozila
- Odabir dostavljaca za isporuku pošiljaka
- Odreduje dostavljacima rejone u kojima ce dostavljati.

######Blagajnik
Osoba koja je odgovorna za prijem pošiljaka i unos informacija o pošiljci u sistem.
Funkcionalnosti blagajnika su:
- Prijem pošiljaka
- Ispunjavanje odgovarajuce forme kreirane od strane sistema
- Unos u sistem

######Dostavljac
Osoba koja je odgovorna za dostave. 
Postoje 2 tipa dostavljaca: 
- Poštari koji raznose pisma i letke
- Vozaci koji uz to raznose i pakete.
Funkcionalnosti dostavljaca su:
- Preuzimanje pošiljaka iz sistema
- U slucaju vozaca, preuzimanje vozila
- Evidentiranje statusa isporuke putem mobilne aplikacije
- Podnošenje izvještaja

Dodatne funkcionalnosti u okviru mobilne aplikacije:
- Mape
- Notifikacije 
 