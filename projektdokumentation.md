# Projekt-Dokumentation

Gian-Marco Mileti

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 24.08 | 0.0.1   | Angefangen mit Projekt                                       |
| 01.09 |         |                                                              |
|       |         |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Ich bin gerade dabei, ein "Number guessing game" zu programmieren.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |    muss         |  Funktional | Als Spieler möchte ich dass der Spieler eine Zufallszahl zwischen 1 und 100 raten kann, damit die Auswahl nicht allzu gross ist.
| 2    |    muss         |  Funktional | Als Spieler möchte ich eine Anzeige dafür ob die Zahl höher oder kleiner ist, damit ich die Zahl schneller erate.
| 3    |    muss         |  Funktional | Als Spieler möchte ich wissen wann die Geheimzahl erraten wurde, damit ich weiss wann ich eine neue Zahl raten muss.
| 4    |    muss         |  Funktional | Als Spieler möchte ich wissen wie viele Versuche ich gebraucht habe, damit ich weiss wie gut ich geraten habe.
| 5    |    muss         |  Funktional | Als Spieler möchte ich dass das Program mit Fehlereingaben umgehen kann, damit das Spiel richtig läuft.

✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | geheimzahl testen zwischen 1-100| 5| das ist eine geheimzahl|
| 1.2  | random zahl erraten| 76| richtig oder falsch|
| 1.3  | 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | bis 01.09| Gian-Marco| speichert Zufallszahl zwischen 1-100| 45min |
| 1.B  | bis 01.09| Gian-Marco| Anzeige ob Zahl höher oder kleiner ist| 60min|
| 1.C  | bis 01.09| Gian-Marco| Anzeige wenn Zahl richtig geraten wurde|   45min    |
| 4.A  | bis 08.09| Gian-Marco| Anzeige für wie viele Versuche der Spieler gebraucht hat|  50min      |
| 1.E  | bis 08.09| Gian-Marco| Programm muss Fehler umgehen|  3x 45min |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.1  | 01.09 | Gian-Marco|    45min      |      15min        |
| 2.1  | 01.09 | Gian-Marco|    60min      |      45min        |
| 3.1  | 01.09 | Gian-Marco|    45min      |      30min        |
| 4.1  | 01.09 | Gian-Marco|    50min      |      60min        |


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
