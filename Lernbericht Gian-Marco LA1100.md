# Lern-Bericht
Gian-Marco Mileti

## Einleitung

Ich habe ein Number guessing game in C# programmiert. Dieses Programm generiert eine zufällige Zahl von 1 bis 100, die der User errät.

## Was habe ich gelernt?

In diesem Projekt habe ich gelernt wie und wo man eine Try/Catch Schleife verwendet.

## Beschreibung

In diesem Projekt habe ich ein Random Number Guessing game programmiert. Dabei habe ich eine Try/Catch Schleife miteingebaut, um Fehlereingaben zu verhindern.
Diese Schleife gibt einem die Möglichkeit, wenn der User eine Eingabe, welche nicht mit dem Code Kompatibel ist, eingibt, einen Programmabsturz zu umgehen, indem es einen, vom Programmierer geschrieben, Text anzeigt.
Dem User wird in der Konsole angezeigt, dass seine Eingabe nicht (in diesem Fall einer geraden Zahl) der Vorgabe entspricht. Entweder stoppt das Programm abrupt oder der User wird nach einer gefragten Eingabe gefragt.


Ein Beispiel dazu.

```csharp
        
            int Zahl;
            try
            {
                Console.WriteLine("Geben Sie eine Zahl ein:");
                Zahl = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ungültige Eingabe");
            }
           
```

Wird dieses Programm ausgeführt, muss der User eine Zahl von 1 - 1000 eingeben.
Wenn die Eingabe falsch ist, wird "Ungültige Eingabe" ausgegebn und das Programm wird beendet.


## Richtige Eingabe

![image](https://user-images.githubusercontent.com/111044245/191698842-cc241187-ceca-4081-8ee9-e6adcc6dc386.png)

## Falsche Eingabe

![image](https://user-images.githubusercontent.com/111044245/191698989-e5f9747f-feba-4e93-9e7e-832a32bb1a83.png)



## Verifikation

In dem Code-Fetzen sieht man wie eine einfache Try/Catch Schleife aufgebaut ist. 
Die beiden Printscreens zeigen, wie die beiden Ausgaben aussehen oder wie das Programm eben nicht abstürzt. Das Programm fängt sich auf.

# Reflektion zum Arbeitsprozess

### Was gut lief

Im Homeschooling habe ich viel konzentrierter gearbeitet als im Präsenzunterricht. Das Flair war Zuhause wesentlich angenehmer als im Unterricht, da ich nicht so oft bis garnicht abgelenkt wurde.


### Was nicht gut lief

Beim programmieren gab es öfters Momente an denen ich nicht wirklich vorankam. Ich wusste nicht, was ich als nächstes tun sollte oder wie ich etwas umsetzten soll.
Da wir aber eine Projektdokumentation gemacht haben, konnte ich mich ein wenig besser organisieren. Aber auch nicht immer, sie half mir nur ein wenig.


**VBV**: Nächstes mal werde ich meine Projektdokumentation fortlaufender gestalten und keine Zeit mehr mit viel nachzudenken verschwenden.
