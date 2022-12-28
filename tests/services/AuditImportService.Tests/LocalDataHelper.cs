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
    
    
}