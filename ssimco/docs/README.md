# Principiile SOLID:
- **S** - Single Responsibility Principle

Fiecare modul și clasă ar trebui să fie responsabil de un singur scop și toate componentele modulului sau clasei să servească la îndeplinirea acelui scop. 

- **O** - Open-Closed Principle

Să putem extinde orice modul fără să schimbăm conținutul său, ceea ce ne permite să schimbăm comportamentul codului nostru fără sa fi atins codul original al modulului.

- **L** - Liskov Substitution Principle

Putem substitui orice tip cu un subtip de al său si aplicația va funcționa tot la fel de bine.

- **I** - Interface Segregation Principle

Să avem mai multe interfețe mici și specifice cerinței noastre decât să fie mari și sa aibe multe metode de care nu avem nevoie pentru cerința noastră.

- **D** - Dependency Inversion Principle

Modulele unui sistem software trebuie să depindă de reprezentări abstracte și nu de implementări concrete, i.e., dacă vrem să folosim un modul în alt modul ar trebui să folosim o abstractizare a modulului care va decupla cele două module și la rândul sau acele abstractizări ale modulelor nu ar trebui să depindă de detalii dar detalii ar trebui să depindă de abstractizari.