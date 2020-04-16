Principiile SOLID
=================

### S - Single Responsability Principle
Fiecare modul trebuie să fie responsabil de un singur lucru atunci când vine vorba de funcționalitate. 
Acel lucru trebuie încapsulat în întregime în modulul responsabil.

### O - Open-Closed Principle
Componentele ar trebui să fie ușor de extins, dar greu de modificat.

### L - Liskov Substitution Principle
Obiectele unei clase ar trebui să poată fi substituite de instanțe ale claselor derivate, fără ca acest lucru să modifice funcționalitatea.

### I - Interface Segregation Principle
Interfețele folosite ar trebui să fie mici, specifice, nu generale, pentru a nu fi nevoie să se implementeze metode inutile. 

### D - Dependency Inversion Principle
Dependency Inversion constă în faptul că modulele high level nu ar trebui să depindă de modulele low level. 
De exemplu, dacă avem un buton, și acel buton este acționat, atunci activăm un event.
Eventul acela face o clasă nouă și apelează o metodă din acea clasă. 
Metoda aceea, la rândul ei, face o instanță dintr-o altă clasă care poate să scrie și să 
citească din baza de date. Apelează o metodă din clasa aceasta. 
Acea metodă apoi face un Query pe baza de date. În felul acesta, butonul depinde 
de baza de date și se creează instanțe până se face toată acțiunea. În schimb, 
ar trebui să nu depindă butonul de implementare pană la baza de date ci să depindă de interfețe. 
Și să ne folosim de interfețe.