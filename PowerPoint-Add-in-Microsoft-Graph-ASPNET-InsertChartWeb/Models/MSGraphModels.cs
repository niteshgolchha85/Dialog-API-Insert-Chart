﻿// Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license. See full license at the bottom of this file.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerPointAddinMicrosoftGraphASPNETInsertChart.Models
{
    /// <summary>
    /// Models Microsoft Graph entities.
    /// </summary>
    /// <remark>
    /// There are many properties that almost all Microsoft Graph objects have. 
    /// To avoid redundancy in the class definitions, use this abstract class.
    ///</remark>
    public abstract class MSGraphObject
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class ExcelWorkbook : MSGraphObject
    {
        // This class only usese inherited properties.
    }

    public class ExcelSheet : MSGraphObject
    {
        public IEnumerable<Chart> Charts { get; set; }
    }
        
    public class Chart : MSGraphObject
    {
        // Gets or sets the base 64 string representation of the chart.
        public string ImageAsBase64String { get; set; }
    }
}

/*

PowerPoint-Add-in-Microsoft-Graph-ASPNET-InsertChart, https://github.com/OfficeDev/PowerPoint-Add-in-Microsoft-Graph-ASPNET-InsertChart
 
Copyright (c) Microsoft Corporation
All rights reserved. 
 
MIT License:
Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:
 
The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.
 
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.    
  
*/