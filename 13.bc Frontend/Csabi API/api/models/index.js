const { DataTypes } = require("sequelize");

module.exports = (sequelize) =>
{
    

    const film = require("./film")(sequelize, DataTypes);

    

    return { film };
}