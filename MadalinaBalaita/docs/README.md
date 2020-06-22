 Principiile SOLID :sparkles:
===============
## S-Single responsability
 Orice modul sau clasă trebuie să încapsuleze o singură funcționalitate.
> O clasă sau funcție, nu ar trebui să rezolve sau sa trateze mai mult
decât un singur scop deoarece aceasta ar introduce cuplarea între
cele două funcționalități.
## O-Open Close
Acest principiu exprimă faptul că o clasă sau o funcție, trebuie să fie
deschisă pentru extensie dar închisă pentru modificare. 
> De exemplu, dacă avem o bibliotecă ce conține un set de clase ce
trebuie extinse ar fi mai corect dacă am avea inițial un set de clase
abstracte. Astfel în loc să modificăm clasele concrete din cadrul
bibliotecii, putem extinde clasele abstracte. 

## L-Liskov substitution
 Noile clase extinse din părinte trebuie să fie capabile înlocuiască
clasa de bază în toate funcțiile sale fără a fi nevoie să aducem modificări
nicăieri.
>Acest principiu impune unele condiții în scrierea metodelor: <br/>
•impunerea unei relații inverse de ordine între părinte și copil <br/>
•Subtipurile nu aruncă excepții.<br/>
•Covarianța tipurilor pe care le returnează un subtip . <br/>

## I-Interface segregation
Acest principiu expune ideea că niciun client nu are voie să fie forțat
să depindă de metodele pe care nu le folosește.
>Aceasta se realizează prin ”spargerea” interfețelor în module mai mici
pe care clasele au opțiunea de a le implementa sau nu.Acest mod va ajuta și la ideea de decuplarea funcționalităților atunci
când se dorește re-factorizarea produsului.

## D-Dependency inversion
Acest principiu se referă la o anumită formă de a decupla module
software. Principiul spune că:
>Modulele de nivel înalt nu trebuie să depindă de modulele de nivel
jos. 
Ambele module trebuie să depindă de abstractizări.
