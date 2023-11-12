<table cellpadding="0" cellspacing="0" border="0" align="center" class="portfolio">
   <tr><td class="text" style="text-align: center;" style="padding: 6pt 0pt 6pt 0pt;">
      <a href="index.php?page=2" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=4" class="manual"> [nast�pna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre�ci]</a>
      "Aquarium" - PHP TemplateSystem
   </td></tr>
   <tr><td class="text">
   <div>
   
   <span style="font-size:14px; font-weight: bold">
         3. Klasa Template - podstawowa funkcjonalno�� <br /></span>
   
   <p class="manual">
   Rozdzia� opisuje podstawow� klas� systemu - Template. Po kr�tkim wprowadzeniu, znajduje si�
   szczeg�owy opis u�ycia i konfiguracji klasy. Pe�ni� mo�liwo�ci prezentuje ostatnia cz��
   rozdzia�u - opis metod.
   </p>
   
   <a name="target" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Skr�cony opis klasy</span><p>
   
   <p class="manual">
   Klasa Template jest bazow� klas� systemu szablon�w "Aquarium" - PHP TemplateSystem. Zasadniczym
   zadaniem obiekt�w tej klasy jest przetwarzanie szablon�w do postaci wynikowej. Klasa
   umo�liwia przetwarzanie szablon�w w trybie pojedynczym oraz sumuj�cym. Wynik przetwarzania jest
   zapami�tywany jako warto�� pola klasy, przy czym praca w trybie pojedynczym spowoduje
   nadpisanie istniej�cego pola, w trybie sumuj�cym wynik przetwarzanie szablonu zostanie dopisany
   do istniej�cego pola.
   Klasa jest ponadto zaopatrzona w metod� s�u��c� do "r�cznego" wype�niania p�l szablonu oraz 
   metod� pozwalaj�c� na wy�wietlenie b�d� pobranie przetworzonego szablonu.
   </p>
      
   <a name="using" ></a>
   <p><span style="font-size:12px; font-weight: bold"> U�ycie i konfiguracja klasy</span><p>

   <p class="manual">
   Klas� mo�na u�y� w programie po do��czeniu jest do kodu - zalecamy instrukcj� <br />
   <b>require_once('./�cie�ka_do_katalogu_z_klasami/template.class.php')</b>
   </p>

   <p class="manual" style="margin-bottom:2pt;">
   Aby prawid�owo u�y� klas� w swoich aplikacjach nale�y posiada� przygotowane wcze�niej szablony.
   Poni�ej odno�niki do szablon�w u�ywanych jako przyk�ad dzia�ania klasy - ka�dy z nich otworzy
   si� w osobnym, ma�ym okienku: </p>
      <ul class="manual" >
         <li /><a href=# class="manual" 
onclick="document.open('source.php?source=main_t.html','','width=400,height=400,resizable=1')">
         main_t.html.php - plik g��wny strony, zawiera 2 pola: {title} oraz {main}. </a>
         <li /><a href=# class="manual"
onclick="document.open('source.php?source=table_t.html','','width=400,height=400,resizable=1')">
         table_t.html.php - to b�dzie zawarto�� sekcji body, zawiera 1 pole: {rows} </a>
         <li /><a href=# class="manual"
