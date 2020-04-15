# Evaluarea nr. 2 pentru cursul Tehnici Avansate de Programare #

## Context ##
Sunteți proaspăt angajat la **Leii Grei** o firmă care își propune să revoluționeze piața bancară oferind un instrument de plată inteligent numit **Pușculița**.

Pentru a crește numărul de clienți, șeful de la **Leii Grei** vine cu o idee specială pentru o promoție de Paști: clienții (noi sau existenți) ale căror cifre din IBAN formează un palindrom vor primi un cadou de la iepurașul de Paști în valoare de 512 RON.

Șeful, care nu prea are treabă cu programarea, vă trimite un e-mail cu următorul conținut:
> Salut,
>
> Te laudă colegii că scrii cod solid, extorsionezi metode și vorbești de bune practici precum TDD și alte acronime.
>
> Te rog să-mi extorsionezi o metodă solidă în TDD cu ajutorul căreia să putem identifica dacă cifrele unui IBAN sunt palindrom. Totodată, vreau să-mi explici cum trece codul sursă din lichid în solid și dacă mai are alte stări de agregare.
>
> Trec diseară pe la tine la birou să-mi arăți ce-ai făcut.

După ce ați citit de câteva ori e-mailul, vă dați seama că, de fapt, șeful vrea să creați o **metodă de extensiune** care să determine dacă cifrele numărului IBAN sunt palindrom iar *codul solid* se referă la **principiile SOLID** pe care le-ați menționat ieri într-o discuție cu colegul Andrei, alături de stilul **TDD** și bunele practici legate de istoricul codului-sursă.

Făcându-vă o notă să fiți mai atent(ă) în discuțiile viitoare cu Andrei, începeți să vă faceți o listă de acțiuni pentru a îndeplini sarcina primită:
- Să creați o bibliotecă în limbajul `C#` care să conțină metoda de extensiune `IsPalindrome`,
- Să creați un modul de teste pentru metoda nouă pentru a lucra în stilul TDD,
- Să creați un document pentru a explica principiile SOLID deoarece explicațiile vor fi utilie și pentru alți colegi.


## Cerințe ##
  1. Faceți fork la acest proiect.
  2. În fork-ul vostru creați un director cu numele utilizatorului vostru GitHub. Ex. `mkdir numeutilizator`.
  3. În directorul `numeutilizator` creați alte două directoare: `docs` și `src`.
  4. În directorul `docs` creați un fișier `README.md` și completați cerințele teoretice respectând sintaxa markdown. Documentul final trebuie să aibă un titlu și câte o secțiune cu subtitlu și descriere pentru fiecare principiu descris.
  5. În directorul `src` creați o soluție `Visual Studio` nouă în care să implementați metoda `IsPalindrome` și testele pentru aceasta aplicând bunele practici discutate în cursurile și laboratoarele anterioare.
  6. După ce ați completat cerințele sau la sfârșit laboratorului creați un pull-request.
## Observații ##
  - Pentru cerințele de mai sus trebuie să lucrați exclusiv în timpul alocat laboratorului. Pull-request-ul cu rezolvarea trebuie să fie inițiat înainte de sfârșitul laboratorului.
  - Fiecare student va iniția *un singur pull-request*.
  - Pentru a genera valori IBAN folosiți [Random Iban Generator](http://www.randomiban.com/?country=Romania "Random Iban Generator").
  - Structura IBAN este descrisă în [Standard IBAN Format in Romania](https://bank.codes/iban/structure/romania/ "Standard IBAN Format in Romania"). Pentru aplicația de față vom considera că numărul de cont este alcătuit doar din cifre.
