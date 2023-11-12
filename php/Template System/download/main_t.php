<?php
// include template class   
   require_once( './classes/template.class.php' );

// new page with default TemplateSystem path (current folder)
   $page = new Template();

// defining the template file by aliases
   // single method definition (one file - one alias)
   $page -> set_file( 'row','row_t.html.php' );

   // multiple definition method (more file with the one's own alias)
   $page -> set_file( array ('main' => 'table_t.html.php',
                             'page' => 'main_t.html.php') 
                     );
// filling the template fields by values
   // filling fields from script
   $page -> set_field( 'title','Example Aquarium Page' );
   // name table
   $surname = array ( ' John Brown ',
                      ' Jan Kowalski ',
                      ' Adam Nowak ',
                      ' Mr. Smith ',
                      ' Smitrij Kowalenko ',
                      ' Mieczys³aw Wielegorzej ');
   
   for ($i=1;$i<=6;$i++)
   {
      $fieldtable = array ( 'number' => " nr. $i ",
                            'name' => $surname[$i-1]);
   // multiple filling method, old values are deleted
      $page->set_field($fieldtable);
   // using parse method for filling the field "rows"
      $page->parse('.row','rows');
   }
   // filling field "main" from file table_t.html.php.
   $page -> parse('main');
   // parsing the template file
   $page -> parse('page');
   // viewing the efect of the work
   $page -> printing();
?>
