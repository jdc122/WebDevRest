# OceansideRestaurant

Milestone 1
01/12/25
please check the word doc to see design ideas, explantion of progress etc


18/12/25:

Milestone 2 Changes made > Updated to add local database with preset items. Item names/prices etc for menu items proposed in milestone 1 document have been added but database needs updating/migrating to reflect live on the page instead of currently only being in the initialiser file. JS location of shop has been added to footer.

See Admin/Login-Pages branch for additional code not yet implemented into main branch. The admin edit/delete pages are included, as well as the login/registration/checkout etc pages, however they do not currently run in main due to .net version compatibility issues and incorrectly setup scaffolding when adding to the project. These have been moved to ensure that the main solution can run currently without crashing on build due to database issues.


TODO: Identity model needs setting up.
CSS/Styling is currently bare because i prefer to make sure the backend is working before working on styling. Login page will be added as a barebones data entry form but will not function until Admin/Login-Pages is merged.
