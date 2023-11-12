<?php
/*************************************************************************\
*    Name  : Events class ver. 1.0 beta                                   *
*    Author: Magdalena and Daniel Dubaj                                   *
*    WWW   : http://www.kelebrin.prv.pl                                   *
*    E-mail: danieldubaj@op.pl                                            *
*    Date  : 20 October 2003                                              *
*    Copyright (c) 2003 Magdalena and Daniel Dubaj                        *
*                                                                         *
*  All rights reserved.                                                   *
*                                                                         *
*  This program is free software licensed under the GNU General Public    *
*  License (GPL). This program is free software;  you can redistribute it *
*  and/or modify it under the terms of the GNU General Public License as  *
*  published by the Free Software Foundation; either version 2 of the     *
*  License, or (at your option) any later version.  This program is       *
*  distributed in the hope that it will be useful, but WITHOUT ANY        *
*  WARRANTY; without even the implied warranty of MERCHANTABILITY or      *
*  FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License   *
*  for more details.                                                      *
\*************************************************************************/

//begin class Events
class Events
{
   var $delegatefile;
   var $delegatelist;
   var $delegatequeue;
   
   function Events($delegatefile='./eventconfig/delegatelist.cfg.php')
   /*****************************************************

   *****************************************************/
   {
      $this -> delegatefile = $delegatefile;
      $this -> delegatelist = array();
      $this -> read_delegatelist();
   }
   
   function set_delegatelist($event='',$delegate='')
   /*****************************************************
    wype³nia tablicê metod obs³ugi zdarzeñ delegatelist
    klucz tablicy to nazwa zdarzenia warto¶ci± jest tablica
    zawieraj±ca listê metod obs³uguj±cych zdarzenie
   *****************************************************/
   { 
      if ( is_array($event) )
      {
         foreach ($event as $from => $delegate)
         {
            $this -> delegatelist[$from] = $delegate;
         }
         return true;
      }
      elseif ( !empty($event) and !empty($delegate) )
      {
         $this -> delegatelist [$event][] = $delegate;
         return true;
      }
      else
      {
         return false;
      }
   }

   function read_delegatelist()
   /*****************************************************
   wczytuje plik zawieraj±cy rezerwacjê zdarzeñ przez metody
   format pliku: 
      [nazwa_klasy_wywo³uj±cej:nazwa_zdarzenia]
            nazwa_klasy:metoda_reaguj±ca_na_zdarzenie
   *****************************************************/
   {
      $file = $this -> delegatefile;
      $delegatelist = $this -> load_file($file);

      foreach ($delegatelist as $val)
      {
         if (eregi('\[',$val))
         {
            $event = trim($val,'\[]');
         }
         else
         {
            $delegate = trim($val);
            $this -> set_delegatelist( $event, $delegate );
         }
      }
   }
   function save_delegatelist()
   /*****************************************************
   zapisuje aktualn± listê rezerwacji obs³ugi zdarzenia
   do pliku
   *****************************************************/
   {
      if ( !empty($this -> delegatelist) )
      {
         $filename = $this -> delegatefile;
         $fid = fopen($filename,'w+');
         
         foreach ( $this -> delegatelist as $event => $delegates )
         {
            $event = '[' . $event . "]\n";
            fwrite($fid, $event);
            
            foreach ( $delegates as $delegate )
            {
               $delegate = "\t" . $delegate . "\n";
               fwrite($fid, $delegate);
            }
         }
         return true;
      }
      else
      {
         return false;
      }
   } 
   
   function event($event,$args='')
   /*****************************************************
   metoda przekazuje zdarzenie do obs³uguj±cych je metod
   wg listy rezerwacji zdarzenia.
   *****************************************************/
   {
      if ( !empty($this -> delegatelist[$event]) )
      {
         $delegates = $this -> get_delegates($event);
         foreach ($delegates as $delegate)
         {
            $class    = explode(":",$delegate);
            $delegate = trim($class[1]);
            $class    = trim($class[0]);

            if ( $class == 'Events' )
            {
               $this -> $delegate($args);
            }
            elseif ( class_exists($class) and $class !== 'Events' )
            {
               $object = new $class;
               $object = $object -> $delegate($args);
               unset($object);
               return true;
            }
            else
            {
//               print(" not existed class $class or delegate for event $event ");
               $this -> event('application:end');
            }
         }
      }
      else  
      {
//         print(" not existed event: $event");
         $this -> event('application:end');
      }
   }

   function get_delegates($event='')
   /*****************************************************
   pobiera listê metod rezerwuj±cych podane zdarzenie
   je¶li nie podano zdarzenia metoda zwraca ca³± listê
   *****************************************************/
   { 
      if ( empty($event) )
      {  
         return $this -> delegatelist;
      }
      elseif (is_string($event))
      {  
         return $this -> delegatelist[$event];
      }
      else
      {
         return false;
      }     
   }

