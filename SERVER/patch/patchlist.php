<?php

// open this directory 
$myDirectory = opendir(".");

// get each entry
while($entryName = readdir($myDirectory)) {
	$dirArray[] = $entryName;
}

// close directory
closedir($myDirectory);

//	count elements in array
$indexCount	= count($dirArray);
//Print ("$indexCount files<br>\n");

// sort 'em
sort($dirArray);

$output = "";

// print 'em
// loop through the array of files and print them all


/*
for($index=0; $index < $indexCount; $index++) {
        if (substr("$dirArray[$index]", 0, 1) != "." && "$dirArray[$index]" != "index.php" && "$dirArray[$index]" != "version.php" && "$dirArray[$index]" != "MOTD.txt"){ // don't list hidden files
			if($output != "")
				$output = $output . "|";
		
			$output = $output . $dirArray[$index];
	}
}
*/

for($index=0; $index < $indexCount; $index++) {
	

        //if (substr("$dirArray[$index]", 0, 1) != "." && "$dirArray[$index]" != "@eaDir" &&  && !endsWith("$dirArray[$index]",".php")) // don't list hidden files, txt and php files
		if ($dirArray[$index] != "." && $dirArray[$index] != "..") // don't parent directories
		{
			if(filetype($dirArray[$index]) == "dir") //if is a directory
				print("$dirArray[$index]|");

		}
}






print($output);

?>