const service = require('../services/robotService');

exports.getAll = async (req, res) => {
  res.json(await service.getAll());
};

exports.getById = async (req, res) => {
  res.json(await service.getById(req.params.id));
};

exports.create = async (req, res) => {
  const id = await service.create(req.body);
  res.status(201).json({ id });
};

exports.update = async (req, res) => {
  await service.update(req.params.id, req.body);
  res.json({ message: 'Robot frissítve' });
};

exports.delete = async (req, res) => {
  await service.delete(req.params.id);
  res.json({ message: 'Robot törölve' });
};
