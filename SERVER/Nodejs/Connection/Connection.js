var Connection = require('tedious').Connection;
var Request = require('tedious').Request;

var config = {
    userName: 'sa',
    password: 'admin@123',
    server: '192.168.0.102',
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