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
      <tr height="90px"><td valign="top">
	<table width="100%" cellpadding="0" cellspacing="0" border="0" class="header">
        <tr height="65px"><td colspan="5"></td></tr>
	<tr>
	<td width="250px"></td>
	<td><a href="../index.php">h o m e</a></td>
	<td><a href="../about.php">a b o u t</a></td>
   	<td><a href="../portfolio.php">p o r t f o l i o</a></td>
	<td><a href="../freelancer.php">f r e e l a n c e r s</a></td>
	</tr>
	</table>
      </td></tr>
      <tr valign="center"><td>

            <?php
               if (!empty($_GET['page']))
               { $page = $_GET['page'];}
               else
               { $page='0';}
               if ( ereg( "[0-9]",$page ) )
               {
                  $page = './manual' . $page . '.php';
               }
               else
               {
                  $page = $page . '.php';
               }
               include($page);
            ?>
            
      </td></tr>
   </table>
</td></tr>
<tr><td valign="bottom">
   
   <table align="center" cellpadding="0" cellspacing="0" border="0" class="foot" style="background-color:transparent;">
      <tr>
      <td width="50%" align="left"> last modified: 28th October 2003 </td>
      <td width="50%" align="right"> powered by: <img src="./../../../images/stamp.jpg" border="0" alt="kelebrin stamp" align="top"/></td>
      </tr>
   </table>
</td></tr>
</table>

</body>
</html>
