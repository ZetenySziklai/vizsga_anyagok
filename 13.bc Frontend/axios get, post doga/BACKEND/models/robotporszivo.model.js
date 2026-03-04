module.exports = (sequelize, DataTypes) => {
    return sequelize.define("robotporszivo", {
        id: {
            type: DataTypes.INTEGER,
            primaryKey: true,
            autoIncrement: true
        },
        marka: {
            type: DataTypes.STRING,
            allowNull: false
        },
        tipus: {
            type: DataTypes.STRING,
            allowNull: false
        },
        teljesitmeny: {
            type: DataTypes.INTEGER,
            allowNull: false
        },
        ar: {
            type: DataTypes.INTEGER,
            allowNull: false
        }
    }, {
        tableName: "robotporszivo",
        timestamps: false
    });
};
