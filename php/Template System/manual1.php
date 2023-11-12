<table cellpadding="0" cellspacing="0" border="0" align="center" class="portfolio">
   <tr><td class="text" style="text-align: center;" style="padding: 6pt 0pt 6pt 0pt;">
      <a href="index.php?page=0" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=2" class="manual"> [nastêpna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre¶ci]</a>
       "Aquarium" - PHP TemplateSystem
   </td></tr>
   <tr><td class="text">
   <div>
   
   <span style="font-size:14px; font-weight: bold">
         1. Wprowadzenie<br /></span>
   
   <p class="manual">
   W tym rozdziale opisane zostan± warunki korzystania z systemu,
   sposób pobrania pakietu i jego instalacji oraz wymagania programowe.
   Ponadto w skrócie przedstawiona zostanie przeznaczenie zaprezentowanego rozwi±zania
   oraz jego zasadnicze cechy.
   </p>
   
   <a name="license" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Licencja </span></p>
   
   <p class="manual">
   "Aquarium" - PHP TemplateSystem wersja 1.0 beta sk³ada siê z plików zawartych w bie¿±cym katalogu 
   oraz w podkatalogach. Szczegó³owy wykaz plików systemu zawiera plik o nazwie filelist.txt
   dostarczanym wraz z dystrybucj±. System jest zbiorem plików udostêpnianych u¿ytkownikom
   za darmo, a u¿ywanie systemu jest licencjonowane na zasadach GNU General Public License.
   Tekst licencji znajduje siê w pliku <a href="./index.php?page=copying" class="manual">
   "copying.txt"</a> (wersja polskojêzyczna <a href="./index.php?page=licencja" class="manual">
   "licencja.txt" </a>). Jakiekolwiek u¿ywanie systemu oznacza zgodê na warunki licencji.
   Moc prawn± posiada jedynie angielskojêzyczna wersja licencji (zawarta w pliku copying.txt),
   polskie t³umaczenie dokumentu zosta³o umieszczone jedynie w celu u³atwienia zrozumienia
   warunków licencji dla osób dla których tekst angielski jest niezrozumia³y.
   </p>
   
   <a name="target" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Przeznaczenie systemu </span></p>

   <p class="manual">
   "Aquarium" - PHP TemplateSystem jest kolejn± propozycj± z gatunku system szablonów. Dostarcza
   programistom PHP zestawu narzêdzi do dynamicznego generowania i zarz±dzania wizualn± warstw±
   aplikacji WWW. Dostarczone rozwi±zanie bazuje na tzw. szablonach zawieraj±cych 
   elementy rozpoznawane przez przegl±darkê (kod xhtml, javascript) oraz odpowiednio wyszczególnione
   pola. Obiekty systemu szblonów s± odpowiedzialne za wygenerowanie tre¶ci wysy³anej z serwera do
   przegl±darki i wraz z innymi klasami (skryptami) tworz± wartwê aplikacyjn± witryny.
   </p>
   <p class="manual">
   Zastosowanie systemu szablonu pozwala fizycznie oddzieliæ wartwy aplikacji od siebie.
   Odpowiednio zaprojektowane szablony zwiêkszaj± mo¿liwo¶æ ponownego wykorzystania kodu oraz jego
   ³atw± konserwacjê. Zmiana wygl±du witryny jest mo¿liwa bez ingerencji w wartwê logiczn± 
   aplikacji WWW. Zaproponowane rozwi±zanie pozwala na modularyzacjê aplikacji WWW wraz ze
   wszystkimi korzy¶ciami jakie modularyzacja w programowaniu niesie.
   </p>
   <p class="manual">
   U¿ycie systemu szablonów nak³ada na projektantów witryny konieczno¶æ wykonania dodatkowej pracy
   projektowej (podzia³ witryny na odpowiednie szablony projektowe). Na projektantów interfejsu
   nak³ada konieczno¶æ gromadzenia koniecznych programistom informacji na temat plików szablonu.
   System wnosi dodatkowy nak³ad w postaci dodatkowych obiektów (przy nieumiejêtnym u¿yciu nawet
   bardzo du¿y) na warstwê aplikacyjn±.
   </p>

   <a name="download" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Pobieranie i instalacja </span></p>
   
   <p class="manual" style="margin-bottom:2pt;margin-top:2pt;">
      Aktualny pakiet "Aquarium" - PHP TemplateSystem jest udostêpniony do pobrania na stronie 
   <a href="www.kelebrin.prv.pl" target="_blank" class="link">
   FLUG "kelebrin" www.kelebrin.prv.pl </a>
   w dziale <b>Offer - Web Design and Programming </b>. <br />
   Poni¿ej lista odno¶ników do dostêpnych pakietów:</p>
      <dl style="margin-left:30px; margin-top: 0pt; margin-bottom:0pt">
         <dt /> <a href="./download/TemplateSystem.1.0.full.zip" class="link">
         PHP TemplateSystem - full (12320 B)</a>
         <dd /> Pakiet zawiera wszystkie elementy systemu: plik klasy, przyk³adowe pliki 
         konfiguracyjne, przyk³adowy plik g³ówny aplikacji "main.php", licencjê oraz dokumentacjê.
         <dt /> <a href="./download/EventSystem.1.0.events.zip" class="link">
         PHP TemplateSystem - classes (12320 B)</a>
         <dd /> Pakiet zawiera elementy podstawowe systemu: klasy PHP TemplateSystem oraz przyk³adowe pliki konfiguracyjne
         <dt /> <a href="./download/EventSystem.1.0.manual.zip" class="link">
         PHP TemplateSystem - manual (12320 B)</a>
         <dd /> Pakiet zawiera dokumentacjê do PHP TemplateSystem w wersji statycznej.
      </dl>
   <p class="manual" style="margin-bottom:2pt;margin-top:2pt;">
   Instalacja pakietu polega na pobraniu odpowiedniego pliku i rozpakowaniu go do katalogu
   g³ównego aplikacji (lub te¿ innego, dowolnie wybranego).<br />
   Pakiet tworzy w katalogu docelowym nastêpuj±ce podkatalogi systemu:</p>
      <dl style="margin-left:30px; margin-top: 0pt; margin-bottom:3pt">
         <dt /><b>[classes]</b>
         <dd />katalog zawieraj±cy definicje klas
         <dt /><b>[config]</b>
         <dd />katalog zawieraj±cy przyk³adowe pliki konfiguracyjne obiektu klasy Events:<br />
               <b>filelist.cfg.php</b> - plik zawieraj±cy listê plików szablonu <br />
               <b>filetree.cfg.php</b> - plik definiuj±cy hierarchiê plików szablonu <br />
               <b>objectfield.cfg.php</b> - plik zawieraj±cy definicjê rezerwacji pól przez
               obiekty <br />
               <b>objectlist.cfg.php</b> - plik zawieraj±cy listê u¿ywanych klas i metod <br />
         <dt /><b>[lang]</b>
         <dd />katalog zawieraj±cy pliki zawieraj±ce zawarto¶æ pól szablonu w ró¿nych jêzykach
         <dt /><b>[templates]</b>
         <dd />katalog zawieraj±cy pliki szablonu
         <dt /><b>main.php</b>
         <dd />plik g³ówny aplikacji (index.*), przyk³ad zastasowania klasy Template
      </dl>
   <p class="manual" style="margin-top:2pt;">
   Taki uk³ad plików i katogów jest zaimplementowany w systemie jako domy¶lne
   warto¶ci zmiennych a przez autorów zalecany do u¿ywania z kilku powodów:<br />
    &#160&#160- system jest znacznie ³atwiejszy w u¿yciu (domy¶lnie przyjmowane warto¶ci zmienncyh)<br />
    &#160&#160- uk³ad jest przejrzysty i czytelny - jakkolwiej jest to subiektywne wra¿enie autorów<br />
    &#160&#160- jest u¿ywany w tej dokumentacji - przy¶pieszy proces opanowywania systemu.<br />
   Pakiet po rozpakowaniu jest praktycznie gotowy do u¿ycia. Opis zastosowania i u¿ycia systemu w
   aplikacji znajduje siê w dalszej czêsci dokumentacji.
   </p>
   
   <a name="requirements" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Wymagania </span></p>
   
   <p class="manual">
   Podczas pracy autorzy pakietu korzystali z serwera http Apache 2.0.43 (Win32) z zainstalowanym
   parserem PHP 4.3.3. Pakiet optymalizowany bêdzie dla parsera PHP 4.1 i serwera Apache 1.29 <br />
   Minimalne wymagania to: serwer http z zainstalowanym parserem PHP 4.0 lub wy¿szym <br />
   Zalecana konfiguracja to: serwer http Apache 2.0.43 z zainstalowanym PHP 4.3.3 <br />
   </p>
   
   </div>
   </td></tr>
   <tr><td class="text" style="text-align: center;" style="padding: 6pt 0pt 6pt 0pt;">
      <a href="index.php?page=0" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=2" class="manual"> [nastêpna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre¶ci]</a>
      "Aquarium" - PHP TemplateSystem
   </td></tr>
</table>
