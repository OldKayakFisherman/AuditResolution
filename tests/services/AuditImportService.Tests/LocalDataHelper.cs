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
           DbKey 64473, 220301, 50271,207055   
        */
        
        retval.Add(new DBKeyImportLog(){DbKey = 64473, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog(){DbKey = 220301, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog() { DbKey = 50271, AuditYear = 2022, DateAdded = DateTime.Now });
        retval.Add(new DBKeyImportLog(){DbKey = 207055, AuditYear = 2022, DateAdded = DateTime.Now});
        

        return retval;
    }
    public static IList<DBKeyImportLog> GetFindingDbKeyImportLogData()
    {
        List<DBKeyImportLog> retval = new List<DBKeyImportLog>();
        DBKeyImportLog log = new DBKeyImportLog();
        
        retval.Add(new DBKeyImportLog(){DbKey = 215447, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog(){DbKey = 232329, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog() { DbKey = 228595, AuditYear = 2022, DateAdded = DateTime.Now });
        retval.Add(new DBKeyImportLog(){DbKey = 184042, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog(){DbKey = 161114, AuditYear = 2022, DateAdded = DateTime.Now});

        return retval;
    }
    
    public static IList<DBKeyImportLog> GetFindingTextDbKeyImportLogData()
    {
        List<DBKeyImportLog> retval = new List<DBKeyImportLog>();
        DBKeyImportLog log = new DBKeyImportLog();
        
        retval.Add(new DBKeyImportLog(){DbKey = 221284, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog(){DbKey = 101869, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog() { DbKey = 104243, AuditYear = 2022, DateAdded = DateTime.Now });
        retval.Add(new DBKeyImportLog(){DbKey = 221284, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog(){DbKey = 229060, AuditYear = 2022, DateAdded = DateTime.Now});

        return retval;
    }
    
    public static IList<DBKeyImportLog> GetPassthroughDbKeyImportLogData()
    {
        List<DBKeyImportLog> retval = new List<DBKeyImportLog>();
        DBKeyImportLog log = new DBKeyImportLog();
        
        /*
                   AuditYear = 2022
                   DbKey 135478, 136783, 138444, 141033, 141139
             
            */    
        
        retval.Add(new DBKeyImportLog(){DbKey = 135478, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog(){DbKey = 136783, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog() { DbKey = 138444, AuditYear = 2022, DateAdded = DateTime.Now });
        retval.Add(new DBKeyImportLog(){DbKey = 141033, AuditYear = 2022, DateAdded = DateTime.Now});
        retval.Add(new DBKeyImportLog(){DbKey = 141139, AuditYear = 2022, DateAdded = DateTime.Now});

        return retval;
    }
}