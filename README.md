# GoogleBard CLI

## Description

A simple command-line interface to Google's Bard Artificial Intelligence Chatbot.

## Installation

What are the steps required to install your project? Provide a step-by-step description of how to get the development environment running.

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
