# Buggy Code
$fileList = Get-ChildItem $fileDir

ForEach($file in $fileList)
{
    Copy-Item $file.FullName $archiveDir
    Copy-Item $file.FullName $workingDir\Pending
}

Remove-Item $fileDir\* -force


# Correct Code
$fileList = Get-ChildItem $fileDir

ForEach($file in $fileList)
{
    Copy-Item $file.FullName $archiveDir
    Copy-Item $file.FullName $workingDir\Pending
    Remove-Item $file
}
