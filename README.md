# DataExplorer-v2
A powerful and flexible data query tool.

NOTE:  The solution file does require several projects from the RainstormStudios repo.  You will need to download that code seperately.
*RainstormStudios
*RainstormStudios.Controls
*RainstormStudios.Data
*RainstormStudios.Data.DB2
*RainstormStudios.Drawing
*RainstormStudios.Unmanaged

I started this project several years ago, as an easy way to connect with both SQL database instsances, as well as CSV and Excel files.

Over the years, it was expanded with data visualization functionality, among other features, as needs arose.

Currently, the auto-complete functionality requires the use of a schema or table alias, and only works against a MS-SQL data source.
I hope to change that in the future.

There are little bugs here and there, but this version is largely considered "complete" at this point.  I have already started a
complete re-write of the application, using Scintilla as the editor surface, instead of my home-grown control.  I plan to also
incorporate the ability to group the active queries into folders, and have better management for unresolved transactions.
