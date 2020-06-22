Principiile SOLID 

S Single Responsibility Principle  

O Open-Closed Principle  

L Liskov Substitution Principle 

I Interface Segregation Principle 

D Dependency Inversion Principle 

 

Principiul responsabilitatii unice 

Single Responsibility Principle  

Fiecare modul trebuie să fie responsabil pentru un singur aspect legat de functionalitatea oferită de sistemul software. Mai mult, acel aspect trebuie să fie încapsulat în întregime de modulul responsabil . 

Responsabil de calitatea codului , el are o importanta foarte mare. 

Un exemplu sugestiv este cel realizat la curs. Aveam metoda Withdraw care nu respecta acest principiu, el calcula atat amount in functie de tipul de account, dar si scadea valoarea acestuia din suma mare. Am realizat atunci o clasa separata care sa calculeze comisionul si legatura dintre cele doua era facuta in programs. Astfel metoda Withdraw are o singura operatie de realizat. O problema este faptul ca modificarile facute au dus la nerespectarea principiului OCP. 

 

Open-Closed Principle  

Părtile componente ale unui sistem software trebuie să fie usor de extins dar greu de modificat. 

In cazul exemplului account se poate observa ca este foarte usor de extins clasa Account, astfel noi am realizat CreditAccount, DebitAccount si SavingsAccount. Extinderea este reprezentata de introducerea unei clase derivate.  In legatura cu partea de modificare pentru calcularea comisionului s-ar putea realiza pentru fiecare cont in parte. Clasa ce calcularea a comisionului o facem abstracta si implementam metoda in toate subclasele derivate. 

 

Liskov Substitution Principle 

 Obiectele unui sistem software trebuie să fie substituibile de către instante ale unor subtipuri de obiecte, fără ca substitutia să afecteze corectitudinea sistemului. 

 

Un exemplu reprezentativ in cazul account prezentat la curs este realizarea unei metode care sa afiseze ceea ce dorim noi sa scriem in main, pentru a nu mai exista structuri repetitive. O astfel de metoda calculeaza ceea ce dorim si afiseaza ea fiind variabila in functie de contul dat in functie.  

 

Interface Segregation Principle 

 Interfetele trebuie să fie mici si specifice contextului de utilizare; nu mari si generale. 

 

Realizam clase mici cu nume sugestive , cat mai descriptive. Un exemplu simplu doar pentru a intelege nostiune consta in realizare unei clase Vehicul care are ca metode condu() si zboara(). Avem doua clase Masina si Avion care sunt sublase ale lui Vehicul , dar masina nu poate zbura . Ar trebui realizate clase simple si metode specifice. Spre exemplu pentru masini sa fie o clasa mare Masina care sa aiba metode specifice masinilor si in mod analog pentru avion. 

 

Dependency Inversion Principle 

 Modulele unui sistem software trebuie să depindă de reprezentări abstracte si nu de implementări concrete. 

 

Acest principiu este des utilizat fiind o metoda facila de rezolvare a unor conditii suplimentare. Ca si in cazul pensiunii cu preturi diferite pentru apartament sau garsoniera. Realizam o clasa de baza care sa fie absracta si cu o metoda apstracta care se refera la pretul unui imobil si ulterior in subclase, cea a garsonierei si cea a apartamentului, suprascriem metodele care indica preturile.  