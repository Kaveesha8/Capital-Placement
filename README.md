# Capital-Placement

Initially I created DTO’s for each question type.
DateQuestion Type
DopDownQuestion Type
Numeric Question Type
Paragraph Question Type
Yes/No Question Type

And I used an enum which would help the frontend team to render the appropriate question type.

Then I created my main DTO which is the program DTO.The object contains:
ProgramId,Title,Description
Personal Information
Custom Questions


I implemented my code base using the Clean Architecture.So my backend has 3 layers along with the API:
Application Layer
Infrastructure Layer 
Domain Layer



