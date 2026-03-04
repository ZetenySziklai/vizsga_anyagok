const db = require('../db/mysql');

exports.findAll = async () => {
  const [rows] = await db.query('SELECT * FROM robotporszivo');
  return rows;
};

exports.findById = async (id) => {
  const [rows] = await db.query(
    'SELECT * FROM robotporszivo WHERE id = ?',
    [id]
  );
  return rows[0];
};

exports.create = async (robot) => {
  const [result] = await db.query(
    'INSERT INTO robotporszivo (marka, tipus, teljesitmeny, ar) VALUES (?, ?, ?, ?)',
    [robot.marka, robot.tipus, robot.teljesitmeny, robot.ar]
  );
  return result.insertId;
};

exports.update = async (id, robot) => {
  await db.query(
    'UPDATE robotporszivo SET marka=?, tipus=?, teljesitmeny=?, ar=? WHERE id=?',
    [robot.marka, robot.tipus, robot.teljesitmeny, robot.ar, id]
  );
};

exports.delete = async (id) => {
  await db.query('DELETE FROM robotporszivo WHERE id = ?', [id]);
};
