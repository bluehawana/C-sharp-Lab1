# C-LAB1
The lab1 of C# course from Azure Cloud Developer 2021@ITHS
Lab1 – Hitta tal i sträng med tecken
Skapa en konsollapplikation där användaren matar in en textsträng (string).
Textsträngen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
siffror förekommer där emellan.
ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
t.ex 95a9 är inte heller ett korrekt tal.
Skriv ut och markera varje korrekt delsträng
För varje sådan delsträng som matchar kriteriet ovan ska programmet skriva ut en
rad med hela strängen, men där delsträngen är markerad i en annan färg.
Exempel output för input ”29535123p48723487597645723645”:
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
Ni kan välja vilka färger ni skriver ut med så länge man ser skillnad på dem. Ni
byter färg genom att ändra värde på Console.ForegroundColor. 
Addera ihop alla tal och skriv ut totalen
Programmet ska också addera ihop alla tal den hittat enligt ovan och skriva ut det
sist i programmet. Gör gärna en tom rad emellan för att skilja från output ovan.
Exempel output för input ”29535123p48723487597645723645”:
Total = 5836428677242
Redovisning
Uppgiften ska lösas individuellt.
Lämna in uppgiften på ithsdistans. Antingen genom att ni laddar upp en .cs-fil,
eller om ni har ett github-konto, att ni checka in den där och skriver en
kommentar med github-länken på ithsdistans.
Betygskriterier
För godkänt:
 Båda uppgifterna ska vara lösta, d.v.s. programmet ska först skriva ut alla
delsträngar som i exemplet ovan och därefter räkna ut och skriva ut total.
 Om man matar in strängen i exemplet ska man få samma output som ovan.
 Det ska även fungera generellt, oavsett vilken sträng man matar in. 
