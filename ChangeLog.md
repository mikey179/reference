XP Runners change log
=====================

## ?.?.? / ????-??-??

## 7.2.0 / ????-??-??

* Optimized entry point scripts by inlining code - @thekid
* Merged xp-runners/main#1: Run scripts without "-e" - @thekid

## 7.1.2 / 2016-02-01

* Fixed issue #32: xp help ambiguity - @thekid
* Fixed issue #31: xp help topics for builtins - @thekid

## 7.1.1 / 2016-01-31

* Fixed `Paths.Binary()` to return the correct results when run with
  mono, standalone on Windows, mkbundle'd binaries and verify this
  works on Windows, Linux and Mac OS X.
  See https://github.com/xp-runners/spec/issues/1#issuecomment-177540328
  (@thekid)

## 7.1.0 / 2016-01-31

* Added support for Mac OS X, see xp-runners/reference#30 - @thekid

## 7.0.0 / 2016-01-31

* Made installable via `apt-get` on Ubuntu and Debian, and provided a one-
  liner "https-verified" installer (see xp-runners/reference#29)
  (@thekid)
* Made path files and `-cp` behave consistently, see xp-runners/reference#11:
  * New `-cp?` argument, which declares an optional class path
  * New `-cp!` argument, which declares an overlay class path
  * Added support for `.php` files in class path
  (@thekid)
* Merged PR #3: Support XP5. The new XP runners also support XP 5.X checkouts
  although **this is to be considered deprecated** (for the discussion, see
  https://github.com/xp-runners/reference/issues/1#issuecomment-168872536)
  (@thekid)
* Added support for ANSI color escape sequences inside Windows Console
  (@thekid)
* Implemented plugin architecture based on Composer and file naming conventions
  `xp.{vendor}.{name}[.{command}]` => `xp.{module}.{ucfirst(command)}Runner`
  (@thekid)
* Added mapping for Windows Timezones to `date.timezone setting`. No more 
  configuration via xp.ini necessary anymore now.
  Inspired by https://github.com/lmcnearney/timezoneinfo-olson-mapper
  (@thekid)
* Initial implementation of xp-framework/rfc#303 with the following commands:
  * **version** - Displays version and exits - *also `-v`*
  * **eval [code]** - Evaluates code - *also `-e [code]`*
  * **write [code]** - Evaluates code, writes result to Console - *also `-w [code]`*
  * **dump [code]** - Evaluates code, var_dump()s result - *also `-d [code]`*
  * **help** - Displays help - *also `-?`*
  * **run** - Runs a class
  * **ar** - Works with XAR archives. See xp-runners/reference#22
  (@thekid)