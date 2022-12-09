# Pierre's Bakery

#### By Kirsten Opstad 

#### A console application for a fictional bakery

## Technologies Used

* C#
* .Net 6

## Description

### Objectives (MVP)

Create a C# console application for a bakery that includes the following functionality:

* There should be two classes: one for Bread and one for Pastry.

* When the user runs the application, they should receive a prompt with a welcome message along with the cost for both Bread and Pastry.

* A user should be able to specify how many loaves of Bread and how many Pastrys they'd like.

*  The application will return the total cost of the order.

* The application will account for the following deals:

  Bread: Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.
  Pastry: Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.

All functionality for the models should be tested using red, green, refactor workflow.

<!-- [x] Screenshots

![Screenshots](https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.03bZmDGXaBhBYyxxp3Ls3gHaEA%26pid%3DApi&f=1&ipt=e980d57210242747a51c41421e1f09a6de3b1fdaeaadd297496787bb64e80c88&ipo=images) -->

<!-- [Link to operational site](http://www.kirstenopstad.github.com/<REPOSITORY NAME>) -->

### Goals
1. Meet MVP ✅
2. Allow users to buy different kinds of Bread and Pastry.
3. Add additional deals beyond the ones mentioned above.
4. Stretch Goal: Use class inheritance to DRY up code for the Bread and Pastry class.
5. Stretch Goal: Allow users to keep adding to an order. In order to do this, you will need to use static variables. See the lesson on static variables to complete this objective.

## Setup/Installation Requirements

* Clone this repo to your workspace.
* Navigate to the top level of the directory.
* Navigate to program directory ``` $ cd ProjectName ```
* Build the project with ``` $ dotnet build ```
* Run the project with ``` $ dotnet run ```

## Known Bugs

* No known bugs. If you find one, please email me at kirsten.opstad@gmail.com with the subject **[_Repo Name_] Bug** and include:
  * BUG: _A brief description of the bug_
  * FIX: _Suggestion for solution (if you have one!)_
  * If you'd like to be credited, please also include your **_github user profile link_**

## License
<!-- [Choose License](https://choosealicense.com/) -->

MIT License

Copyright (c) 2022 Kirsten Opstad

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
