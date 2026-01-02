using Microsoft.Data.SqlClient;
using todo26.data;

Console.WriteLine("To Do 2026 Console");
Console.WriteLine();

new ConnectionAudit().Audit();
new EntityAddAudit().Audit();
new EntityReadAudit().Audit();

Console.WriteLine();
Console.WriteLine("Done");
