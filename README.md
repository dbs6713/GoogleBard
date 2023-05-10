# GoogleBard CLI

## Description

A simple command-line interface to Google's Bard Artificial Intelligence Chatbot.

## Installation

1. Clone the repository
2. In the project directory, run `dotnet build --configuration Release`
3. Copy the `bin/Release/net6.0/GoogleBard` file to a directory in your `PATH` environment variable
4. It will create a log file of the questions and answers in the current directory of the executable

## Usage

Get the current session ID:

1. Go to `https://bard.google.com`
2. Open developer tools
3. Go to Application -> Cookies
4. Copy the content of `__Secure-1PSID`
5. Set the environment variable `BARD_SESSION` to the value of `__Secure-1PSID`, example:

```bash
export BARD_SESSION=<__Secure-1PSID>
```

## Credits

- Don Stringham
