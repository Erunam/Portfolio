<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html>
<head>
<meta http-equiv="Content-type" content="text/html; charset=iso-8859-2" />
<meta http-equiv="Creation-date" content="2003-12-18T16:29:00Z" />
<meta http-equiv="Reply-to" content="danieldubaj@op.pl" />
<meta http-equiv="Content-Language" content="pl" />
<meta name="Author" content="magdalena i daniel dubaj" />
<meta name="Robots" content="ALL" />
<LINK REL=stylesheet HREF="./../../../style.css" TYPE="text/css">
<title>FreeLancer's Unformal Group "k e l e b r i n"</title>
</head>

<body>

<table class="back"  height="100%" cellpadding="0" cellspacing="0" border="0" width="100%">
<tr height="100%"><td align="center" valign="top">

   <table class="in" cellpadding="0" cellspacing="0" border="0" height="100%">
      <tr valign="center"><td>

      <table cellpadding="0" cellspacing="0" border="0" align="center" class="portfolio">
      <tr><td class="text" style="text-align: center;" style="padding: 6pt 0pt 6pt 0pt;">
      <a href="leksykon.php?page=61" class="manual"> [Template] </a>
      <a href="leksykon.php?page=62" class="manual"> [Box] </a>
      <a href="leksykon.php?page=63" class="manual"> [Page] </a>   
       "Aquarium" - PHP TemplateSystem
      </td></tr>
      <tr><td class="text">
      <div>
      
            <?php
               $title = array ('61'=>'Template','62'=>'Box','63'=>'Page');
               if (!empty($_GET['page']))
               { $page = $_GET['page'];}
               else
               { $page='0';}
               if ( ereg( "[0-9]",$page ) )
               {
                  $pagename = './manual' . $page . '.php';
               }
               else
               {
                  $pagename = $page . '.php';
               }
            ?>
         <p><span style="font-size:14px; font-weight: bold">
            <?php
               print_r($title[$page]);
            ?>
         </span></p>
            <?php
                  include($pagename);
            ?>
      </div>
      </td></tr>
      <tr><td class="text" style="text-align: center;" style="padding: 6pt 0pt 6pt 0pt;">
      <a href="leksykon.php?page=61" class="manual"> [Template] </a>
      <a href="leksykon.php?page=62" class="manual"> [Box] </a>
      <a href="leksykon.php?page=63" class="manual"> [Page] </a>
      "Aquarium" - PHP TemplateSystem
      </td></tr>
      </table>
            
      </td></tr>
   </table>
</td></tr>
</table>

</body>
</html>
