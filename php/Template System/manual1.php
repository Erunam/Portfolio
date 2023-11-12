<table cellpadding="0" cellspacing="0" border="0" align="center" class="portfolio">
   <tr><td class="text" style="text-align: center;" style="padding: 6pt 0pt 6pt 0pt;">
      <a href="index.php?page=0" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=2" class="manual"> [nast�pna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre�ci]</a>
       "Aquarium" - PHP TemplateSystem
   </td></tr>
   <tr><td class="text">
   <div>
   
   <span style="font-size:14px; font-weight: bold">
         1. Wprowadzenie<br /></span>
   
   <p class="manual">
   W tym rozdziale opisane zostan� warunki korzystania z systemu,
   spos�b pobrania pakietu i jego instalacji oraz wymagania programowe.
   Ponadto w skr�cie przedstawiona zostanie przeznaczenie zaprezentowanego rozwi�zania
   oraz jego zasadnicze cechy.
   </p>
   
   <a name="license" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Licencja </span></p>
   
   <p class="manual">
   "Aquarium" - PHP TemplateSystem wersja 1.0 beta sk�ada si� z plik�w zawartych w bie��cym katalogu 
   oraz w podkatalogach. Szczeg�owy wykaz plik�w systemu zawiera plik o nazwie filelist.txt
   dostarczanym wraz z dystrybucj�. System jest zbiorem plik�w udost�pnianych u�ytkownikom
   za darmo, a u�ywanie systemu jest licencjonowane na zasadach GNU General Public License.
   Tekst licencji znajduje si� w pliku <a href="./index.php?page=copying" class="manual">
   "copying.txt"</a> (wersja polskoj�zyczna <a href="./index.php?page=licencja" class="manual">
   "licencja.txt" </a>). Jakiekolwiek u�ywanie systemu oznacza zgod� na warunki licencji.
   Moc prawn� posiada jedynie angielskoj�zyczna wersja licencji (zawarta w pliku copying.txt),
   polskie t�umaczenie dokumentu zosta�o umieszczone jedynie w celu u�atwienia zrozumienia
   warunk�w licencji dla os�b dla kt�rych tekst angielski jest niezrozumia�y.
   </p>
   
   <a name="target" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Przeznaczenie systemu </span></p>

   <p class="manual">
   "Aquarium" - PHP TemplateSystem jest kolejn� propozycj� z gatunku system szablon�w. Dostarcza
   programistom PHP zestawu narz�dzi do dynamicznego generowania i zarz�dzania wizualn� warstw�
   aplikacji WWW. Dostarczone rozwi�zanie bazuje na tzw. szablonach zawieraj�cych 
   elementy rozpoznawane przez przegl�dark� (kod xhtml, javascript) oraz odpowiednio wyszczeg�lnione
   pola. Obiekty systemu szblon�w s� odpowiedzialne za wygenerowanie tre�ci wysy�anej z serwera do
   przegl�darki i wraz z innymi klasami (skryptami) tworz� wartw� aplikacyjn� witryny.
   </p>
   <p class="manual">
   Zastosowanie systemu szablonu pozwala fizycznie oddzieli� wartwy aplikacji od siebie.
   Odpowiednio zaprojektowane szablony zwi�kszaj� mo�liwo�� ponownego wykorzystania kodu oraz jego
   �atw� konserwacj�. Zmiana wygl�du witryny jest mo�liwa bez ingerencji w wartw� logiczn� 
   aplikacji WWW. Zaproponowane rozwi�zanie pozwala na modularyzacj� aplikacji WWW wraz ze
   wszystkimi korzy�ciami jakie modularyzacja w programowaniu niesie.
   </p>
   <p class="manual">
   U�ycie systemu szablon�w nak�ada na projektant�w witryny konieczno�� wykonania dodatkowej pracy
   projektowej (podzia� witryny na odpowiednie szablony projektowe). Na projektant�w interfejsu
   nak�ada konieczno�� gromadzenia koniecznych programistom informacji na temat plik�w szablonu.
   System wnosi dodatkowy nak�ad w postaci dodatkowych obiekt�w (przy nieumiej�tnym u�yciu nawet
   bardzo du�y) na warstw� aplikacyjn�.
   </p>

   <a name="download" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Pobieranie i instalacja </span></p>
   
   <p class="manual" style="margin-bottom:2pt;margin-top:2pt;">
      Aktualny pakiet "Aquarium" - PHP TemplateSystem jest udost�pniony do pobrania na stronie 
   <a href="www.kelebrin.prv.pl" target="_blank" class="link">
   FLUG "kelebrin" www.kelebrin.prv.pl </a>
   w dziale <b>Offer - Web Design and Programming </b>. <br />
   Poni�ej lista odno�nik�w do dost�pnych pakiet�w:</p>
      <dl style="margin-left:30px; margin-top: 0pt; margin-bottom:0pt">
         <dt /> <a href="./download/TemplateSystem.1.0.full.zip" class="link">
         PHP TemplateSystem - full (12320 B)</a>
         <dd /> Pakiet zawiera wszystkie elementy systemu: plik klasy, przyk�adowe pliki 
         konfiguracyjne, przyk�adowy plik g��wny aplikacji "main.php", licencj� oraz dokumentacj�.
         <dt /> <a href="./download/EventSystem.1.0.events.zip" class="link">
         PHP TemplateSystem - classes (12320 B)</a>
         <dd /> Pakiet zawiera elementy podstawowe systemu: klasy PHP TemplateSystem oraz przyk�adowe pliki konfiguracyjne
         <dt /> <a href="./download/EventSystem.1.0.manual.zip" class="link">
         PHP TemplateSystem - manual (12320 B)</a>
         <dd /> Pakiet zawiera dokumentacj� do PHP TemplateSystem w wersji statycznej.
      </dl>
   <p class="manual" style="margin-bottom:2pt;margin-top:2pt;">
   Instalacja pakietu polega na pobraniu odpowiedniego pliku i rozpakowaniu go do katalogu
   g��wnego aplikacji (lub te� innego, dowolnie wybranego).<br />
   Pakiet tworzy w katalogu docelowym nast�puj�ce podkatalogi systemu:</p>
      <dl style="margin-left:30px; margin-top: 0pt; margin-bottom:3pt">
         <dt /><b>[classes]</b>
         <dd />katalog zawieraj�cy definicje klas
         <dt /><b>[config]</b>
         <dd />katalog zawieraj�cy przyk�adowe pliki konfiguracyjne obiektu klasy Events:<br />
               <b>filelist.cfg.php</b> - plik zawieraj�cy list� plik�w szablonu <br />
               <b>filetree.cfg.php</b> - plik definiuj�cy hierarchi� plik�w szablonu <br />
               <b>objectfield.cfg.php</b> - plik zawieraj�cy definicj� rezerwacji p�l przez
               obiekty <br />
               <b>objectlist.cfg.php</b> - plik zawieraj�cy list� u�ywanych klas i metod <br />
         <dt /><b>[lang]</b>
         <dd />katalog zawieraj�cy pliki zawieraj�ce zawarto�� p�l szablonu w r�nych j�zykach
         <dt /><b>[templates]</b>
         <dd />katalog zawieraj�cy pliki szablonu
         <dt /><b>main.php</b>
         <dd />plik g��wny aplikacji (index.*), przyk�ad zastasowania klasy Template
      </dl>
   <p class="manual" style="margin-top:2pt;">
   Taki uk�ad plik�w i katog�w jest zaimplementowany w systemie jako domy�lne
   warto�ci zmiennych a przez autor�w zalecany do u�ywania z kilku powod�w:<br />
    &#160&#160- system jest znacznie �atwiejszy w u�yciu (domy�lnie przyjmowane warto�ci zmienncyh)<br />
    &#160&#160- uk�ad jest przejrzysty i czytelny - jakkolwiej jest to subiektywne wra�enie autor�w<br />
    &#160&#160- jest u�ywany w tej dokumentacji - przy�pieszy proces opanowywania systemu.<br />
   Pakiet po rozpakowaniu jest praktycznie gotowy do u�ycia. Opis zastosowania i u�ycia systemu w
   aplikacji znajduje si� w dalszej cz�sci dokumentacji.
   </p>
   
   <a name="requirements" ></a>
   <p><span style="font-size:12px; font-weight: bold"> Wymagania </span></p>
   
   <p class="manual">
   Podczas pracy autorzy pakietu korzystali z serwera http Apache 2.0.43 (Win32) z zainstalowanym
   parserem PHP 4.3.3. Pakiet optymalizowany b�dzie dla parsera PHP 4.1 i serwera Apache 1.29 <br />
   Minimalne wymagania to: serwer http z zainstalowanym parserem PHP 4.0 lub wy�szym <br />
   Zalecana konfiguracja to: serwer http Apache 2.0.43 z zainstalowanym PHP 4.3.3 <br />
   </p>
   
   </div>
   </td></tr>
   <tr><td class="text" style="text-align: center;" style="padding: 6pt 0pt 6pt 0pt;">
      <a href="index.php?page=0" class="manual"> [poprzednia strona] </a>
      <a href="index.php?page=2" class="manual"> [nast�pna strona] </a>
      <a href="index.php?page=0" class="manual"> [spis tre�ci]</a>
      "Aquarium" - PHP TemplateSystem
   </td></tr>
</table>
