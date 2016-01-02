XP Runners
==========

Setup:

```sh
$ cp ~/bin/class-main.php . # From current XP runners
```

Compile:

```sh
$ csc /target:exe /out:xp.exe src\\*.cs src\\commands\\*.cs
```

Test:

```sh
$ ./xp.exe version
XP 7.0.0-dev { PHP 7.0.0 & ZE 3.0.0 } @ Windows NT SLATE 10.0 build 10586 (Windows 10) i586
Copyright (c) 2001-2015 the XP group
FileSystemCL<...\xp\core\src\main\php\>
FileSystemCL<...\xp\core\src\test\php\>
FileSystemCL<...\xp\core\src\main\resources\>
FileSystemCL<...\xp\core\src\test\resources\>
FileSystemCL<...\cygwin\home\Timm\devel\runners\>
```

Commands
--------
The following commands are builtin:

* **version** - Displays version and exits - *also `-v`*
* **eval [code]** - Evaluates code - *also `-e [code]`*
* **write [code]** - Evaluates code, writes result to Console - *also `-w [code]`*
* **dump [code]** - Evaluates code, var_dump()s result - *also `-d [code]`*
* **help** - Displays help - *also `-?`*
* **run** - Runs a class

If no command line arguments are given, the help command is run. If command line arguments are given, but no command is passed, the command defaults to *run*.

Plugins
-------
Libraries may provide commands by adding a vendor binary to their composer.json named xp.[vendor].[name] - for the [unittest](https://github.com/xp-framework/unittest/blob/master/bin/xp.xp-framework.unittest) command, the entry is:

```json
{
  "bin": ["bin/xp.xp-framework.unittest"]
}
```

By installing the package globally, it becomes available in any directory.

```sh
$ composer global require xp-framework/unittest:dev-master
# ...

$ ./xp.exe unittest -e '$this->assertTrue(true)'
[.]

✓: 1/1 run (0 skipped), 1 succeeded, 0 failed
Memory used: 1267.07 kB (1417.43 kB peak)
Time taken: 0.000 seconds
```