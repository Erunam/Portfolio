<table cellpadding="0" cellspacing="0" border="0" align="center" class="portfolio">
   <tr><td class="text" style="text-align: center;" style="padding: 6pt 0pt 6pt 0pt;">
      <a href="index.php?page=2" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=4" class="manual"> [nastêpna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre¶ci]</a>
      "Aquarium" - PHP TemplateSystem
   </td></tr>
   <tr><td class="text">
   <div>
   
   <span style="font-size:14px; font-weight: bold">
         3. Klasa Template - podstawowa funkcjonalno¶æ <br /></span>
   
   <p class="manual">
   Rozdzia³ opisuje podstawow± klasê systemu - Template. Po krótkim wprowadzeniu, znajduje siê
   szczegó³owy opis u¿ycia i konfiguracji klasy. Pe³niê mo¿liwo¶ci prezentuje ostatnia czê¶æ
   rozdzia³u - opis metod.
   </p>
   
   <a name="target" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Skrócony opis klasy</span><p>
   
   <p class="manual">
   Klasa Template jest bazow± klas± systemu szablonów "Aquarium" - PHP TemplateSystem. Zasadniczym
   zadaniem obiektów tej klasy jest przetwarzanie szablonów do postaci wynikowej. Klasa
   umo¿liwia przetwarzanie szablonów w trybie pojedynczym oraz sumuj±cym. Wynik przetwarzania jest
   zapamiêtywany jako warto¶æ pola klasy, przy czym praca w trybie pojedynczym spowoduje
   nadpisanie istniej±cego pola, w trybie sumuj±cym wynik przetwarzanie szablonu zostanie dopisany
   do istniej±cego pola.
   Klasa jest ponadto zaopatrzona w metodê s³u¿±c± do "rêcznego" wype³niania pól szablonu oraz 
   metodê pozwalaj±c± na wy¶wietlenie b±d¼ pobranie przetworzonego szablonu.
   </p>
      
   <a name="using" ></a>
   <p><span style="font-size:12px; font-weight: bold"> U¿ycie i konfiguracja klasy</span><p>

   <p class="manual">
   Klasê mo¿na u¿yæ w programie po do³±czeniu jest do kodu - zalecamy instrukcjê <br />
   <b>require_once('./¶cie¿ka_do_katalogu_z_klasami/template.class.php')</b>
   </p>

   <p class="manual" style="margin-bottom:2pt;">
   Aby prawid³owo u¿yæ klasê w swoich aplikacjach nale¿y posiadaæ przygotowane wcze¶niej szablony.
   Poni¿ej odno¶niki do szablonów u¿ywanych jako przyk³ad dzia³ania klasy - ka¿dy z nich otworzy
   siê w osobnym, ma³ym okienku: </p>
      <ul class="manual" >
         <li /><a href=# class="manual" 
onclick="document.open('source.php?source=main_t.html','','width=400,height=400,resizable=1')">
         main_t.html.php - plik g³ówny strony, zawiera 2 pola: {title} oraz {main}. </a>
         <li /><a href=# class="manual"
onclick="document.open('source.php?source=table_t.html','','width=400,height=400,resizable=1')">
         table_t.html.php - to bêdzie zawarto¶æ sekcji body, zawiera 1 pole: {rows} </a>
         <li /><a href=# class="manual"
