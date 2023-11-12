<table cellpadding="0" cellspacing="0" border="0" align="center" class="portfolio">
   <tr><td class="text" style="text-align: center;">
      <a href="index.php?page=32" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=34" class="manual"> [nast�pna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre�ci]</a>
       PHP EventSystem v. 1.0 beta - dokumentacja
   </td></tr>
   <tr><td class="text">
   <div>
      <span style="font-size:14px; font-weight: bold">
         3.2 System szablon�w - klasa Template<br /></span>
   <a name="description" > </a>
   <p><span style="font-size:12px; font-weight: bold">2.1 Opis og�lny klasy </span><p>
   <p class="manual">
   Klasa Template jest przeznaczona do generowania pojedynczych dokument�w z tzw. plik�w
   szablon�w. Szablon jest plikiem zawieraj�cym dane tekstowe z zagnie�d�onymi w nim tzw.
   "polami". Pole szablonu jest rozpoznawane przez klas� jako miejsce do podstawienia przez 
   dowoln� warto�� tekstow� (np. zawarto�� innego pliku lub zmiennej).
   Podczas pracy klasa �aduje szablon, podstawia zawarte w nim pola przez odpowiednie warto�ci,
   nast�pnie tak podstawiony ci�g jest zapami�tywany i mo�e by� pobrany do zmiennej, u�yty do
   podstawienia w innym szablonie lub wys�any do wy�wietlenia.
   </p>
   <a name="using" > </a>
   <p><span style="font-size:12px; font-weight: bold">2.2 U�ycie klasy </span></p>
   <p class="manual" style="margin-bottom:2pt;">
      <span style="font-size:12px; font-weight: bold"> 2.2.1 Szablon </span></p>
   <p class="manual" style="margin-top: 0pt; margin-bottom:2pt">
      Plikiem szablonu mo�e by� dowolny plik tekstowy kt�ry zawiera specjalnie oznaczone "pola".
      Klasa rozpoznaje znaki: <b> { </b> oraz <b> } </b> (nawiasy klamrowe) jako odpowiednio 
      pocz�tek i koniec nazwy pola szablonu. Tekst znajduj�cy si� pomi�dzy tymi znakami jest 
      traktowany jako nazwa pola. W jednym pliku szablonu mo�e znajdowa� si� dowolna ilo�� p�l o 
      takiej samej nazwie. Pola o takich samych nazwach zostan� wype�nione przez identyczn�
      zawarto��. Poni�ej przyk�ad pliku szablonu.
   </p>
   <p class="manual" style="weight:60%;margin-left:30pt;margin-top:0pt;margin-bottom:2pt;">
      przyk�ad 1. plik szablonu </p>
      <pre style="margin-top:0pt;margin-bottom:2pt;margin-left:15pt;">
      &lthtml&gt
      &lttitle&gt
         {title}  <- pole szablonu
      &lt/title&gt
      &ltbody&gt
         {main}   <- pole szablonu
      &lt/body&gt
      &lt/html&gt </pre>
   <p class="manual" style="margin-bottom:2pt;margin-top:0pt;">
      <span style="font-size:12px; font-weight: bold"> 2.2.2 U�ycie klasy </span></p>
   <p class="manual" style="margin-top: 0pt; margin-bottom:2pt">
asdad
   </p>

   </div>
   </td></tr>
   <tr><td class="text" style="text-align: center;">
      <a href="index.php?page=1" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=3" class="manual"> [nast�pna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre�ci]</a>
       PHP EventSystem v. 1.0 beta - dokumentacja
   </td></tr>
</table>
