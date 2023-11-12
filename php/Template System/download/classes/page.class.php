<?php
/*************************************************************************\
*     Name  : page class ver. 1.0 beta                                    *
*     Author: Magdalena and Daniel Dubaj                                  *
*     WWW   : http://www.kelebrin.prv.pl                                  *
*     E-mail: danieldubaj@op.pl                                           *
*     Date  : 18 Octobr 2003                                              *
*     Copyright (c) 2003 Magdalena and Daniel Dubaj                       *
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
*                                                                         *
*  You should have received a copy of the GNU General Public Licensea     *
*  along with this program; if not, write to the Free Software Foundation,*
*  Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.        *
\*************************************************************************/

require_once('box.class.php');

// begin class Page
class Page extends Box
{ 
  var $objectfield;
  var $objectlist;

  function Page($path = '.')
  {
    $this -> fieldlist  = array();
    $this -> filelist = array();
    $this -> last;
    $this -> tree  = array();
    $this -> queue = array();
    $this -> pathes['root'] = $path . '/';
    $this -> pathes['templates'] = $path . '/template/';
    $this -> pathes['config'] = $path . '/config/';
    $this -> objectlist = array();
    $this -> objectfield = array();
  }
  
  function read_objectfield($file='objectfield.php')
  /*****************************************************
   wczytuje plik definicji wype³nienia pól szablonu obiektami
   format pliku: 
      nazwa_pola = klasa_obiektu:metoda_generuj±ca_pole               
  *****************************************************/
  { 
    $file = $this -> pathes['config'] . $file;
    $objectfield = $this -> load_file($file);

    foreach ($objectfield as $val)
    {
      $key_val = explode("=",$val);
      $this -> set_objectfield( trim($key_val[0]),trim($key_val[1]) );
    }
  }
  
  function set_objectfield($field='',$obj='')
  /*****************************************************
   tablica rezerwuje przypisanie obiektu do pola szablonu
  *****************************************************/
  { 
    if (is_array($field))
    { 
      foreach ($obj as $key => $val)
      { 
        $this -> objectfield[$key] = $val;
      }
      return true;
    }
    elseif ( !empty($field) and !empty($obj) )
    { 
      $this -> objectfield[$field] = $obj;
      return true;
    }
    else
    { 
      return false;
    }
  }

  function read_objectlist($file='objectlist.php')
  /*****************************************************
   wczytuje plik zawieraj±cy listê u¿ywanych metod i klas
   oraz listê argumentów dla danej metody
   format pliku:
      [nazwa_klasy:nazwa_metody]
         nazwa_zmiennej = warto¶æ_zmiennej
  *****************************************************/
  { 
    $file = $this -> pathes['config'] . $file;
    $objectlist = $this -> load_file($file);

    foreach ($objectlist as $val)
    {
      if (eregi('\[',$val))
      {
        $delegate = trim($val,'\[]');
      }
      else
      {
        $key_val = explode("=",$val);
        $key_val[0] = trim($key_val[0]);
        $key_val[1] = trim($key_val[1]);
        $this -> set_objectlist
          ( $delegate, array($key_val[0] => $key_val[1]) );
      }
    }
  }
  
  function set_objectlist($delegate='',$args='')
  /*****************************************************
   wpisuje metody wraz z argumentami wywo³ania do tablicy
   kluczem jest nazwa_klasy:nazwa_metody warto¶ci± jest 
   tablica argumentów metody
  *****************************************************/
  { 
    if ( is_array($delegate) )
    {
      foreach ($delegate as $key => $val)
      { 
        $this -> objectlist[$key] = $val;
      }
      return true;
    }
    elseif ( !empty($delegate) and is_array($args) )
    {
      foreach ($args as $key => $val)
      {
        $this -> objectlist[$delegate][$key] = $val;
      }
      return true;
    }
    else
    { 
      return false;
    }
  }
  
  function parse_object($delegate='')
  /*****************************************************
   wywo³uje podan± metodê z potrzebnymi argumentami. 
   wynik dzia³ania stanowi wype³nienie dla odpowiedniego 
   pola i jest wstawiany do tablicy pól. metoda nadpisuje
   wype³nione pola.
  *****************************************************/
  { 
    if (empty($delegate))
    {
      return false;
    }
    elseif ( !empty($this -> objectlist[$delegate])
        and !empty($this -> objectfield))
    {
      $args      = $this -> objectlist[$delegate];
      $fields    = array_keys( $this -> objectfield, $delegate);
      $object    = explode(":",$delegate);
      $delegate = trim($object[1]);
      $class    = trim($object[0]);
      
      if ( class_exists($class) )
      {
        $object = new $class;
        $object = $object -> $delegate($args);

        if ( !empty($fields) )
        {
          foreach ( $fields as $val )
          { 
            $this -> set_field( $val,$object);
          }
        }
        else
        { 
          $this -> set_field( $class,$object);
         }
        return true;
      }
    }
    else
    { 
      return false;
    }
  }
  
  function parse_objectlist()
  /*****************************************************
   przetwarza aktualn± listê metod wype³niaj±c pola 
   szablonu wynikiem ich dzia³ania.
  *****************************************************/
  { 
    if ( !empty($this -> objectlist) )
    {
      foreach ( $this -> objectlist as $val )
      { 
        $this -> parse_object($val);
      }
      return true;
    }
    else
    { 
      return false;
    }
  }

  function save_objectlist($file='objectlist.cfg.php')
  /*****************************************************
   zapisuje aktualn± listê metod i ich argumentów do pliku
  *****************************************************/
  { 
    if ( !empty($this -> objectlist) )
    {
      $filename = $this -> pathes['config'] . $file;
      $fid = fopen($filename,'w+');

      foreach ( $this -> objectlist as $key => $args )
      { 
        $key = '[' . $key . "]\n";
        fwrite($fid, $key);

        foreach ( $args as $var => $val)
        {
          $var = "\t" . $var . '=' . $val . "\n";
          fwrite($fid, $var);
        }
      }
      return true;
    }
    else
    { 
      return false;
    }
  }

  function save_objectfield($file='objectfield.php')
  /*****************************************************
   zapisuje aktualn± rezerwacjê pól przez obiekty
  *****************************************************/
  { 
    if ( !empty($this -> objectfield) )
    {
      $filename = $this -> pathes['config'] . $file;
      $fid = fopen($filename,'w+');

      foreach ( $this -> objectfield as $field => $delegate )
      { 
        $field = $field . '=' . $val . "\n";
        fwrite($fid, $key);
      }
      return true;
    }
    else
    { 
      return false;
    }
  }
}
// end of class Page
?>