onclick="document.open('source.php?source=row_t.html','','width=400,height=400,resizable=1')"> 
         row_t.html.php - pojedynczy rz±d tabeli, posiada 2 komórki i 2 pola {number} oraz {name}
         </a>
   </ul>
   <p class="manual">
   Pliki szablonów domy¶lnie powinny znajdowaæ siê w podkatalogu "/templates". Je¶li u¿ytkownik
   u¿ywa innego katalogu dla przechowywania szablonów to konieczne bêdzie zdefiniowanie ¶cie¿ki
   dostêpu do tego katalogu.
   </p>
   <p class="manual">
   <b>1. Nowy Obiekt - Template</b> <br />
   Po do³±czeniu pliku definicji klasy mo¿na utworzyæ nowy obiekt za pomoc± instrukcji <br />
   <b>$zmienna = new Template(¶cie¿ka_do_katalogu_g³ównego)</b>. <br />
   $zmienna jest dowoln±, zgodn± ze sk³adni± jêzyka nazw± obiektu klasy. W nawiasie nale¿y podaæ
   ¶cie¿kê dostêu do katalogu g³ównego systemu. Jest to katalog do którego zosta³ rozpakowany
   pakiet "Aquarium PHP TemplateSystem". Domy¶lnie jest to warto¶æ "." czyli katalog bie¿±cy dla
   pliku skryptu. Nazwê nale¿y podawaæ bez koñcowego znaku "/".
   Kod skryptu powinien byæ podobny do:
   <pre>
   Przyk³ad 2 u¿ycie klasy.
      &lt?php
         require_once('./classes/template.class.php');
         $page = new Template();
      ?&gt </pre>
   </p>
   <p class="manual">
   Przyk³ad u¿ycia systemu z innego ni¿ domy¶lny katalogu. Za³o¿ono przy tym, ¿e pakiet zosta³ 
   rozpakowany do katalogu o nazwie "aquarium" a katalog zawieraj±cy definicje klas "definicje". 
   <br />
   <pre>
   Przyk³ad 3 u¿ycie klasy - osobny katalog dla systemu
      &lt?php
         require_once('./aquarium/definicje/template.class.php');
         $page = new Template('./aquarium');
      ?&gt </pre>
   <p class="manual">
   <b>2. ¦cie¿ki dostêpu</b> <br />
   Ten punkt jest istotny je¶li u¿ytkownik zdecydowa³ siê u¿ywaæ w³asnych nazw katalogów. <br />
   Klasa Template jako zasobu u¿ywa tylko plików szablonów. ¦cie¿ka dostêpu do szablonów jest 
   rozpoznawana poprzez klucz "template" a jej warto¶ci± domy¶ln± jest "/templates". Do zmiany
   ¶cie¿ki dostêpu s³u¿y metoda <b> set_pathes($path, 'template') </b> <br />.
   parametr <b>$path</b> jest nazw± podkatalogu wg wzoru "/nazwa_katalogu". <br />
   Katalog z szablonami musi znajdowaæ siê w katalogu g³ównym systemu (domy¶lny lub podany jak w
   przyk³adzie 2).
   </p>
   <p class="manual">
   <pre>
   Przyk³ad 4 u¿ycie metody set_pathes.
      &lt?php
         require_once('./classes/template.class.php');
         $page = new Template();
         $page -> set_pathes('/szablony','template');
      ?&gt </pre>
   
   <pre>
   Przyk³ad 5 u¿ycie metody set_pathes - szablony w katalogu "szablony".
              Katalog g³ówny systemu to "aquarium".
      &lt?php
         require_once('./aquarium/classes/template.class.php');
         $page = new Template('./aquarium');
         $page -> set_pathes('szablony','template');
      ?&gt </pre>

   <p class="manual" style="margin-bottom:2pt;">
   <b>3. Przypisywanie szablonów</b> <br />
   System wymaga wskazania tych szablonów, które bêdzie przetwarza³. Szablony s± rozpoznawane
   poprzez swoj± unikaln± nazwê. Dlatego te¿ przed przetwarzaniem konieczne jest podanie
   aliasów dla wszystkich potrzebnych szablonów. Podany alias bêdzie s³u¿y³ dwóm celom: </p>
      <ol class="manual">
         <li /> identyfikacji pliku szablonu do przetworzenia
         <li /> pos³u¿y jako domy¶lna nazwa pola dla wyniku przetwarzania
      </ol>
   <p class="manual" style="margin-top:2pt;">
   Do definiowania aliasów dla szablonów s³u¿y metoda <b>set_file($alias,$file)</b>. Parametr 
   $alias jest unikaln± nazw± dla szablonu, parametr $file to pe³na nazwa pliku szablonu - 
   podana bez ¶cie¿ki dostêpu z rozszerzeniem. Mo¿liwe jest podanie wszystkiech potrzebnych
   definicji w postaci tablicy. W tym przypadku nale¿y u¿yæ metody podaj±c tylko jeden parametr -
   nazwê tablicy. Tablica musi byæ asocjacyjna o formacie $files['alias'] = 'nazwa_pliku.php'.
   Elementami tablicy s± nazwy plików - klucze tablicy to odpowiednie aliasy.</p>
   
   <pre>
   Przyk³ad 6 u¿ycie metody set_file
      &lt?php
         require_once('./aquarium/classes/template.class.php');
         $page = new Template('./aquarium');
         $page -> set_pathes('szablony','template');
         
      // wskazanie pojedynczego szablonu
         $page->set_file('row','row_t.html.php');

      // jednoczesne wskazanie kilku szablonów
         $page->set_file( array ('main' => 'table_t.html.php',
                                 'page' => 'main_t.html.php') 
                        );
      ?&gt </pre>

   <p class="manual" style="margin-bottom:2pt;">
   <b>4. Wype³nianie pól</b> <br />
   Jest to naistotniejsza czê¶æ pracy z systemem. System podmieni tylko te pola, które zna (s±
   wype³nione), dlatego te¿ od tej czynno¶ci zale¿y ostateczny efekt dzia³ania systemu (np. wygl±d
   witryny). Pola mo¿na wype³niæ na dwa sposoby: </p>
      <ol class="manual">
         <li /> podanie warto¶ci (tekstu) w skrypcie - metoda <b>set_field()</b>
         <li /> wype³nienie zawarto¶ci± pliku - metoda <b>parse()</b>
      </ol>
   <p class="manual" style="margin-top:2pt;">
   Pierwsza metoda jest bezpo¶rednim sposobem wype³nienia pól szablonu. Parametry metody
   <b>set_field($field,$value)</b> to: $field - nazwa pola, $value - tekst którym
   system podstawi znalezione w szablonie pole. Mo¿liwe jest wype³nienie wiêcej ni¿ jednego pola
   za pojedynczym wywo³aniem metody. W tym przypadku nale¿y wywo³aæ metodê z tylko jednym
   parametrem - tablic±. Tablica musi mieæ format $field['nazwa_pola'] = 'tekst'; kluczem elementu 
   powinna byæ nazwa pola a warto¶ci± wype³nienie.<br />
   Klasa traktuje podawane pola jako wspólne dla wszystkiech znanych szablonów. 
   Oznacza to, ¿e je¶li dwa ró¿ne szablony posiadaj± pola o
   takiej samej nazwie to w obydwu pojawi siê w ich miejsce taki sam tekst. Ponowne wype³nienie
   istniej±cego pola spowoduje jego nadpisanie.<br />
   Drugi sposób polega na wykorzystaniu metody <b>parse</b>. Metoda s³u¿y do przetwarzania
   szablonów, przy czym wynik jest zapamiêtywany jako wype³nienie pola. Nazwê pola mo¿na podaæ,
   je¶li nie zostanie podana to metoda wype³ni pole o nazwie aliasu przetwarzanego szablonu.</p>
   <pre>
   Przyk³ad 7 wype³nianie pól szablonu
      &lt?php
         require_once('./aquarium/classes/template.class.php');
         $page = new Template('./aquarium');
         $page -> set_pathes('szablony','template');
         $page -> set_file('row','row_t.html.php');
         $page -> set_file( array ('main' => 'table_t.html.php',
                                   'page' => 'main_t.html.php') 
                           );
         // wype³nienie pojedynczego pola
         $page -> set_field( 'title','Example Aquarium Page' );

         for ($i=1;$i<=6;$i++)
         {
            $fieldtable = array ( 'number' => "rz±d $i",
                                  'name' => "numer w dzienniku - $i");
         // wype³nienie kilku pól, nowe warto¶ci zastêpuj± stare
            $page->set_field($fieldtable);
         
         // wype³nienie pola zawarto¶ci± pliku
            $page->parse('.row','rows');
         }
         // wype³nienie pola z pliku, brak nazwy pola spowoduje
         // wype³nienie pola o nazwie aliasu dla szablonu czyli "main"
         $page -> parse('main');
      ?&gt </pre>

   <p class="manual">
   <b>5. Przetwarzanie</b> <br />
   Przygotowane pola mo¿na u¿yæ do uzupe³nienia szablonu. Do podstawienia pól w szablonie s³u¿y
   metoda <b>parse($alias,$field,[$n])</b>. Metoda przetwarza plik o podanej w zmiennej $alias
   nazwie zastêpczej, wynik przetwarzania zapamiêtuje jako pole o nazwie $field. Je¶li dodatkowo
   zostanie podana zmienna $n o warto¶ci ca³kowitej to szablon jest przetwarzany podan± ilo¶æ
   razy. Wywo³anie metody z jednym parametrem ($alias) spowoduje przetworzenie podanego szablonu i
   zapisanie wyniku do pola o takiej samej nazwie.<br />
   Metoda mo¿e pracowaæ w dwóch trybach: pojedynczym lub sumuj±cym.<br />
   Tryb pojedynczy jest domy¶lnym trybem pracy. Przetworzenie szablonu powoduje nadpisanie
   istniej±cego pola.<br />
   Tryb sumuj±cy wywo³uje siê podaj±c alias z kropk± na pocz±tku ('main' - alias; '.main' -
   wywo³anie trybu sumuj±cego). W tym przypadku wynik przetwarzania jest do³±czany na koniec
   istniej±cego pola.<br />
   Metody parse mo¿na z powodzeniem u¿yæ do wype³niania pól szablonu innym szablonem lub
   zawarto¶ci± pliku tekstowego. Przyk³ady u¿ycia metody poni¿ej.</p>
   <pre>
   Przyk³ad 8 przetwarzanie szablonów
      &lt?php
         ...
         // przetwarzanie szablonu w trybie sumuj±cym
         // wynik jest do³±czany do pola "rows"
            $page->parse('.row','rows');
         }
         // wype³nienie pola szablonem, brak nazwy pola spowoduje
         // wype³nienie pola o nazwie aliasu dla szablonu czyli "main"
         $page -> parse('main');
         // przetwarzanie szablonu "page" - plik main_t.html.php
         $page -> parse('page');
      ?&gt </pre>

   <p class="manual">
   <b>6. Wy¶wietlanie</b> <br />
   System jest zaopatrzony w metodê <b>printing()</b> s³u¿ac± do wy¶wietlania przetworzonego
   szablonu. Wywo³anie metody bez parametrów powoduje wy¶wietlenie na ekranie przegl±darki
   ostatnio wype³nionego pola czyli ostatnio przetworzonego szablonu (wynik przetwarzania jest
   zawsze zapamiêtywany w polu). Podanie warto¶ci parametru w wywo³aniu metody wy¶wietli zawarto¶æ
   pola o podanej nazwie. Opcja pozwala wy¶wietliæ dowolne istniej±ce pole.</p>
   <pre>
   Przyk³ad 9 wy¶wietlenie strony
      &lt?php
         ...
         // wy¶wietlenie wygenerowanej strony
         $page -> printing();
      ?&gt </pre>

   <p class="manual" style="border-top:1px solid #0000aa">
   Podane w tym punkcie informacje powinny (subiektywne zdanie autorów) byæ wystarczaj±ce do
   rozpoczêcia pracy z systemem a nawet do tworzenia bardzo rozbudowanych witryn opartych na
   szablonach. Szczegó³y techniczne klasy znajduj± siê w nastêpnym rozdziale. Dok³adne
   prze¶ledzenie dzia³ania klasy jest mo¿liwe po otworzeniu dokumentu "Template - krok po kroku"
   </p>

   <a name="methods" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Mo¿liwo¶ci klasy - opis techniczny klasy</span><p>
   
   <?php include'manual61.php'; ?>
         
   </div>
   </td></tr>
   <tr><td class="text" style="text-align: center;" style="padding: 6pt 0pt 6pt 0pt;">
      <a href="index.php?page=2" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=4" class="manual"> [nastêpna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre¶ci]</a>
      "Aquarium" - PHP TemplateSystem
   </td></tr>
</table>
