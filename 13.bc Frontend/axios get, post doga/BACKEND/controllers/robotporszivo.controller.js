const sequelize = require("../db");
const { DataTypes } = require("sequelize");

const Robot = require("../models/robotporszivo.model")(sequelize, DataTypes);

// GET all
exports.getAll = async (req, res) => {
    const robots = await Robot.findAll();
    res.json(robots);
};

// GET by id
exports.getById = async (req, res) => {
    const robot = await Robot.findByPk(req.params.id);
    if (!robot) return res.status(404).json({ message: "Not found" });
    res.json(robot);
};

// POST
exports.create = async (req, res) => {
    const robot = await Robot.create(req.body);
    res.status(201).json(robot);
};

// PUT
exports.update = async (req, res) => {
    const robot = await Robot.findByPk(req.params.id);
    if (!robot) return res.status(404).json({ message: "Not found" });

    await robot.update(req.body);
    res.json(robot);
};

// DELETE
exports.remove = async (req, res) => {
    const robot = await Robot.findByPk(req.params.id);
    if (!robot) return res.status(404).json({ message: "Not found" });

    await robot.destroy();
    res.json({ message: "Deleted" });
};