onclick="document.open('source.php?source=row_t.html','','width=400,height=400,resizable=1')"> 
         row_t.html.php - pojedynczy rz�d tabeli, posiada 2 kom�rki i 2 pola {number} oraz {name}
         </a>
   </ul>
   <p class="manual">
   Pliki szablon�w domy�lnie powinny znajdowa� si� w podkatalogu "/templates". Je�li u�ytkownik
   u�ywa innego katalogu dla przechowywania szablon�w to konieczne b�dzie zdefiniowanie �cie�ki
   dost�pu do tego katalogu.
   </p>
   <p class="manual">
   <b>1. Nowy Obiekt - Template</b> <br />
   Po do��czeniu pliku definicji klasy mo�na utworzy� nowy obiekt za pomoc� instrukcji <br />
   <b>$zmienna = new Template(�cie�ka_do_katalogu_g��wnego)</b>. <br />
   $zmienna jest dowoln�, zgodn� ze sk�adni� j�zyka nazw� obiektu klasy. W nawiasie nale�y poda�
   �cie�k� dost�u do katalogu g��wnego systemu. Jest to katalog do kt�rego zosta� rozpakowany
   pakiet "Aquarium PHP TemplateSystem". Domy�lnie jest to warto�� "." czyli katalog bie��cy dla
   pliku skryptu. Nazw� nale�y podawa� bez ko�cowego znaku "/".
   Kod skryptu powinien by� podobny do:
   <pre>
   Przyk�ad 2 u�ycie klasy.
      &lt?php
         require_once('./classes/template.class.php');
         $page = new Template();
      ?&gt </pre>
   </p>
   <p class="manual">
   Przyk�ad u�ycia systemu z innego ni� domy�lny katalogu. Za�o�ono przy tym, �e pakiet zosta� 
   rozpakowany do katalogu o nazwie "aquarium" a katalog zawieraj�cy definicje klas "definicje". 
   <br />
   <pre>
   Przyk�ad 3 u�ycie klasy - osobny katalog dla systemu
      &lt?php
         require_once('./aquarium/definicje/template.class.php');
         $page = new Template('./aquarium');
      ?&gt </pre>
   <p class="manual">
   <b>2. �cie�ki dost�pu</b> <br />
   Ten punkt jest istotny je�li u�ytkownik zdecydowa� si� u�ywa� w�asnych nazw katalog�w. <br />
   Klasa Template jako zasobu u�ywa tylko plik�w szablon�w. �cie�ka dost�pu do szablon�w jest 
   rozpoznawana poprzez klucz "template" a jej warto�ci� domy�ln� jest "/templates". Do zmiany
   �cie�ki dost�pu s�u�y metoda <b> set_pathes($path, 'template') </b> <br />.
   parametr <b>$path</b> jest nazw� podkatalogu wg wzoru "/nazwa_katalogu". <br />
   Katalog z szablonami musi znajdowa� si� w katalogu g��wnym systemu (domy�lny lub podany jak w
   przyk�adzie 2).
   </p>
   <p class="manual">
   <pre>
   Przyk�ad 4 u�ycie metody set_pathes.
      &lt?php
         require_once('./classes/template.class.php');
         $page = new Template();
         $page -> set_pathes('/szablony','template');
      ?&gt </pre>
   
   <pre>
   Przyk�ad 5 u�ycie metody set_pathes - szablony w katalogu "szablony".
              Katalog g��wny systemu to "aquarium".
      &lt?php
         require_once('./aquarium/classes/template.class.php');
         $page = new Template('./aquarium');
         $page -> set_pathes('szablony','template');
      ?&gt </pre>

   <p class="manual" style="margin-bottom:2pt;">
   <b>3. Przypisywanie szablon�w</b> <br />
   System wymaga wskazania tych szablon�w, kt�re b�dzie przetwarza�. Szablony s� rozpoznawane
   poprzez swoj� unikaln� nazw�. Dlatego te� przed przetwarzaniem konieczne jest podanie
   alias�w dla wszystkich potrzebnych szablon�w. Podany alias b�dzie s�u�y� dw�m celom: </p>
      <ol class="manual">
         <li /> identyfikacji pliku szablonu do przetworzenia
         <li /> pos�u�y jako domy�lna nazwa pola dla wyniku przetwarzania
      </ol>
   <p class="manual" style="margin-top:2pt;">
   Do definiowania alias�w dla szablon�w s�u�y metoda <b>set_file($alias,$file)</b>. Parametr 
   $alias jest unikaln� nazw� dla szablonu, parametr $file to pe�na nazwa pliku szablonu - 
   podana bez �cie�ki dost�pu z rozszerzeniem. Mo�liwe jest podanie wszystkiech potrzebnych
   definicji w postaci tablicy. W tym przypadku nale�y u�y� metody podaj�c tylko jeden parametr -
   nazw� tablicy. Tablica musi by� asocjacyjna o formacie $files['alias'] = 'nazwa_pliku.php'.
   Elementami tablicy s� nazwy plik�w - klucze tablicy to odpowiednie aliasy.</p>
   
   <pre>
   Przyk�ad 6 u�ycie metody set_file
      &lt?php
         require_once('./aquarium/classes/template.class.php');
         $page = new Template('./aquarium');
         $page -> set_pathes('szablony','template');
         
      // wskazanie pojedynczego szablonu
         $page->set_file('row','row_t.html.php');

      // jednoczesne wskazanie kilku szablon�w
         $page->set_file( array ('main' => 'table_t.html.php',
                                 'page' => 'main_t.html.php') 
                        );
      ?&gt </pre>

   <p class="manual" style="margin-bottom:2pt;">
   <b>4. Wype�nianie p�l</b> <br />
   Jest to naistotniejsza cz�� pracy z systemem. System podmieni tylko te pola, kt�re zna (s�
   wype�nione), dlatego te� od tej czynno�ci zale�y ostateczny efekt dzia�ania systemu (np. wygl�d
   witryny). Pola mo�na wype�ni� na dwa sposoby: </p>
      <ol class="manual">
         <li /> podanie warto�ci (tekstu) w skrypcie - metoda <b>set_field()</b>
         <li /> wype�nienie zawarto�ci� pliku - metoda <b>parse()</b>
      </ol>
   <p class="manual" style="margin-top:2pt;">
   Pierwsza metoda jest bezpo�rednim sposobem wype�nienia p�l szablonu. Parametry metody
   <b>set_field($field,$value)</b> to: $field - nazwa pola, $value - tekst kt�rym
   system podstawi znalezione w szablonie pole. Mo�liwe jest wype�nienie wi�cej ni� jednego pola
   za pojedynczym wywo�aniem metody. W tym przypadku nale�y wywo�a� metod� z tylko jednym
   parametrem - tablic�. Tablica musi mie� format $field['nazwa_pola'] = 'tekst'; kluczem elementu 
   powinna by� nazwa pola a warto�ci� wype�nienie.<br />
   Klasa traktuje podawane pola jako wsp�lne dla wszystkiech znanych szablon�w. 
   Oznacza to, �e je�li dwa r�ne szablony posiadaj� pola o
   takiej samej nazwie to w obydwu pojawi si� w ich miejsce taki sam tekst. Ponowne wype�nienie
   istniej�cego pola spowoduje jego nadpisanie.<br />
   Drugi spos�b polega na wykorzystaniu metody <b>parse</b>. Metoda s�u�y do przetwarzania
   szablon�w, przy czym wynik jest zapami�tywany jako wype�nienie pola. Nazw� pola mo�na poda�,
   je�li nie zostanie podana to metoda wype�ni pole o nazwie aliasu przetwarzanego szablonu.</p>
   <pre>
   Przyk�ad 7 wype�nianie p�l szablonu
      &lt?php
         require_once('./aquarium/classes/template.class.php');
         $page = new Template('./aquarium');
         $page -> set_pathes('szablony','template');
         $page -> set_file('row','row_t.html.php');
         $page -> set_file( array ('main' => 'table_t.html.php',
                                   'page' => 'main_t.html.php') 
                           );
         // wype�nienie pojedynczego pola
         $page -> set_field( 'title','Example Aquarium Page' );

         for ($i=1;$i<=6;$i++)
         {
            $fieldtable = array ( 'number' => "rz�d $i",
                                  'name' => "numer w dzienniku - $i");
         // wype�nienie kilku p�l, nowe warto�ci zast�puj� stare
            $page->set_field($fieldtable);
         
         // wype�nienie pola zawarto�ci� pliku
            $page->parse('.row','rows');
         }
         // wype�nienie pola z pliku, brak nazwy pola spowoduje
         // wype�nienie pola o nazwie aliasu dla szablonu czyli "main"
         $page -> parse('main');
      ?&gt </pre>

   <p class="manual">
   <b>5. Przetwarzanie</b> <br />
   Przygotowane pola mo�na u�y� do uzupe�nienia szablonu. Do podstawienia p�l w szablonie s�u�y
   metoda <b>parse($alias,$field,[$n])</b>. Metoda przetwarza plik o podanej w zmiennej $alias
   nazwie zast�pczej, wynik przetwarzania zapami�tuje jako pole o nazwie $field. Je�li dodatkowo
   zostanie podana zmienna $n o warto�ci ca�kowitej to szablon jest przetwarzany podan� ilo��
   razy. Wywo�anie metody z jednym parametrem ($alias) spowoduje przetworzenie podanego szablonu i
   zapisanie wyniku do pola o takiej samej nazwie.<br />
   Metoda mo�e pracowa� w dw�ch trybach: pojedynczym lub sumuj�cym.<br />
   Tryb pojedynczy jest domy�lnym trybem pracy. Przetworzenie szablonu powoduje nadpisanie
   istniej�cego pola.<br />
   Tryb sumuj�cy wywo�uje si� podaj�c alias z kropk� na pocz�tku ('main' - alias; '.main' -
   wywo�anie trybu sumuj�cego). W tym przypadku wynik przetwarzania jest do��czany na koniec
   istniej�cego pola.<br />
   Metody parse mo�na z powodzeniem u�y� do wype�niania p�l szablonu innym szablonem lub
   zawarto�ci� pliku tekstowego. Przyk�ady u�ycia metody poni�ej.</p>
   <pre>
   Przyk�ad 8 przetwarzanie szablon�w
      &lt?php
         ...
         // przetwarzanie szablonu w trybie sumuj�cym
         // wynik jest do��czany do pola "rows"
            $page->parse('.row','rows');
         }
         // wype�nienie pola szablonem, brak nazwy pola spowoduje
         // wype�nienie pola o nazwie aliasu dla szablonu czyli "main"
         $page -> parse('main');
         // przetwarzanie szablonu "page" - plik main_t.html.php
         $page -> parse('page');
      ?&gt </pre>

   <p class="manual">
   <b>6. Wy�wietlanie</b> <br />
   System jest zaopatrzony w metod� <b>printing()</b> s�u�ac� do wy�wietlania przetworzonego
   szablonu. Wywo�anie metody bez parametr�w powoduje wy�wietlenie na ekranie przegl�darki
   ostatnio wype�nionego pola czyli ostatnio przetworzonego szablonu (wynik przetwarzania jest
   zawsze zapami�tywany w polu). Podanie warto�ci parametru w wywo�aniu metody wy�wietli zawarto��
   pola o podanej nazwie. Opcja pozwala wy�wietli� dowolne istniej�ce pole.</p>
   <pre>
   Przyk�ad 9 wy�wietlenie strony
      &lt?php
         ...
         // wy�wietlenie wygenerowanej strony
         $page -> printing();
      ?&gt </pre>

   <p class="manual" style="border-top:1px solid #0000aa">
   Podane w tym punkcie informacje powinny (subiektywne zdanie autor�w) by� wystarczaj�ce do
   rozpocz�cia pracy z systemem a nawet do tworzenia bardzo rozbudowanych witryn opartych na
   szablonach. Szczeg�y techniczne klasy znajduj� si� w nast�pnym rozdziale. Dok�adne
   prze�ledzenie dzia�ania klasy jest mo�liwe po otworzeniu dokumentu "Template - krok po kroku"
   </p>

   <a name="methods" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Mo�liwo�ci klasy - opis techniczny klasy</span><p>
   
   <?php include'manual61.php'; ?>
         
   </div>
   </td></tr>
   <tr><td class="text" style="text-align: center;" style="padding: 6pt 0pt 6pt 0pt;">
      <a href="index.php?page=2" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=4" class="manual"> [nast�pna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre�ci]</a>
      "Aquarium" - PHP TemplateSystem
   </td></tr>
</table>
