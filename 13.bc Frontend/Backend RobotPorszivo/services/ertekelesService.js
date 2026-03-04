const repo = require('../repositories/ertekelesRepository');

exports.getAll = () => repo.findAll();
exports.getByRobot = (robotId) => repo.findByRobotId(robotId);

exports.create = (data) => {
  if (data.csillagszam < 1 || data.csillagszam > 5) {
    throw new Error('A csillagszám 1 és 5 között lehet');
  }
  return repo.create(data);
};

exports.update = (id, data) => repo.update(id, data);
exports.delete = (id) => repo.delete(id);
