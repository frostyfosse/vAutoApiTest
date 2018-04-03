# vAutoApiTest
This is a sample project used to send several REST calls collecting data, then posts an end result.  To run the test simply download the repo, compile the solution ("source\vAuto.sln"), set the startup project to "vAutoApiTest", set your breakpoints (where desired), and start the project up.  

Disclaimer: The rest api client used was generated from the exposed endpoint (using the Swagger Generator from https://generator.swagger.io/) where this project is testing against (Not something created originally from this repo). However, now testing with this generated client, I would ultimately replace this with my own client because it doesn't support asynchronous calls.
