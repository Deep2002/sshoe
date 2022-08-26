---
name: _Logon  View_Standard Issues
about: Logon View Standard Issues
title: Logon View Standard Issues
labels: Logon View
assignees: ''

---

## The Course Weekly Google Meeting [Syllabus Requirement]

- [ ] I am aware that what is discussed/covered in the Weekly Google Meetings for this course is considered part of the course content.
- [ ] I have either fully attended or fully viewed the Weekly Google Meetings (Q&A and Show and Tell) recordings up to the point of this `Pull Request` and Moodle Submission. 
## Before submitting a Pull Request and Moodle Submission

- [ ] All Open `Issues` have been addressed and closed

## Requirements 

- [ ] My Project complies with all the requirements as identified in the `INEW 2332 Logon View Requirements` document in the course (In the `Logon View` unit)

- [ ] My Project complies with all the requirements as identified in the `Project Wide Requirements
and Resources` (Top of the course in Moodle) documentation in the course

- [ ] My Project complies with all the requirements and information as identified in Moodle to this point in the course

## Code Comments
Brief comments must be placed directly above or inside each EVENT, FUNCTION, or PROCEDURE briefly describing its purpose and any other relevant information. 

Required mandatory course remarks will appear at the top of each form, module, class. See Moodle for specifics on course in Mandatory Required Remarks.

## Naming Conventions

- [ ] All Objects, Variables, Forms, Procedures, Classes, Controls, etc. will be named with meaningful names for what they do, what data they hold, etc. They will also be named using Hungarian notation where appropriate with Pascal case (aka: Upper CamelCase) and to course naming standards (see Moodle).

```
Examples:
intLoopCounter, decMoneyPaid, strFirstName, btnClickMe, lblLastNamePrompt, GetLastName(), SetFirstName(strFirstName), frmInventory, clsDataConnections.
```

## MessageBox's

- [ ] All MessageBox ’s must be fully formed. (All four elements specified: Text, Title, Button, Icon1).

**Example:**
```
MessageBox.Show("Text to Display", "Title to Display",   
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
```

## Validations

- [ ] I have tested my `Username` validation thoroughly using the  `Data Testing` spreadsheet in the course. Testing both Valid and Invalid data to ensure my program meets the validation requirements

- [ ] I have tested my `Password` validation thoroughly using the  `Data Testing` spreadsheet in the course. Testing both Valid and Invalid data to ensure my program meets the validation requirements

- [ ] I have tested my `Email Address` validation thoroughly using the  `Data Testing` spreadsheet in the course. Testing both Valid and Invalid data to ensure my program meets the validation requirements

- [ ] I have tested my `Zip code` validation thoroughly using the  `Data Testing` spreadsheet in the course. Testing both Valid and Invalid data to ensure my program meets the validation requirements

- [ ] I have tested my `Security Questions` usage against the requirements as listed in the `INEW 2332 Logon View Requirements` document in the course

- [ ] I have tested my `Username` validation against the requirements as listed in the `INEW 2332 Logon View Requirements` document in the course

- [ ] I have tested my `Password` validation against the requirements as listed in the `INEW 2332 Logon View Requirements` document in the course

- [ ] I have reviewed and applied the `Data Usage` requirements as listed in the `INEW 2332 Logon View Requirements` document in the course
## Mandatory Classes/Usage

- [ ] I have reviewed and applied the `Mandatory Classes` requirements as listed in the `INEW 2332 Logon View Requirements` document in the course
     - clsValidation.cs
     - clsSQL.cs
     - clsHelp.cs

## Form Design Requirements (All Forms)

- [ ] Interfaces and usability will be in the context of End User (non-Programmer usage)

- [ ] Color choices must be professional, user friendly, appropriate and ADA compliant

- [ ] Form Layout and Flow must be professional, user friendly, appropriate and ADA compliant

- [ ] Tab order should be correct/appropriate

- [ ] ControlBox 
Value: True 
Explanation: ADA Compliance 

- [ ] Font
Value: Size 14 

