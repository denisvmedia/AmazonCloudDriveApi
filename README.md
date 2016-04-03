Amazon Cloud Drive Api for .NET
===============================
General implementation of REST API for Amazon Cloud Drive. Not all functions are implemented, but it can download/upload files and organize files/folders.

Notes
-----
The original version of this library does not properly close the HTTP-connection during upload/replace procedures (when cancellation is requested).
This is a patched version that fixes this bug.

In addition, this version of library provides a more flexible way to work with upload and replace requests. Due to this change, you need to patch your code before using this version of library.