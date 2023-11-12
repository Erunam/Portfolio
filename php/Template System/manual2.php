<table cellpadding="0" cellspacing="0" border="0" align="center" class="portfolio">
   <tr><td class="text" style="text-align: center;" style="padding: 6pt 0pt 6pt 0pt;">
      <a href="index.php?page=1" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=3" class="manual"> [nast�pna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre�ci]</a>
      "Aquarium" - PHP TemplateSystem
   </td></tr>
   <tr><td class="text">
   <div>
   
   <span style="font-size:14px; font-weight: bold">
         2. Og�lne informacje o systemie szablon�w <br /></span>
   
   <p class="manual">
   W niniejszym rozdziale opisano zasad� dzia�ania systemu szablon�w oraz jego cz�ci sk�adowe.
   Ostatnia cz�� rozdzia�u stanowi schemat implementacji wsp�lny dla ka�dej sk�adowej systemu.
   </p>
   
   <a name="intro" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Wprowadzenie do szablon�w </span></p>
   
   <p class="manual">
   "Aquarium" - PHP TemplateSystem ma za zadanie wygenerowanie pojedynczej strony WWW na podstawie
   tzw. szablon�w. Szablon jest plikiem zawieraj�cym dane tekstowe oraz zagnie�d�one w nich tzw.
   pola. Pole szablonu jest rozpoznawane przez klas� jako miejsce do podstawienia przez 
   dowoln� warto�� tekstow� (np. zawarto�� innego pliku, zmiennej).
   Podczas pracy obiekt systemu �aduje szablon, zamienia zawarte w nim pola przez odpowiednie 
   warto�ci, nast�pnie tak podstawiony ci�g jest zapami�tywany i mo�e by� pobrany do zmiennej,
   u�yty do podstawienia w innym szablonie lub wys�any do wy�wietlenia (przegl�darki).
   </p>
      
   <a name="template" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Pliki szablon�w </span></p>
   
   <p class="manual" style="margin-bottom:3pt;">
   Pliki szablon�w w skr�cie nazywane szablonami s� podstawowymi elementami systemu. W pojedynczym
   szablonie zawarty jest kod powtarzalnych element�w witryny oraz specjalnie oznaczone pola.
   System szablon�w rozpoznaje znaki <b> { </b> oraz <b> } </b> (nawiasy klamrowe) jako
   odpowiednio pocz�tek i koniec nazwy pola. Tekst znajduj�cy si� pomi�dzy tymi znakami jest 
   traktowany jako nazwa pola. W jednym pliku szablonu mo�e znajdowa� si� dowolna ilo�� p�l o 
   takiej samej lub r�nych nazwach. Nale�y jednak pami�ta� �e pola o takich samych nazwach 
   zostan� wype�nione przez identyczn� zawarto��. Poni�ej prosty przyk�ad szablonu.
   </p>
   <p class="manual" style="weight:60%;margin-left:30pt;margin-top:0pt;margin-bottom:2pt;">
      przyk�ad 1. plik szablonu "main.html.php"</p>
      <pre style="margin-top:0pt;margin-bottom:2pt;margin-left:15pt;">
      &lthtml&gt
         &lthead&gt
            &lttitle&gt
               {title}  <- pole szablonu
            &lt/title&gt
         &lt/head&gt
         &ltbody&gt
               {main}   <- pole szablonu
         &lt/body&gt
      &lt/html&gt </pre>

   <a name="fields" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Wype�nianie p�l szablon�w </span></p>

   <p class="manual" style="margin-top:0pt;margin-bottom:1pt;">
   Aby prawid�owo wygenerowa� dokument na podstawie szablonu, nale�y wcze�niej wype�ni� wszystkie
   pola. Pole mo�na wype�ni� na kilka sposob�w: </p>
   <ul class="manual">
      <li />przypisanie warto�ci z pliku: mo�e to by� inny szablon (przetworzony lub nie) lub 
         plik zawieraj�cy sformatowany pod k�tem xhtml tekst (strona ksi��ki).
      <li />wype�ni� pole warto�ci� zmiennej: zmienna musi by� tekstowa, �r�d�o warto�ci zmiennej
         jest dowolne np. wynik dzia�ania funkcji, pobrana warto�� pola obiektu, wynik zapytania w
         bazie danych
      <li />przypisa� warto�� polu bezpo�rednio za pomoc� oferowanych przez system metod
   </ul>
   <p class="manual" style="margin-top: 1pt;">
   W przypadku gdy pole szablonu nie posiada warto�ci (nie zosta�a zdefiniowana w �aden spos�b)
   wy�wietlona zostanie nazwa pola z nawiasami. Pozwala to na szybk� identyfikacj� brakuj�cych
   tre�ci oraz �ledzenie b��d�w w aplikacji.
   </p>
      
   <a name="parts" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Sk�adniki systemu </span></p>

   <p class="manual" style="margin-bottom: 2pt">
   "Aquarium" - PHP TemplateSystem jest systemem szablon�w sk�adaj�cym si� z trzech klas.
   </p>
   <dl style="margin-left:30px; margin-top: 0pt; margin-bottom:0pt">
      <dt /> <b>Klasa Template</b> - klasa bazowa systemu ("template.class.php")
      <dd /> Klasa umo�liwia przetwarzanie plik�w szablonu do postaci wynikowej. Mozliwe jest
      przetwarzanie tylko pojedynczych szablon�w. Pola s� wype�niane z u�yciem metody klasy 
      lub w wyniku dzia�ania funkcji przetwarzaj�cej szablon. Przetworzony szablon mo�na 
      wy�wietli� lub pobra� do zmiennej. Oferowane przez klas� mo�liwo�ci, przy umiej�tnym u�yciu
      s� wystarczaj�ce do dynamicznego tworzenia nawet bradzo rozbudowanych witryn.
      <dt /> <b>Klasa Box</b> - klasa pochodna od Template ("box.class.php")
      <dd /> Klasa jest wyposa�ona w dodatkow� funkcjonalno�� w postaci przetwarzania listy
      szablon�w podczas jednego cyklu pracy. Szablony s� przetwarzane w kolejno�ci od najbardziej
      zagnie�d�onego. Konieczne jest podanie hierarchicznej zale�no�ci
      rodzic-dziecko plik�w szablonu (mo�liwe a nawet zalecane jest u�ycie pliku
      konfiguracyjnego). Przeznaczeniem klasy jest u�atwienie tworzenia zamkni�tych modu��w
      aplikacji takich jak na przyk�ad modu� logowania, okno do wy�wietlania tre�ci ksi��ek, modu�
      menu.
      <dt /> <b>Klasa Page</b> - klasa pochodna od Box ("page.class.php")
      <dd /> Zasadniczy dodatek to mo�liwo�� wywo�ywania metod obiekt�w. Klasa pozwala na
      utworzenie nowego obiektu i uruchomienie odpowiedniej metody. Wywo�ywana metoda powinna
      zwraca� warto�� tekstow� (w przeciwnym wypadku wywo�anie jej w tej sytuacji traci sens).
      Zwracana warto�� jest przypisywana do podanego w konfiguracji pola. Klasa umo�liwia
      wywo�anie dowolnej liczby obiekt�w w zdefiniowanej wcze�niej kolejno�ci. Przeznaczeniem
      klasy jest zarz�dzanie wy�wietlaniem potrzebnych w danej chwili cz�ci modu��w w
      odpowiednich miejscach szablonu.
   </dl>

   <a name="using" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Uruchomienie systemu </span></p>

   <p class="manual" style="margin-bottom:2pt;">
      System szablon�w jest gotowy do u�ycia po rozpakowaniu. Poszczeg�lne klasy r�ni� si�
      funkcjonalno�ci� i przeznaczeniem, mimo to mo�na wyr�ni� kilka etap�w dzia�ania wsp�lnych
      dla ca�ego systemu.
   </p>
      <ol class="manual">
         <li /> Utworzenie obiektu klasy
         <li /> Przypisanie �cie�ek dost�pu do zasob�w (mo�na poprzez konstruktor w p.1)
         <li /> Zdefiniowanie alias�w (nazw zast�pczych) dla plik�w szablonu
         <li /> Wype�nienie p�l szablonu / szablon�w
         <li /> Przetwarzanie szablonu / szablon�w
         <li /> Wy�wietlenie wygenerowanej strony
      </ol>
   <p class="manual" style="margin-top:2pt;">
      Szczeg�owy opis sposobu u�ycia i implementacji systemu w aplikacji znajduje si� w 
      opisach poszczeg�lnych klas w dalszej cz�ci podr�cznika.
   </p>
   </div>
   </td></tr>
   <tr><td class="text" style="text-align: center;" style="padding: 6pt 0pt 6pt 0pt;">
      <a href="index.php?page=1" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=3" class="manual"> [nast�pna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre�ci]</a>
       "Aquarium" - PHP TemplateSystem
   </td></tr>
</table>
