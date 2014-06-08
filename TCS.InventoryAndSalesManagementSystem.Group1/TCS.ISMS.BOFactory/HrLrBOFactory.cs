﻿//File Description	: This page shows Highest And Lowest Rolling Items BO
// ---------------------------------------------------------------------------------
//	Date Created		:19 Apr, 2013
//	Author			    :Naincy Jain, Tata Consultancy Services
/////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCS.ISMS.BO;
using TCS.ISMS.Types;


namespace TCS.ISMS.BOFactory
{
    public class HrLrBOFactory
    {
        public static IHRLR CreateIHRLRObject()
        {
            IHRLR objHrLr = new HRLR();
            return objHrLr;
        }
    }
}
