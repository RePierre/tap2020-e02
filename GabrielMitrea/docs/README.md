
# Solid

**S**-Single Responsability Principle<br/>
**O**- Open-Closed Principle<br/>
**L**-Liskov Substituion Principle<br/>
**I**-Interface Segregation Principle<br/>
**D**-Dependency Inversion Principle<br/>

### Single Responsability Principle

Fiecare modul trebuie sa fie responsabil pentru un singur aspect legat de funcionalitatea software. Mai mult, acel aspect trebuie sa fie incapsulat in intregime de modulul responsabil.
O clasa sau un modul ar trebui sa aiba unul si doar un singur motiv sa fie schimbata/schimbat.

### Open-Closed Principle

Partile componente ale unui sistem software trebuie să fie usor de extins dar greu de modificat.

### Liskov Substitution Principle

Obiectele unui sistem software trebuie să fie substituibile de către instante ale unor subtipuri de obiecte, fara ca substitutia sa afecteze corectitudinea sistemului.
"if walks like a duck and quacks like a duck then probably is a duck"

### Interface Segregation Principle
Interfetele trebuie sa fie mici si specifice contextului de utilizare nu mari si generale.
Clientii ar trebui sa nu fie fortati sa depinda de interfete pe care nu le folosesc.

### Dependency Inversion Principle

Modulele unui sistem software trebuie să depindă de reprezentări abstracte si nu de implementari concrete.Modulele high level care contin logica complexa ar trebui sa fie usor de utilizat prin modificari in modulele low level.


