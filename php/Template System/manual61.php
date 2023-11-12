   <p class="manual" style="margin-bottom:2pt;">
   <span style="font-size:12px; font-weight: bold;">Pola klasy</span></p>
   <dl style="margin-left:12pt; margin-top: 0pt; margin-bottom:0pt;">
      <dt /> array <b>pathes</b> ['nazwa zasobu'] = '�cie�ka do zasobu'
      <dd />Pole przechowuje �cie�ki dost�pu. Posiada dwa elementy<br />
            pathes['root'] = './' - katalog g��wny systemu<br />
            pathes['template'] = 'templates' - nazwa podkatalogu z plikami szablonu<br />
      <dt /> array <b>filelist</b> ['alias'] = 'nazwa pliku wraz ze �cie�k�'
      <dd />Pole przechowuje nazwy zast�pcze (aliasy) dla plik�w - tablica uchwyt�w<br />
      <dt /> array <b>fieldlist</b> ['nazwa pola'] = 'warto�� tekstowa'
      <dd />Pole przechowuje warto�ci dla p�l szablonu.
      <dt /> string <b>last</b>
      <dd />Pole przechowuje nazw� ostatnio u�ywanego przez metod� parse pola szablonu
   </dl>
   <p class="manual" style="margin-bottom:2pt;">
   <span style="font-size:12px; font-weight: bold;">Metody podstawowe</span></p>
   <dl style="margin-left:12pt; margin-top: 0pt; margin-bottom:0pt;">
      <dt /><b>Template</b> - konstruktor<br />
      wywo�anie: <b> Template ( <i>mixed</i> path ) </b>
      <dd />
      Inicjuje nowy obiekt. Wywo�any bez argument�w zainicjuje obiekt z domy�lnymi �cie�kami
      dost�pu do zasob�w. Przyjmuje dwa rodzaje parametr�w wywo�ania:<br />
      tekstowy - �cie�ka dost�u do katalogu g��wnego szablonu (element pathes['root'])<br />
      tablicowy dwuelementowy - traktowany jako zbi�r �cie�ek dost�pu o kluczach identycznych 
      z polem pathes.
      <dt /><b>set_pathes</b> - ustawia �cie�ki dost�pu<br />
      wywo�anie:  <b><i>bool</i> set_pathes ( <i>string</i> path, <i>string</i> res )</b> lub 
                  <b><i>bool</i> set_pathes ( <i>array</i> pathes )</b><br />
      <dd />
      Parametr res mo�e przyj�� dwie warto�ci res = 'root' i wtedy 'path' to �cie�ka dost�pu
      do katalogu systemu lub res = 'template' i wtedy 'path' to nazwa podkatalogu z szablonami.
      Metoda akceptuje wywo�anie z parametrem tablicowym. W tym przypadku tablica musi mie�
      idenczne klucze jak pole <b>pathes</b>
      <dt /><b>set_file</b> - definiuje nazwy zast�pcze (aliasy) dla plik�w szablon�w.<br />
      wywo�anie: <b><i>bool</i> set_file ( <i>string</i> alias, <i>string</i> file ) </b> lub 
                 <b><i>bool</i> set_file ( <i>array</i> filelist ) </b>
      <dd />
      Metoda przypisuje nazw� podan� w parametrze alias do pliku o nazwie file. W przypadku
      wywo�ania z jednym parametrem musi to by� tablica asocjacyjna. Kluczem w tablicy jest
      alias dla pliku, odpowiadaj�ca mu warto�� to nazwa pliku. Metoda operuje na tablicy
      <b>filelist</b>.
      <dt /><b>set_field</b> - przypisuje zawarto�� do p�l szablonu<br />
      wywo�anie: <b><i>bool</i> set_field ( <i>string</i> field, <i>string</i> value ) </b> lub 
                 <b><i>bool</i> set_file ( <i>array</i> fieldlist ) </b>
      <dd /> 
      Metoda wype�nia pole o podanej poprzez field nazwie ci�giem tekstowym podanym w parametrze
      value. Akceptuje parametr tablicowy (wtedy tylko jeden). Klucz w tablicy to nazwa pola a
      warto�� elemntu to ci�g tekstowy do podstawienia w szablonie.W przypadku gdy pole nie
      istnieje, to zostanie utworzone. Metoda operuje na tablicy <b>fieldlist</b>
      <dt /><b>parse</b> - przetwarza plik szablonu<br />
      wywo�anie:  <b>parse ( <i>string</i> alias, <i>string</i> field, [<i>int</i> n]) </b> lub
                  <b>parse ( <i>string</i> alias, [<i>int</i> n]) </b>
      <dd />
      Metoda przetwarza podany przez alias plik. Podana jako alias nazwa musi by� wcze�niej
      zdefiniowana jako identyfikator pliku (metod� set_files). Przetworzony plik jest
      zapami�tywany jako wype�nienie pola o nazwie podanej jako parametr field. Domy�lnie metoda
      nadpisuje istniej�ce pole. Do��czenie przetworzonego szablonu do istniej�cego pola jest
      mo�liwe w trybie sumuj�cym. Przetwarzanie sumuj�ce wywo�uje si� przez podanie zmiennej alias
      z kropk� na pocz�tku nazwy. W przypadku nie podania parametru field metoda traktuje alias
      jako identyfikator pliku i jako nazw� pola. Podanie parametru n spowoduje przetworzenie
      szablonu w trybie sumuj�cym podan� ilo�� razy. Od strony technicznej metoda pobiera
      wskazywany w pathes plik, przetwarza go a wynik zapisuje do fieldlist.
      <dt /><b>printing</b> - wys�anie przetworzonego szablonu do przegl�darki<br />
      wywo�anie: <b>printing ( [<i>string</i> field] )</b>
      <dd /> 
      Metoda wysy�a ostatnio wype�nione przez metod� parse pole do przegl�darki. Podanie parametru
      spowoduje wy�wietlenie aktualnej zawarto�ci pola o podanej nazwie. Metoda operuje na tablicy
      fieldlist.
      <dt /><b>get_field</b> - pobiera zawarto�� istniej�cego pola do zmiennej<br />
      wywo�anie: <b> <i>string</i> get_field ( [<i>string</i> field] ) </b>
      <dd />
      Metoda pobiera wype�nienie pola o podanej nazwie i zwraca je jako zmienn� tekstow�. Je�li
      nie podano paramtru to zwraca zawarto�� ostatnio wype�nionego przez parse pola. Metoda
      operuje na tablicy fieldlist.
   </dl>
   <p class="manual" style="margin-bottom:2pt;">
   <span style="font-size:12px; font-weight: bold;">Metody dodatkowe</span></p>
   <dl style="margin-left:12pt; margin-top: 0pt; margin-bottom:0pt;">
      <dt /><b>get_file</b> - pobiera pe�n� nazw� pliku o podanym identyfikatorze <br />
      wywo�anie: <b><i>string</i> get_file ( <i>string</i> alias )</b>
      <dd /> 
      Metoda zwraca �cie�k� dost�pu wraz z nazw� pliku do szablonu wcze�niej zdefiniowanego jako
      alias. Metoda operuje na tablicy filelist.
      <dt /><b>load_template</b> - pobiera zawarto�� pliku <br />
      wywo�anie: <b><i>string</i> load_template ( <i>string</i> alias ) </b>
      <dd />
      Metoda czyta zawarto�� pliku o padanym przez alias identyfikatorze. Zawarto�� pliku jest
      zwracana jako zmienna �a�cuchowa bez znak�w specjalnych.
      <dt /><b>replacement</b> - wstawia wype�nienie w miejsce istniej�cego w szablonie pola <br />
      wywo�anie: <b><i>string</i> replacement ( <i>string</i> alias ) </b>
      <dd /> 
      Wczytuje podany przez alias plik szablonu i zamienia znajduj�ce si� w nim pola przez
      istniej�ce wype�nienie. Podstawione zostan� tylko te pola, kt�re s� wype�nione. Metoda
      zwraca podstawiony w ten spos�b ci�g tekstowy. Jako bazy p�l metoda u�ywa tablicy fieldlist,
      jako bazy plik�w tablicy filelist.
   </dl>
