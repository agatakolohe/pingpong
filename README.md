# Ping-Pong

#### Looping Practice with C# for Epicodus, 12-07-2020

#### By Agata Kolodziej, Patric Osten, Taylor Delph

## Description

Ping-pong is a classic programming exercise that utilizes branching and looping. Here's how it works:
A user enters a number and the application returns all numbers from 1 to the user input with the following changes:
All numbers divisible by 3 are replaced by "ping".
All numbers divisible by 5 are replaced by "pong".
All numbers divisible by both 3 and 5 are replaced by "ping-pong".
If the user enters 15, the program will return: 1, 2, "ping", 4, "pong", "ping", 7, 8, "ping", "pong", 11, "ping", 13, 14, "ping-pong"

## Specifications

### Describe: PingPong

| Test                                                                   | Expect                                                                                       |
| ---------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| It will return a range of numbers from 1 to the user's inputted number | PingPong(4).toEqual([1,2,3,4])                                                               |
| It will replace all numbers divisible by 3 with "ping"                 | PingPong(4).toEqual([1,2,"ping",4])                                                          |
| It will replace all numbers divisible by 5 with "pong"                 | PingPong(5).toEqual([1,2,"ping","pong"])                                                     |
| It will replace all numbers divisible by 3 and 5 with "ping-pong"      | PingPong(15).toEqual([1,2,"ping",4,"pong", 6,7,8,"ping","pong",11,"ping",13,14,"ping-pong"]) |

## Setup/Installation Requirements

##### Software Requirements

1. Internet browser
2. A code editor such as VSCode to view and edit the code
3. Access to your terminal

##### Open Locally

- Click on the link to my repository: [My Respository](https://github.com/agatakolohe/pingpong.git)
- Click on the green "Code" button and copy the repository URL
- Open your terminal and use the command `git clone https://github.com/agatakolohe/pingpong.git` into the directory you would like to clone the repository
- Open in text editor to view code and make changes
- Open terminal `dotnet run`

## Known Bugs

No known bugs present.

## Support and Contact Details

If any errors or bugs occur google the error messages or please email me, <agatakolohe@gmail.com>

## Technologies Used

- C#
- VS Code
- GitHub

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

Copyright (c) 2020 Agata Kolodziej, Patrick Osten, Taylor Delph
