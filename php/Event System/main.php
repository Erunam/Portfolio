<?php

require_once('./classes/events.class.php');

$AppManager = new Events();

$classes = $AppManager->dlg_get_classes();

foreach ($classes as $key => $val)
{
   require_once($val);
}

//$AppManager -> save_delegatelist('data.php');

$AppManager -> event('application:start');

?>
