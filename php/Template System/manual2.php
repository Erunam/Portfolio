<table cellpadding="0" cellspacing="0" border="0" align="center" class="portfolio">
   <tr><td class="text" style="text-align: center;" style="padding: 6pt 0pt 6pt 0pt;">
      <a href="index.php?page=1" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=3" class="manual"> [nastêpna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre¶ci]</a>
      "Aquarium" - PHP TemplateSystem
   </td></tr>
   <tr><td class="text">
   <div>
   
   <span style="font-size:14px; font-weight: bold">
         2. Ogólne informacje o systemie szablonów <br /></span>
   
   <p class="manual">
   W niniejszym rozdziale opisano zasadê dzia³ania systemu szablonów oraz jego czê¶ci sk³adowe.
   Ostatnia czê¶æ rozdzia³u stanowi schemat implementacji wspólny dla ka¿dej sk³adowej systemu.
   </p>
   
   <a name="intro" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Wprowadzenie do szablonów </span></p>
   
   <p class="manual">
   "Aquarium" - PHP TemplateSystem ma za zadanie wygenerowanie pojedynczej strony WWW na podstawie
   tzw. szablonów. Szablon jest plikiem zawieraj±cym dane tekstowe oraz zagnie¿d¿one w nich tzw.
   pola. Pole szablonu jest rozpoznawane przez klasê jako miejsce do podstawienia przez 
   dowoln± warto¶æ tekstow± (np. zawarto¶æ innego pliku, zmiennej).
   Podczas pracy obiekt systemu ³aduje szablon, zamienia zawarte w nim pola przez odpowiednie 
   warto¶ci, nastêpnie tak podstawiony ci±g jest zapamiêtywany i mo¿e byæ pobrany do zmiennej,
   u¿yty do podstawienia w innym szablonie lub wys³any do wy¶wietlenia (przegl±darki).
   </p>
      
   <a name="template" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Pliki szablonów </span></p>
   
   <p class="manual" style="margin-bottom:3pt;">
   Pliki szablonów w skrócie nazywane szablonami s± podstawowymi elementami systemu. W pojedynczym
   szablonie zawarty jest kod powtarzalnych elementów witryny oraz specjalnie oznaczone pola.
   System szablonów rozpoznaje znaki <b> { </b> oraz <b> } </b> (nawiasy klamrowe) jako
   odpowiednio pocz±tek i koniec nazwy pola. Tekst znajduj±cy siê pomiêdzy tymi znakami jest 
   traktowany jako nazwa pola. W jednym pliku szablonu mo¿e znajdowaæ siê dowolna ilo¶æ pól o 
   takiej samej lub ró¿nych nazwach. Nale¿y jednak pamiêtaæ ¿e pola o takich samych nazwach 
   zostan± wype³nione przez identyczn± zawarto¶æ. Poni¿ej prosty przyk³ad szablonu.
   </p>
   <p class="manual" style="weight:60%;margin-left:30pt;margin-top:0pt;margin-bottom:2pt;">
      przyk³ad 1. plik szablonu "main.html.php"</p>
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
   <p><span style="font-size:12px; font-weight: bold"> Wype³nianie pól szablonów </span></p>

   <p class="manual" style="margin-top:0pt;margin-bottom:1pt;">
   Aby prawid³owo wygenerowaæ dokument na podstawie szablonu, nale¿y wcze¶niej wype³niæ wszystkie
   pola. Pole mo¿na wype³niæ na kilka sposobów: </p>
   <ul class="manual">
      <li />przypisanie warto¶ci z pliku: mo¿e to byæ inny szablon (przetworzony lub nie) lub 
         plik zawieraj±cy sformatowany pod k±tem xhtml tekst (strona ksi±¿ki).
      <li />wype³niæ pole warto¶ci± zmiennej: zmienna musi byæ tekstowa, ¿ród³o warto¶ci zmiennej
         jest dowolne np. wynik dzia³ania funkcji, pobrana warto¶æ pola obiektu, wynik zapytania w
         bazie danych
      <li />przypisaæ warto¶æ polu bezpo¶rednio za pomoc± oferowanych przez system metod
   </ul>
   <p class="manual" style="margin-top: 1pt;">
   W przypadku gdy pole szablonu nie posiada warto¶ci (nie zosta³a zdefiniowana w ¿aden sposób)
   wy¶wietlona zostanie nazwa pola z nawiasami. Pozwala to na szybk± identyfikacjê brakuj±cych
   tre¶ci oraz ¶ledzenie b³êdów w aplikacji.
   </p>
      
   <a name="parts" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Sk³adniki systemu </span></p>

   <p class="manual" style="margin-bottom: 2pt">
   "Aquarium" - PHP TemplateSystem jest systemem szablonów sk³adaj±cym siê z trzech klas.
   </p>
   <dl style="margin-left:30px; margin-top: 0pt; margin-bottom:0pt">
      <dt /> <b>Klasa Template</b> - klasa bazowa systemu ("template.class.php")
      <dd /> Klasa umo¿liwia przetwarzanie plików szablonu do postaci wynikowej. Mozliwe jest
      przetwarzanie tylko pojedynczych szablonów. Pola s± wype³niane z u¿yciem metody klasy 
      lub w wyniku dzia³ania funkcji przetwarzaj±cej szablon. Przetworzony szablon mo¿na 
      wy¶wietliæ lub pobraæ do zmiennej. Oferowane przez klasê mo¿liwo¶ci, przy umiejêtnym u¿yciu
      s± wystarczaj±ce do dynamicznego tworzenia nawet bradzo rozbudowanych witryn.
      <dt /> <b>Klasa Box</b> - klasa pochodna od Template ("box.class.php")
      <dd /> Klasa jest wyposa¿ona w dodatkow± funkcjonalno¶æ w postaci przetwarzania listy
      szablonów podczas jednego cyklu pracy. Szablony s± przetwarzane w kolejno¶ci od najbardziej
      zagnie¿d¿onego. Konieczne jest podanie hierarchicznej zale¿no¶ci
      rodzic-dziecko plików szablonu (mo¿liwe a nawet zalecane jest u¿ycie pliku
      konfiguracyjnego). Przeznaczeniem klasy jest u³atwienie tworzenia zamkniêtych modu³ów
      aplikacji takich jak na przyk³ad modu³ logowania, okno do wy¶wietlania tre¶ci ksi±¿ek, modu³
      menu.
      <dt /> <b>Klasa Page</b> - klasa pochodna od Box ("page.class.php")
      <dd /> Zasadniczy dodatek to mo¿liwo¶æ wywo³ywania metod obiektów. Klasa pozwala na
      utworzenie nowego obiektu i uruchomienie odpowiedniej metody. Wywo³ywana metoda powinna
      zwracaæ warto¶æ tekstow± (w przeciwnym wypadku wywo³anie jej w tej sytuacji traci sens).
      Zwracana warto¶æ jest przypisywana do podanego w konfiguracji pola. Klasa umo¿liwia
      wywo³anie dowolnej liczby obiektów w zdefiniowanej wcze¶niej kolejno¶ci. Przeznaczeniem
      klasy jest zarz±dzanie wy¶wietlaniem potrzebnych w danej chwili czê¶ci modu³ów w
      odpowiednich miejscach szablonu.
   </dl>

   <a name="using" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Uruchomienie systemu </span></p>

   <p class="manual" style="margin-bottom:2pt;">
      System szablonów jest gotowy do u¿ycia po rozpakowaniu. Poszczególne klasy ró¿ni± siê
      funkcjonalno¶ci± i przeznaczeniem, mimo to mo¿na wyró¿niæ kilka etapów dzia³ania wspólnych
      dla ca³ego systemu.
   </p>
      <ol class="manual">
         <li /> Utworzenie obiektu klasy
         <li /> Przypisanie ¶cie¿ek dostêpu do zasobów (mo¿na poprzez konstruktor w p.1)
         <li /> Zdefiniowanie aliasów (nazw zastêpczych) dla plików szablonu
         <li /> Wype³nienie pól szablonu / szablonów
         <li /> Przetwarzanie szablonu / szablonów
         <li /> Wy¶wietlenie wygenerowanej strony
      </ol>
   <p class="manual" style="margin-top:2pt;">
      Szczegó³owy opis sposobu u¿ycia i implementacji systemu w aplikacji znajduje siê w 
      opisach poszczególnych klas w dalszej czê¶ci podrêcznika.
   </p>
   </div>
   </td></tr>
   <tr><td class="text" style="text-align: center;" style="padding: 6pt 0pt 6pt 0pt;">
      <a href="index.php?page=1" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=3" class="manual"> [nastêpna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre¶ci]</a>
       "Aquarium" - PHP TemplateSystem
   </td></tr>
</table>
