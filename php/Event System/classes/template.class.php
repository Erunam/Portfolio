<?php
/*************************************************************************\
*     Name  : template class ver. 2.1                                     *
*     Author: Magdalena and Daniel Dubaj                                  *
*     WWW   : http://www.kelebrin.prv.pl                                  *
*     E-mail: danieldubaj@op.pl                                           *
*     Date  : 29 November 2003                                            *
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

// begin class template
class Template
{
  var $fieldlist;   //the table of the field existed in the template files
  var $filelist;    //the table of aliases of the template files
  var $last;        //a name of the last used variable
  var $pathes;      //root directory

   function Template($path='.')
   {
    $this -> fieldlist  = array();
    $this -> filelist = array();
    $this -> last;
    $this -> pathes['root'] = $path . '/';
    if ( is_array($path) )
    {
       $this -> set_pathes($path);
    }
    else
    {
       $this -> pathes['template'] = $path . '/template/';
    }
   }

   function set_pathes($path='',$res='')
   /*****************************************************
    metoda ustawia ¶cie¿ki dostêpu do zasobów
   *****************************************************/
   {
      if ( is_array($path) )
      {
         foreach ($path as $key => $val)
         { 
            $val = $this -> pathes['root'] . $val;
            $this -> pathes[$key] = $val . '/';
         }
         return true;
      }
      elseif (!empty($path) and !empty($res))
      {
         $path = $this -> pathes['root'] . $path;
         $this -> pathes[$res] = $path . '/';
         return true;
      }
      else
      {
         return false;
      }
   }
   
  function set_filelist($alias='',$file='',$res='template')
  /*****************************************************
   metoda wpisuje dane do tablicy $filelist:
     kluczem w tablicy jest przypisana nazwa (alias)
     warto¶ci± ¶cie¿ka do pliku
   the method inserts data to the table $filelist
     a key of this table is the template file alias
     a key value is the path to the suitable file
  *****************************************************/
  {
    if (is_array($alias) and !empty($file))
    {
      foreach($alias as $key => $val)
      {
         $val = $this -> pathes[$file] . $val;
         $this -> filelist[$key] = $val;
      }
      return true;
    }
    elseif ( !empty($alias) and !empty($file) )
    {
      $this -> filelist[$alias] = $this -> pathes[$res] . $file;
      return true;
    }
    else
    {
      return false;
    }
  }

  function set_field($field='',$value='')
  /*****************************************************
   metoda wpisuje dane do tablicy $fieldlist:
     kluczem jest nazwa zmiennej wystêpuj±cej w szablonie
     warto¶ci± jest tekst do wstawienia.
   method inserts data to the table $fieldlist
     key of this table is the name of occurent in the 
     template variable value is the text to replacement
  *****************************************************/
  {
    if (is_array($field))
    {
      foreach( $field as $key => $val)
      {
        $this -> fieldlist[$key] = $val;
      }
      return true;
    }
    elseif ( !empty($field) and !empty($value) )
    {
      $this -> fieldlist[$field] = $value;
      return true;
    }
    else
    { 
      return false;
    }
  }

  function parse($alias='',$field='',$n=1)
  /*****************************************************
   metoda sprawdza tryb pracy:
     tryb pojedynczy:  podstawianie zmiennych i umieszczenie
                       wyniku dzia³ania w tablicy fieldlist
     tryb sumuj±cy  :  wynik dzia³ania jest ³±czony z ju¿ 
                       istniej±ca zmienn± n razy
   domyslny tryb pracy to pojedynczy
   the method check the mode of work:
     single mode  :    the replemcement of the variables and
                       the putting the result into fieldlist
     add mode     :    the result of action is united with
                       existed variable
   default is add mode
  *****************************************************/
  {
    $add = false;

    if ( substr($alias,0,1) == '.')
    {
      $add = true;
      settype($n,'integer');
      if ($n < 1){ $n = 1; }
      $alias = substr($alias,1);
    } 

    if (empty($field))
    {
      $field = $alias;
    }

    $this -> last = $field;
  
    if ( !isset ($this -> fieldlist[$field]) )
    {
      $template = "";
    }                      
    else
    {
      $template = $this -> fieldlist[$field];
    }
    
   
    if ($add)
    {
       for ($i = 1; $i <= $n; $i++)
       {
          $template .= $this -> replacement($alias);
       }
    }
    else
    {
      $template = $this -> replacement($alias);
    }
  
    $this -> set_field($field,$template);
  }

  function replacement($alias)
  /*****************************************************
   metoda pobiera plik szablonu i podmienia znajduj±ce 
   siê w nim zmienne wg tablicy fieldlist
   the method load template file and replace finded in
   the file variable according table fieldlist
  *****************************************************/
  {
    $template = $this -> load_template($alias);

    foreach ($this -> fieldlist as $key => $val)
    {
      $key = "{".$key."}";
      $template = ereg_replace("$key","$val","$template");
    }
    
    return $template;
  }

  function load_template($alias)
  /*****************************************************
   metoda pobiera plik do zmiennej
   the method load the template file into variable
  *****************************************************/
  {
    $file = $this -> filelist[$alias];
    $template = @file($file) or die("the file is not exist: $file");
    $template = trim(implode("",$template));
    return $template;
  }

  function printing($field='')
  /*****************************************************
   metoda drukuje zmienn± w oknie przegl±darki, domy¶lnie
   jest drukowana ostatnio zapisana zmienna
   the method send the variable to the explorer window,
   default last used variable is printed
  *****************************************************/
  {
    if (empty($field))
    {
      $field = $this -> last;
    }
    print_r ($this -> fieldlist[$field]);
  }

  function get_field($field='')
  /*****************************************************
   metoda zwraca warto¶æ zmiennej z tablicy fieldlist
   the method return the value of the variable from the 
   table fieldlist
  *****************************************************/
  {
    if (empty($field))
    {
      $field = $this -> last;
    }
    $field = @$this -> fieldlist[$var] or $field = "non defined field";
    return $field;
  }

  function get_file($alias)
  /*****************************************************
   metoda zwraca nazwê pliku o podanym aliasie
   the method return the name of file with given alias
  *****************************************************/
  {
    $alias = @$this -> filelist[$alias] or $alias = "non defined file: $alias";
    return $alias;
  }

}
// end of the class template
?>
