


# Engie-PowerPlant

![](logos/swagger.png)


- [Engie-PowerPlant](#engie-powerplant)
  * [Run  and Install the application](#run-and-install-the-application)
    + [Single Host](#single-host)
    + [Container](#container)
  * [Open API Specification of the application](#open-api-specification-of-the-application ) 
  * [Technical Approach](#technical-approach)
  * [ Design Pattern ](#design-pattern )
     
        




My implementation of : [powerplant-coding-challenge](https://github.com/gem-spaas/powerplant-coding-challenge)

The application that I have developped is based on the .NET Core 5.0  ,  a full Web API ( Restfull ) 

A lightweight application that we can deploy in the cloud ( Azure app services or  Azure kubernetes services) 

# Run and Install the application
The easiest way is to install Visual studio community edition and just run the app.

## Single Host
### Depedencies
 We need the follolwing packages :
  - A Windows , Mac or Linux machine 
  - dotnet core sdk and runtime , version 5.0  ( Cf : [Donwload .Net core runtime](https://dotnet.microsoft.com/download) )
  - basic knowledge of the  command line with the dotnet CLI
    
### Command

  - First Donwload this or clone this Project , Open a terminal / Command Prompt
  - `cd Engie-PowerPlant`
  - `dotnet restore`
  -  `dotnet build` 
  -  `dotnet run ( or dotnet watch run)` 
     
## Container
### Depedencies
    On Container , We need  the docker engine present on the machine , docker is running on Linux 
    , Mac and Windows with GUI for some of the them
   [Desktop](https://www.docker.com/products/docker-desktop)
   
   [Linux](https://docs.docker.com/engine/install)
    
    
### Command
- Open a command prompt 
- `cd Engie-PowerPlant`
- `docker build -t powerplant.api . `
- `docker run -d -p 8888:8888 --name myapp powerplant.api`


  
# Open API Specification of the application

The app provides an API specification for any kind of client implementation : 

- On local `http://localhost:8888/swagger/index.html`
- Route : `/swagger/index.html`

# Technical Approach

The most important factor is the price per MWH   , so we have to choose the list powerplants ( and power )  that produce the cheapest energy (price).
The final sum of all prices (  price load = Σ Pi* Costi ) should be optimized at the end of the calculation . A kind of mathematical function with many variables.

But the criteria are : 

- Considering their efficiency ( less efficient will cost more )
- Include Co2 allowance price in the final price 
- Consider the Pmin constraint : We need only to produce energy that match exaclty the load , no waste 
- Windturbine , Solar energy and renewable powerplants are depending on external factors ( weather , sun power , temperature , pressure ) 


1 - Order by cheapast price ( unclude C02 price) 
2-  Order by Pmin 
3- Loop via the list untill all the sum match the load ,  
4 - Because of Pmin ,  We are forced to use the overflow of power , so during the loop we have to  ajust sometimes the power calculation for 02 successive powerplant in order to distribute it correclty.


# Design Pattern 

I use TDD with MSTest during the implementantion with  Service , Converter , Dto  and  Strategy Pattern , each component in the app can be injected and mocked with 
The Ioc Container , We can add easily a new Power Plant type without affecting the behavior of the other components 

Controller ->  Converter ( Dto ) - >  Service ( Model / Entity ) 


Controller <-  Converter ( Dto ) <-  Service ( Model / Entity ) 


![](logos/powerplantclass-diag.png)







 


