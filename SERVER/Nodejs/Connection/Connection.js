var Connection = require('tedious').Connection;
var Request = require('tedious').Request;

var config = {
    userName: 'sa',
    password: 'admin@123',
    server: '172.20.10.2',
    //db name : DBGD port: 1433
    // If you're on Windows Azure, you will need this:
    options: {
        database:"DBGD",
        encrypt: true,
    }
};

var connection = new Connection(config);

connection.on('connect', function (err) {
    executeStatement();
}
);

function executeStatement() {
    request = new Request("SELECT TABLE_NAME FROM DBGD.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", function (err, rowCount) {
        if (err) {
            console.log(err);
        } else {
            console.log(rowCount + ' rows');
        }
    });

    request.on('row', function (columns) {
        columns.forEach(function (column) {
            console.log(column.value);
        });
    });

    connection.execSql(request);
}

// module.exports = connect;