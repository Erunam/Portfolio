<?php
/*************************************************************************\
*    Name  : box class ver. 1.0 beta                                      *
*    Author: Magdalena and Daniel Dubaj                                   *
*    WWW   : http://www.kelebrin.prv.pl                                   *
*    E-mail: danieldubaj@op.pl                                            *
*    Date  : 13 October 2003                                              *
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
*                                                                         *
*  You should have received a copy of the GNU General Public Licensea     *
*  along with this program; if not, write to the Free Software Foundation,*
*  Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.        *
\*************************************************************************/

require_once('template.class.php');

//begin class Box
class Box extends Template
{
  var $pathes;    // pathes to resources for box
  var $tree;      // each file have got a parent 
  var $queue;     // files queue for recursive parsing

  function Box($path='.')
  /*****************************************************
  
  *****************************************************/
  {
    $this -> fieldlist  = array();
    $this -> filelist = array();
    $this -> last;
    $this -> tree  = array();
    $this -> queue = array();
    $this -> pathes['root'] = $path . '/';
    $this -> pathes['template'] = $path . '/template/';
    $this -> pathes['config'] = $path . '/config/';
    $this -> pathes['lang'] = $path . '/lang/';
  }
  
  /*
  function set_filelist($alias='',$file='')
  */
  /*****************************************************
  metoda ustawia pe�n� �cie�k� dost�pu do pliku, tak
  poprawiona nazwa pliku i jego alias jest wpisywany do 
  tablicy filelist. wpisuje pojedynczo i z tablicy
  *****************************************************/
  /*
  {
    if (is_array($alias))
    {
      foreach($alias as $key => $val)
      {
        $val = $this -> pathes['template'] . $val;
        $this -> set_file( $key, $val );
      }
    }
    elseif ( !empty($alias) and !empty($file) )
    {
      $file = $this -> pathes['template'] . $file;
      $this -> set_file($alias,$file);
    }
    else
    {
      return false;
    }
  }
  */
  
  function read_filelist($file='filelist.cfg.php')
  /*****************************************************
   wczytuje list� plik�w zasob�w z pliku o formacie
      alias_pliku = nazwa_pliku - nazwa_pliku bez �cie�ki
   do tablicy filelist
  *****************************************************/
  { 
    $file = $this -> pathes['config'] . $file;
    $filelist = $this -> load_file($file);
    foreach ($filelist as $val )
    { 
      $key_val = explode("=",$val);
      $key_val[1] = $this -> pathes['templates'] . trim($key_val[1]);
      $this -> set_file( trim($key_val[0]),$key_val[1] );
    }
  }  

  function read_fieldlist($file='fieldlist.cfg.php')
  /*****************************************************
   wczytuje list� p�l szablonu z pliku o formacie
      nazwa_pola = wype�nienie - wype�nienie jest ci�giem
   kt�ry ma si� pojawi� w miejscu pola po sparsowaniu pliku
   mo�e by� puste.
  *****************************************************/
  { 
    $file = $this -> pathes['lang'] . $file;
    $fieldlist = $this -> load_file($file);
    foreach ($fieldlist as $val )
    { 
      $key_val = explode("=",$val);
      $this -> set_field( trim($key_val[0]),trim($key_val[1]) );
    }
  }
  
  function load_file($file)
  /*****************************************************
   wczytuje plik i zwraca go jako tablic�
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

  function set_queue($alias)
  /*****************************************************
   ustawia kolejno�� parsowania plik�w od najbardziej
   zagnie�d�onego do podanego aliasem.
  *****************************************************/
  { 
    if ( !is_array($this -> tree)
      or empty($this -> tree[$alias])  )
    {
      print('error - alias tree is not good');
      return false;
    }

    $ind = 0;
    $this -> queue[$ind] = $alias;

    do
    {
      $alias = $this -> queue[$ind];
      $ind++;
      $alias = array_keys($this -> tree,$alias);
      
      if ($alias != null)
      {
        foreach ($alias as $val)
        {
          array_push($this -> queue,$val);
        }
      }
    }
    while ($ind-1 <= count($this -> queue));

    $this -> queue = array_reverse($this -> queue);
    return true;
  }

  function parse_tree($alias='',$field='')
  /*****************************************************
   metoda przetwarza plik podany aliasem oraz wszystkie
   w nim zagnie�d�one, wynik wstawia do podanego pola.
   nie zast�puje ju� wype�nionych p�l.

   WARNING: this method do not parse dynamic block
    for example: if you want receive table with unknown
    earlier number of rows, you must do this differently
    this methon parse file only once.
   INFO: this method do not replace existed field in 
    array fieldlist.
  *****************************************************/
  { 
    if (empty($field))
    {
      $field = $alias;
    }
    
    if ( $this -> set_queue($alias) )
    {
      foreach ($this -> queue as $alias)
      { 
        if ( empty($this -> fieldlist[$alias]) )
        {
           $this -> parse ($alias,$alias);
        }
      }
      unset($this -> queue);
      return true;
    }
    else
    {
      return false;
    }
    
  }

  function read_tree($file='treefile.cfg.php')
  /*****************************************************
   wczytuje list� hierarchiczn� plik�w. je�li wynik
   przetwarzania pliku A ma by� umieszczony w pliku B to
   plik B jest rodzicem (parent) wzgl�dem A.
   format pliku: alias_pliku_dziecka = alias_pliku_rodzica
  *****************************************************/
  {
    $file = $this -> pathes['config'] . $file;
    $tree = $this -> load_file($file);
    foreach ($tree as $val )
    { 
      $key_val = explode("=",$val);
      $this -> set_tree(trim($key_val[0]),trim($key_val[1]));
    }
  }
  
  function set_tree($alias='',$parent='')
  /*****************************************************

  *****************************************************/
  { 
    if (is_array($alias))
    { 
      foreach ($alias as $key => $val)
      { 
        $this -> tree[$key] = $val;
      }
    }
    elseif ( !empty($alias) and !empty($parent) )
    { 
      $this -> tree[$alias] = $parent;
    }
  }
  
  function create_tree()
  /*****************************************************
   nie zaimplementowana w tej wersji. w za�o�eniu ma
   wyszukiwa� w plikach szablonu pola kt�re s� plikami 
   i ustawia� tablic� hierarchiczn�.
   
   not implement in this version.
    method will should check the each file for fields 
    and will create array tree
  *****************************************************/  
  {
    print('! not implement in this version !');
    return false;
  }
  
}
// end of class box
?>