- [ ] FormBorderStyle 
Value: FixedSingle
Explanation: Unless form resizing handled, professional appearing and appropriate 

- [ ] Icon
Explanation: Custom Icon for your program/project or Form

- [ ] MaximizeBox 
Value: False
Explanation: Unless form resizing handled, professional appearing and appropriate 

- [ ] MinimizeBox 
Value: True 
Explanation: ADA Compliance and Usability 

- [ ] (Name) 
Explanation: Must be to course naming standards (See Course Naming Conventions)

- [ ] StartPosition 
Value: CenterScreen 
Explanation: All forms must startup/launch centered on the user’s screen. Unless otherwise approved on an individual, case by case, basis by the instructor. 

- [ ] AcceptButton 
Explanation: Set to most appropriate “default” button if the user presses the “Enter” key on the keyboard. 

- [ ] CancelButton 
Explanation: Set to the most appropriate “default’ button if the user presses the “ESC” key on the keyboard. 

- [ ] Form Display Method
Value: System Modal 
Explanation: All forms must be set to System Modal unless otherwise handled. Any previous form must be hidden or closed.

## Americans with Disabilities Act (ADA)

### Minimum ADA Expectations:    
- [ ] ControlBox Control present on all forms
- [ ] Forms able to Minimize
- [ ] Forms scalable if Maximize or Form sizing/Form Border sizing is enabled
- [ ] Navigable and functionally usable by keyboard only
- [ ] Access Keys/Accelerator
- [ ] Keys/Shortcut Keys
- [ ] Tab Order, left to right, top to bottom
- [ ] Accept/Cancel buttons
- [ ] Appropriate font type, font size, and color usage

### From ADA.gov: 
>**"For example, basic accessibility features in computer operating systems enable some people with low vision to see computer displays by simply adjusting color schemes, contrast settings, and font sizes. Operating systems enable people with limited manual dexterity to move the mouse pointer using key strokes instead of a standard mouse. Many other types of assistive technology are available, and more are still being developed."**

## Exception Handling
 
- [ ] Unhandled Exceptions must be appropriately handled using a Try/Catch or Try/Catch/Finally to avoid program crashes which will result in course failure. 

- [ ] Try/Catch or Try/Catch/Finally statements must not have empty code blocks { } in any of the code blocks. 

- [ ] The “Catch” portion of the statement must provide appropriate and professional feedback/actions for the user.

- [ ] Try/Catch and Try/Catch/Finally statements are not to be used as Validation   Methods.

```
Examples: 
- Areas with formulas and calculations (Divide by 0 errors, NaN, etc.)
- Database (SQL) connections/access, INSERT, UPDATE, DELETE, etc.
- File I/O, Permission Issues, Pathing Errors, etc. 
- Code using subscripts such as **For** Loops
- DataGridView - Subscript usage with rows and/or columns, etc.
```

## Data Type Conversions

Validation should be used for all user input to ensure data integrity and validity **before** attempting to use the user provided data in your application. 

### {DataType}.TryParse()
All **{DataType}.TryParse()** must be contained within an **IF** or **IF/ELSE** statement. **IF** or **IF/ELSE** statements cannot have empty blocks.

See examples below:
```
string strValue = "a" ; 
//Initialized to something that will fail on purpose int intValue = 0 ; 
if (!int.TryParse(strValue, out intValue))
{ 
     MessageBox.Show( "You did not enter a value I can convert to an Integer" , "Conversion Issue" , MessageBoxButtons.OK, MessageBoxIcon.Error); //Or other handling as appropriate 
}
```

```
String strValue = "a" ; //Initialized   to   something   that   will   fail   on   purpose   
int intValue = 0 ;     
if (int.TryParse(strValue, out intValue))   
{        
     MessageBox.Show( "Your conversion successful!" , "Conversion Success", MessageBoxButtons.OK, MessageBoxIcon.Information); //Or other handling as appropriate
}
else
{
     MessageBox.Show( "You did not enter a value I can convert to an Integer", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);   
}
```
