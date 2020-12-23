# IzuzeciZad5

Kreirati klasu Vector koja sadrži:
 Private int n: broj elemenata vektora
 Private int[] niz: niz elemenata

Kreirati interfejs IIterator koji sadrži sledeće metode:
 Bool existMore() – proverava da li ima još elemenata u kolekciji;
 Void next() – prelazi na sledeći element u kolekciji i
 Int current() – vraća vrednost tekućeg elementa,
 Void reset() – poĉinje obilazak od poĉetka kolekcije.

Kreirati klasu VectorIterator koja implementira interfejs IIterator opisanu preko:
 Private Vector myVector
 Private int currentIndex

U glavnom delu programa:
 Definisati interfejst IIterator
 Kreirati instance klase Vector
 Preko instance interfejsa kreirati instancu klase VectorIterator
 Demonstrirati upotrebu svih metoda iz interfejsa
