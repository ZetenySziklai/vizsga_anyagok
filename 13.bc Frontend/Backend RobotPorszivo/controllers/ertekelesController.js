const service = require('../services/ertekelesService');

exports.getAll = async (req, res) => {
  res.json(await service.getAll());
};

exports.getByRobot = async (req, res) => {
  res.json(await service.getByRobot(req.params.robotId));
};

exports.create = async (req, res) => {
  const id = await service.create(req.body);
  res.status(201).json({ id });
};

exports.update = async (req, res) => {
  await service.update(req.params.id, req.body);
  res.json({ message: 'Értékelés frissítve' });
};

exports.delete = async (req, res) => {
  await service.delete(req.params.id);
  res.json({ message: 'Értékelés törölve' });
};
