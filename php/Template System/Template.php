<table cellpadding="0" cellspacing="0" border="0" align="center" class="portfolio">
   <tr><td class="text" style="text-align: center;">
      <a href="index.php?page=32" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=34" class="manual"> [nastêpna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre¶ci]</a>
       PHP EventSystem v. 1.0 beta - dokumentacja
   </td></tr>
   <tr><td class="text">
   <div>
      <span style="font-size:14px; font-weight: bold">
         3.2 System szablonów - klasa Template<br /></span>
   <a name="description" > </a>
   <p><span style="font-size:12px; font-weight: bold">2.1 Opis ogólny klasy </span><p>
   <p class="manual">
   Klasa Template jest przeznaczona do generowania pojedynczych dokumentów z tzw. plików
   szablonów. Szablon jest plikiem zawieraj±cym dane tekstowe z zagnie¿d¿onymi w nim tzw.
   "polami". Pole szablonu jest rozpoznawane przez klasê jako miejsce do podstawienia przez 
   dowoln± warto¶æ tekstow± (np. zawarto¶æ innego pliku lub zmiennej).
   Podczas pracy klasa ³aduje szablon, podstawia zawarte w nim pola przez odpowiednie warto¶ci,
   nastêpnie tak podstawiony ci±g jest zapamiêtywany i mo¿e byæ pobrany do zmiennej, u¿yty do
   podstawienia w innym szablonie lub wys³any do wy¶wietlenia.
   </p>
   <a name="using" > </a>
   <p><span style="font-size:12px; font-weight: bold">2.2 U¿ycie klasy </span></p>
   <p class="manual" style="margin-bottom:2pt;">
      <span style="font-size:12px; font-weight: bold"> 2.2.1 Szablon </span></p>
   <p class="manual" style="margin-top: 0pt; margin-bottom:2pt">
      Plikiem szablonu mo¿e byæ dowolny plik tekstowy który zawiera specjalnie oznaczone "pola".
      Klasa rozpoznaje znaki: <b> { </b> oraz <b> } </b> (nawiasy klamrowe) jako odpowiednio 
      pocz±tek i koniec nazwy pola szablonu. Tekst znajduj±cy siê pomiêdzy tymi znakami jest 
      traktowany jako nazwa pola. W jednym pliku szablonu mo¿e znajdowaæ siê dowolna ilo¶æ pól o 
      takiej samej nazwie. Pola o takich samych nazwach zostan± wype³nione przez identyczn±
      zawarto¶æ. Poni¿ej przyk³ad pliku szablonu.
   </p>
   <p class="manual" style="weight:60%;margin-left:30pt;margin-top:0pt;margin-bottom:2pt;">
      przyk³ad 1. plik szablonu </p>
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
      <span style="font-size:12px; font-weight: bold"> 2.2.2 U¿ycie klasy </span></p>
   <p class="manual" style="margin-top: 0pt; margin-bottom:2pt">
asdad
   </p>

   </div>
   </td></tr>
   <tr><td class="text" style="text-align: center;">
      <a href="index.php?page=1" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=3" class="manual"> [nastêpna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre¶ci]</a>
       PHP EventSystem v. 1.0 beta - dokumentacja
   </td></tr>
</table>
