# Evaluarea 2

## Principiile SOLID
### S - Single Responsability Principle
  - Principiul responsabilitatii unice/singulare se refera la faptul ca fiecare modul al unei aplicatii software trebuie sa fie responsabil pentru un singur aspect ce tine de functionalitatea aplicatiei.
  - Modulul responsabil pentru un aspect pentru ca incapsuleze in intregime acel aspect. 
### O - Open-Closed Principle
  - Componentele unui sistem software trebuie sa fie usor de extins, dar greu de modificat, mai exact o entitate (de ex o clasa) trebuie sa poate fi extinsa cu usurinta fara a fi modificata.

### L - Liskov Substitution Principle
 - Componentele unui sistem software trebuie sa poate fi substituite de instante ale subtipurilor sale derivate. Substitutia trebuie facuta astfel incat sa nu afecteze corectitudinea sistemului.

### I - Interface Segregation Principle
 - Interfetele trebuie sa fie mici si specifice astfel incat clasele care implementeaza acele interfete sa nu contina metode nefolositoare pentru ele, insa care se folosesc in alte clase derivate.
 
### D - Dependency Inversion Principle
 - Componentele unui sistem software trebuie sa depinda de reprezentari abstracte (interfete de exemplu). Daca ar depinde de implementari concrete testarea si reimplementarea acelor componente ar fi dificile sau chiar nu ar fi posibile.
