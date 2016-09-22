using System;
using System.Collections.Generic;
using System.Text;

namespace DataExplorer.ImportWizard_Controls
{
    public enum WizardDataTarget : int
    {
        SQL_Native_Client = 0,
        Flat_File_Source,
        Microsoft_Access,
        Microsoft_Excel,
        Microsoft_OLEDB_Provider_for_SQL,
        Microsoft_OLEDB_Provider_for_Oracle,
        Microsoft_OLEDB_Provider_for_OLAP_Services,
    }
    public enum FlatFileFormat : int
    {
        Delimited,
        Fixed_Width,
        Ragged_Right
    }
}