  function load_file($file)
  /*****************************************************
   wczytuje plik z dysku do tablicy, zwraca tablicê
  *****************************************************/
  { 
    $file = @file($file) or die("the file is not exist: $file");

    foreach ($file as $key => $val)
      { 
        $val = trim($val);
        $file[$key] = $val;
      }
    return $file;
  }

   function dlg_get_classes($args=array(  'file'=>'./eventconfig/classes.cfg.php',
                                          'classpath'=>'./classes'))
   /*****************************************************
   metoda obs³ugi zdarzenia (delegacja):
      pobiera nazwy klas z pliku o podanej ¶cie¿ce args['file']
      uzupe³nia nazwê klasy do ¶cie¿ki dostêpu do pliku wg. formatu autora
      nazwa_klasy => ./classes/nazwa_klasy.class.php
      args['classpath'] - katalog zawieraj±cy pliki klas
   *****************************************************/
   {
      if (is_array($args))
      {
         extract($args);
         settype($file,'string');
         settype($classpath,'string');
      }
      else
      {
         return false;
      }

      $file = @file($file) or die("the file is not exist: $file");

      foreach ($file as $key => $class)
      { 
         $class = trim($class);
         $file[$key] = $classpath . '/' . $class . '.class.php'; 
      }
      return $file;
   }
   
   function dlg_receive_args()
   /*****************************************************
   metoda obs³ugi zdarzenia (delegacja)
   metoda pobiera argumenty dla zdarzeñ przekazywanych z innych stron. 
      w pierwszej kolejno¶ci pobiera argumenty odebrane metod± post
      nastêpnie metod± get. tablica argumentów zawiera informacjê
      o metodzie otrzymania w kluczu 'received'
   *****************************************************/
   {
      if ( !empty($_POST) )
      {
         $args = $_POST;
         $args ['received'] = 'post';
         return $args;
      }
      if ( !empty($_GET) )
      {
         $args = $_GET;
         $args ['received'] = 'get';
         return $args;
      }
      if ( !empty($args['event']) )
      {
         $event = $args['event'];
         $this -> event($event,$args);
      }
      $this -> event('application:end');
   }

   function dlg_shutdown()
   /*****************************************************
   metoda obs³ugi zdarzenia (delegacja)
   metoda pobiera argumenty dla zdarzeñ przekazywanych z innych stron. 
      w pierwszej kolejno¶ci pobiera argumenty odebrane metod± post
      nastêpnie metod± get. tablica argumentów zawiera informacjê
      o metodzie otrzymania w kluczu 'received'
   *****************************************************/
   {
     print_r('<div align="center"><hr> Example shutdown delegate for PHP_EventSystem ver.1.0 b:<br>');
     print_r('<p> Thank you for testing the EventSystem.<br> For news please visit');
     print_r('<a href="www.kelbrin.prv.pl"> www.kelebrin.prv.pl </a><br><br>');
     print_r('I will be grateful to you for error reporting.<br>');
     print_r(' Please send mail for <a href="mailto:danieldubaj@op.pl"> danieldubaj@op.pl </a></p>');
     print_r('<hr>');
     print_r('<br><small><small> The PHP_EventSystem ver. 1.0 beta included following classes:');
     print_r('<br> Template class ver. 2.1, ');
     print_r('Box class ver. 1.0, ');
     print_r('Page class ver. 1.0, ');
     print_r('Events class ver. 1.0. </small>');
     print_r('<br><br><b> Copyright (c) 2003 Magdalena and Daniel Dubaj </b><br>');
     print_r('<br>This program is free software; you can redistribute it and/or');
     print_r('<br>modify it under the terms of the GNU General Public License');
     print_r('<br>as published by the Free Software Foundation; either version 2');
     print_r('<br>of the License, or (at your option) any later version. ');
     print_r('<br>This program is distributed in the hope that it will be useful, ');
     print_r('<br>This program is distributed in the hope that it will be useful, ');
     print_r('<br>but WITHOUT ANY WARRANTY; without even the implied warranty of ');
     print_r('<br>MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the ');
     print_r('<br>GNU General Public License for more details. ');
     print_r('<br> ');
     print_r('<br>You should have received a copy of the GNU General Public License ');
     print_r('<br>along with this program; if not, write to the Free Software ');
     print_r('<br>Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA. ');
     print_r('<br> ');
     print_r('<br>Full licence text <a href="http://www.gnu.org/copyleft/gpl.html"> www.gnu.org');
     print_r('<br> </small> <hr />');    
   }

}
// end of EventManager class

?>
