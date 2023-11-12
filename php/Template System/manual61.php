   <p class="manual" style="margin-bottom:2pt;">
   <span style="font-size:12px; font-weight: bold;">Pola klasy</span></p>
   <dl style="margin-left:12pt; margin-top: 0pt; margin-bottom:0pt;">
      <dt /> array <b>pathes</b> ['nazwa zasobu'] = '¶cie¿ka do zasobu'
      <dd />Pole przechowuje ¶cie¿ki dostêpu. Posiada dwa elementy<br />
            pathes['root'] = './' - katalog g³ówny systemu<br />
            pathes['template'] = 'templates' - nazwa podkatalogu z plikami szablonu<br />
      <dt /> array <b>filelist</b> ['alias'] = 'nazwa pliku wraz ze ¶cie¿k±'
      <dd />Pole przechowuje nazwy zastêpcze (aliasy) dla plików - tablica uchwytów<br />
      <dt /> array <b>fieldlist</b> ['nazwa pola'] = 'warto¶æ tekstowa'
      <dd />Pole przechowuje warto¶ci dla pól szablonu.
      <dt /> string <b>last</b>
      <dd />Pole przechowuje nazwê ostatnio u¿ywanego przez metodê parse pola szablonu
   </dl>
   <p class="manual" style="margin-bottom:2pt;">
   <span style="font-size:12px; font-weight: bold;">Metody podstawowe</span></p>
   <dl style="margin-left:12pt; margin-top: 0pt; margin-bottom:0pt;">
      <dt /><b>Template</b> - konstruktor<br />
      wywo³anie: <b> Template ( <i>mixed</i> path ) </b>
      <dd />
      Inicjuje nowy obiekt. Wywo³any bez argumentów zainicjuje obiekt z domy¶lnymi ¶cie¿kami
      dostêpu do zasobów. Przyjmuje dwa rodzaje parametrów wywo³ania:<br />
      tekstowy - ¶cie¿ka dostêu do katalogu g³ównego szablonu (element pathes['root'])<br />
      tablicowy dwuelementowy - traktowany jako zbiór ¶cie¿ek dostêpu o kluczach identycznych 
      z polem pathes.
      <dt /><b>set_pathes</b> - ustawia ¶cie¿ki dostêpu<br />
      wywo³anie:  <b><i>bool</i> set_pathes ( <i>string</i> path, <i>string</i> res )</b> lub 
                  <b><i>bool</i> set_pathes ( <i>array</i> pathes )</b><br />
      <dd />
      Parametr res mo¿e przyj±æ dwie warto¶ci res = 'root' i wtedy 'path' to ¶cie¿ka dostêpu
      do katalogu systemu lub res = 'template' i wtedy 'path' to nazwa podkatalogu z szablonami.
      Metoda akceptuje wywo³anie z parametrem tablicowym. W tym przypadku tablica musi mieæ
      idenczne klucze jak pole <b>pathes</b>
      <dt /><b>set_file</b> - definiuje nazwy zastêpcze (aliasy) dla plików szablonów.<br />
      wywo³anie: <b><i>bool</i> set_file ( <i>string</i> alias, <i>string</i> file ) </b> lub 
                 <b><i>bool</i> set_file ( <i>array</i> filelist ) </b>
      <dd />
      Metoda przypisuje nazwê podan± w parametrze alias do pliku o nazwie file. W przypadku
      wywo³ania z jednym parametrem musi to byæ tablica asocjacyjna. Kluczem w tablicy jest
      alias dla pliku, odpowiadaj±ca mu warto¶æ to nazwa pliku. Metoda operuje na tablicy
      <b>filelist</b>.
      <dt /><b>set_field</b> - przypisuje zawarto¶æ do pól szablonu<br />
      wywo³anie: <b><i>bool</i> set_field ( <i>string</i> field, <i>string</i> value ) </b> lub 
                 <b><i>bool</i> set_file ( <i>array</i> fieldlist ) </b>
      <dd /> 
      Metoda wype³nia pole o podanej poprzez field nazwie ci±giem tekstowym podanym w parametrze
      value. Akceptuje parametr tablicowy (wtedy tylko jeden). Klucz w tablicy to nazwa pola a
      warto¶æ elemntu to ci±g tekstowy do podstawienia w szablonie.W przypadku gdy pole nie
      istnieje, to zostanie utworzone. Metoda operuje na tablicy <b>fieldlist</b>
      <dt /><b>parse</b> - przetwarza plik szablonu<br />
      wywo³anie:  <b>parse ( <i>string</i> alias, <i>string</i> field, [<i>int</i> n]) </b> lub
                  <b>parse ( <i>string</i> alias, [<i>int</i> n]) </b>
      <dd />
      Metoda przetwarza podany przez alias plik. Podana jako alias nazwa musi byæ wcze¶niej
      zdefiniowana jako identyfikator pliku (metod± set_files). Przetworzony plik jest
      zapamiêtywany jako wype³nienie pola o nazwie podanej jako parametr field. Domy¶lnie metoda
      nadpisuje istniej±ce pole. Do³±czenie przetworzonego szablonu do istniej±cego pola jest
      mo¿liwe w trybie sumuj±cym. Przetwarzanie sumuj±ce wywo³uje siê przez podanie zmiennej alias
      z kropk± na pocz±tku nazwy. W przypadku nie podania parametru field metoda traktuje alias
      jako identyfikator pliku i jako nazwê pola. Podanie parametru n spowoduje przetworzenie
      szablonu w trybie sumuj±cym podan± ilo¶æ razy. Od strony technicznej metoda pobiera
      wskazywany w pathes plik, przetwarza go a wynik zapisuje do fieldlist.
      <dt /><b>printing</b> - wys³anie przetworzonego szablonu do przegl±darki<br />
      wywo³anie: <b>printing ( [<i>string</i> field] )</b>
      <dd /> 
      Metoda wysy³a ostatnio wype³nione przez metodê parse pole do przegl±darki. Podanie parametru
      spowoduje wy¶wietlenie aktualnej zawarto¶ci pola o podanej nazwie. Metoda operuje na tablicy
      fieldlist.
      <dt /><b>get_field</b> - pobiera zawarto¶æ istniej±cego pola do zmiennej<br />
      wywo³anie: <b> <i>string</i> get_field ( [<i>string</i> field] ) </b>
      <dd />
      Metoda pobiera wype³nienie pola o podanej nazwie i zwraca je jako zmienn± tekstow±. Je¶li
      nie podano paramtru to zwraca zawarto¶æ ostatnio wype³nionego przez parse pola. Metoda
      operuje na tablicy fieldlist.
   </dl>
   <p class="manual" style="margin-bottom:2pt;">
   <span style="font-size:12px; font-weight: bold;">Metody dodatkowe</span></p>
   <dl style="margin-left:12pt; margin-top: 0pt; margin-bottom:0pt;">
      <dt /><b>get_file</b> - pobiera pe³n± nazwê pliku o podanym identyfikatorze <br />
      wywo³anie: <b><i>string</i> get_file ( <i>string</i> alias )</b>
      <dd /> 
      Metoda zwraca ¶cie¿kê dostêpu wraz z nazw± pliku do szablonu wcze¶niej zdefiniowanego jako
      alias. Metoda operuje na tablicy filelist.
      <dt /><b>load_template</b> - pobiera zawarto¶æ pliku <br />
      wywo³anie: <b><i>string</i> load_template ( <i>string</i> alias ) </b>
      <dd />
      Metoda czyta zawarto¶æ pliku o padanym przez alias identyfikatorze. Zawarto¶æ pliku jest
      zwracana jako zmienna ³añcuchowa bez znaków specjalnych.
      <dt /><b>replacement</b> - wstawia wype³nienie w miejsce istniej±cego w szablonie pola <br />
      wywo³anie: <b><i>string</i> replacement ( <i>string</i> alias ) </b>
      <dd /> 
      Wczytuje podany przez alias plik szablonu i zamienia znajduj±ce siê w nim pola przez
      istniej±ce wype³nienie. Podstawione zostan± tylko te pola, które s± wype³nione. Metoda
      zwraca podstawiony w ten sposób ci±g tekstowy. Jako bazy pól metoda u¿ywa tablicy fieldlist,
      jako bazy plików tablicy filelist.
   </dl>
