var sql = require("mssql");
var connect = function()
{
    var conn = new sql.ConnectionPool({
        user: 'sa',
        password: 'admin@123',
        server: '',
        database: 'TESTDB'
    });
 
    return conn;
};

module.exports = connect;