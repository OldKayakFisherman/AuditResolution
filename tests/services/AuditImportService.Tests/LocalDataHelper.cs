using System;
using System.Collections.Generic;
using AuditImportService.Data.Entities;

namespace AuditImportService.Tests;

public static class LocalDataHelper
{
    public static IList<DBKeyImportLog> GetGeneral2022DBKeyImportLogData()
    {
        List<DBKeyImportLog> retval = new List<DBKeyImportLog>();
        DBKeyImportLog log = new DBKeyImportLog();

        retval.Add(new DBKeyImportLog(){DbKey = 235552, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog(){DbKey = 227142, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog(){DbKey = 206303, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog(){DbKey = 197953, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog(){DbKey = 146609, AuditYear = 2022, DateAdded = DateTime.Now});
        

        return retval;
    }
    
    public static IList<DBKeyImportLog> GetCapTextDbKeyImportLogData()
    {
        List<DBKeyImportLog> retval = new List<DBKeyImportLog>();
        DBKeyImportLog log = new DBKeyImportLog();

        /*
           AuditYear = 2022
           DbKey 64473, 220301, 50271, 150547, 207055   
        */
        
        retval.Add(new DBKeyImportLog(){DbKey = 64473, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog(){DbKey = 220301, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog(){DbKey = 50271, AuditYear = 2022, DateAdded = DateTime.Now}); 
        /* Research Why Data is not being returned *///retval.Add(new DBKeyImportLog(){DbKey = 150547, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog(){DbKey = 207055, AuditYear = 2022, DateAdded = DateTime.Now});
        

        return retval;
    }
    
    
}