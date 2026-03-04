const repo = require('../repositories/robotRepository');

exports.getAll = () => repo.findAll();
exports.getById = (id) => repo.findById(id);
exports.create = (data) => repo.create(data);
exports.update = (id, data) => repo.update(id, data);
exports.delete = (id) => repo.delete(id);
