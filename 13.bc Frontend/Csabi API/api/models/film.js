const {Model} = require("sequelize")

module.exports = (sequelize, DataTypes)=>{
    class film extends Model{}
    film.init(
        {
            Cim:{
                type: DataTypes.STRING,
                allowNull: false,
                primaryKey: true,

            },
            Hossz:{
                type: DataTypes.INTEGER,
                allowNull:false
            },
            Ertekeles:{
                type: DataTypes.DOUBLE,
                allowNull: false,
            },
            

            

        },
        {
            sequelize,
            modelName: "film",
            timestamps: false,
        }
    )
    return film
}