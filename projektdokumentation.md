# Projekt-Dokumentation

Gian-Marco Mileti

| Datum | Version | Zusammenfassung                                              |
| 24.08 | 0.0.1   | Angefangen mit Projekt                                       |
| 01.09 | 0.0.2   | Basis des Spiels steht                                       |
| 08.09 | 0.0.3   | Programm zählt jetzt Versuche                                |

## 1 Informieren

### 1.1 Ihr Projekt

Ich bin gerade dabei, ein "Number guessing game" zu programmieren.

### 1.2 User Stories

| US-№ | Verbindlichkeit |  Typ        | Beschreibung                       |
| 1    |    muss         |  Funktional | Als Spieler möchte ich dass der Spieler eine Zufallszahl zwischen 1 und 100 raten kann, damit die Auswahl nicht allzu gross ist.
| 2    |    muss         |  Funktional | Als Spieler möchte ich eine Anzeige dafür ob die Zahl höher oder kleiner ist, damit ich die Zahl schneller erate.
| 3    |    muss         |  Funktional | Als Spieler möchte ich wissen wann die Geheimzahl erraten wurde, damit ich weiss wann ich eine neue Zahl raten muss.
| 4    |    muss         |  Funktional | Als Spieler möchte ich wissen wie viele Versuche ich gebraucht habe, damit ich weiss wie gut ich geraten habe.
| 5    |    muss         |  Funktional | Als Spieler möchte ich, dass das Programm mit Fehlereingaben umgehen kann, damit das Spiel richtig läuft.
| 6    |    kann         |  Qualität   | Als Spieler möchte ich, dass das Programm eine Hintergrund-Farbe (Grün (richtig) oder Rot (falsch)) passend auf die Genauigkeit auf die ich geraten habe anspasst.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| 1.1  | geheimzahl testen zwischen 1-100 | 5 | das ist eine geheimzahl |
| 2.1  | random zahl erraten | 76 | richtig oder falsch |
| 3.1  | geratene Zahl ist falsch | 45 | Programm gibt an ob Zahl richtig oder Falsch ist
| 4.1  | Beim 3ten mal erraten | 7,10,11 | Programm gibt Versuche an
| 5.1  | Spieler gibt Buchstabe ein | b | Programm sagt: gib eine Zahl ein
| 6.1  |
| 7.1  |

### 1.4 Diagramme



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| 1.A  | bis 01.09| Gian-Marco| speichert Zufallszahl zwischen 1-100| 45min |
| 2.A  | bis 01.09| Gian-Marco| Anzeige ob Zahl höher oder kleiner ist| 60min|
| 3.A  | bis 01.09| Gian-Marco| Anzeige wenn Zahl richtig geraten wurde|   45min    |
| 4.A  | bis 08.09| Gian-Marco| Anzeige für wie viele Versuche der Spieler gebraucht hat |  50min      |
| 5.A  | bis 15.09| Gian-Marco| Programm muss Fehler umgehen |  3x 45min |
| 6.A  | bis 15.09| Gian-Marco|

Total: 

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.1  | 01.09 | Gian-Marco|    45min      |      15min        |
| 2.1  | 01.09 | Gian-Marco|    60min      |      45min        |
| 3.1  | 01.09 | Gian-Marco|    45min      |      30min        |
| 4.1  | 08.09 | Gian-Marco|    50min      |      45min        |
|   | 


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
