## About ##

I created this app for learning purposes. It is just a winforms app that you can use to encrypt and decrypt text files.

## How it works ##

The encryption is made using AES-256, with the key being generated with PBKDF2, using a unique salt and IV for each file (following best practices). While I am aware there may be vulnerabilities I'm not yet familiar with, this project is not intended for real-world use.
