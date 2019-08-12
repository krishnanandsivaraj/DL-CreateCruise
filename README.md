# DreamLines - Create Cruise

## Mission Statement
As a Content Manager, I want to be able to create cruises, so that the agents can sell it online

## Ubiquitous Languages

  - Cruise line
  - Cruise
  - Route
  - Route Stop
  - Cabin Category/ Cabin Type

## High Level Architecture
### Current System
![highleveldiagram](https://github.com/krishnanandsivaraj/DL-CreateCruise/blob/master/HLD-basic.JPG "Logo Title Text 1")

### Proposed System
![highleveldiagram](https://github.com/krishnanandsivaraj/DL-CreateCruise/blob/master/HLD-serverless.JPG "Logo Title Text 1")

### UI- LIFT Principle

We follow the LIFT principle during our approach (http://bguiz.github.io/js-standards/angularjs/application-structure-lift-principle/)
For our template, we have three major modules inside AppModule
1)	sharedmodule - contains the common components required for all pages(i.e header,footer)
2)	Widgetsmodule - contains all the components that can be used on the pages.  These widgets are reusable across all the pages.
3)	Pagesmodule - module that contains templates for all pages.  We have to integrate our widgets inside these modules.
![uifolderstructure](https://github.com/krishnanandsivaraj/DL-CreateCruise/blob/master/UIFolder.JPG "Logo Title Text 1")

### Api architecture
![apifolderstructure](https://github.com/krishnanandsivaraj/DL-CreateCruise/blob/master/CleanArchitecture.jpg "Logo Title Text 1")

![apiswagger](https://github.com/krishnanandsivaraj/DL-CreateCruise/blob/master/swagger.JPG "Logo Title Text 1")

![uiapp](https://github.com/krishnanandsivaraj/DL-CreateCruise/blob/master/uiproj.JPG "Logo Title Text 1")

