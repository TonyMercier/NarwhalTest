# NarwhalTest
## Content
This repository contains all the projects from this repository: https://github.com/OneOceanGroup/Narwhal.
It also contains my take on the technical test in this folder/project: NarwhalTest. 

## NarwhalTest - Description
The NarwhalTest project is a simple API that fetches data from Narwhal.Service and processes Distance traveled by each vessel, Average speed for each vessel and intersection points between vessels.

## NarwhalTest - How to run
* To run it, simply execute start_docker.bat at the root of the repository. 
* If it's your first time running it, you'll need to execute this after in order to import the test data: Narwhal.ETL\start_local.bat 
* To see it in action, access the following endpoint once it's running: http://localhost:6170/TrackingInfos?from=2018-04-23&to=2018-04-24
* If you wish to debug it (or see it running step by step) you can lauch th NarwhalTest.Api project in the solution. If you want to launch it in Docker, you'll have to edit the NarwhalServiceClientOptions.BaseUrl entry in appsettings.json and replace localhost with your pc's local ip. <B>Or you could simply execute it in IIS and it'll work built in</b>


## Addition notes
Collection.Remove() has been deprecated for a while in Pymongo, it has been replaced with Collection.delete_many(). This affects the Narwhal.ETL project. You might want to update it :)

